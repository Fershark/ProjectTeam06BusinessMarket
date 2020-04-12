using BusinessMarketplaceEntitiesNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam06BusinessMarketplaceForms
{
    public partial class Shop : Form
    {
        private BusinessMarketplaceEntitiesContext context;
        private Business business;
        private Order order;

        public Shop(BusinessMarketplaceEntitiesContext context, Business business)
        {
            InitializeComponent();

            this.context = context;
            this.business = business;

            Load += ShopForm_Load;
            buttonAddToOrder.Click += ButtonAddToOrder_Click;
            buttonRemovefromOrder.Click += ButtonRemovefromOrder_Click;
            buttonCheckout.Click += ButtonCheckout_Click;
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            context.SaveChanges();
            context.Products.Load();
            order = new Order { TotalPrice = 0, Business = business };

            groupBoxShop.Text = $"{business.Name} is shopping";

            var filteredProducts = context.Products.Local.Where(p => p.Business != business && p.QuantityInStock > 0).ToArray();
            FormUtils.InitalizeDataGridView(dataGridViewOtherProducts, filteredProducts, true, "Id", "BusinessID", "Orders", "CategoryID", "Price", "Category", "Business", "QuantityInStock");
            MapOrderToForm();
        }

        private void MapOrderToForm()
        {
            List<Product> products = order.Products.ToList();
            List<ProductInOrder> productsInOrder = new List<ProductInOrder>();
            order.TotalPrice = 0;
            foreach (var product in products)
            {
                order.TotalPrice += product.Price;
                productsInOrder.Add(new ProductInOrder(product));
            }

            FormUtils.InitalizeDataGridView(dataGridViewOrder, productsInOrder, true, "Product");
            labelTotalData.Text = order.TotalPrice.ToString("c");
        }

        private void ButtonAddToOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOtherProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No products were selected");
                return;
            }

            List<Product> productsToAddToOrder = new List<Product>();
            foreach (DataGridViewRow row in dataGridViewOtherProducts.SelectedRows)
            {
                productsToAddToOrder.Add(row.DataBoundItem as Product);
            }

            foreach (Product product in productsToAddToOrder)
            {
                if (order.Products.Contains(product))
                    MessageBox.Show($"Product: {product.Name} is already in the order");
                else
                    order.Products.Add(product);
            }

            MapOrderToForm();
        }

        private void ButtonRemovefromOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("No products in the order were selected");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewOrder.SelectedRows)
            {
                ProductInOrder productInOrder = row.DataBoundItem as ProductInOrder;
                order.Products.Remove(productInOrder.Product);
            }

            MapOrderToForm();
        }

        private void ButtonCheckout_Click(object sender, EventArgs e)
        {
            if (order.Products.Count() <= 0)
            {
                MessageBox.Show("There are no products in the order");
                return;
            }

            order.OrderDate = DateTime.Now;

            context.Orders.Add(order);
            foreach (var product in order.Products)
            {
                product.QuantityInStock--;
            }

            context.SaveChanges();
            MessageBox.Show("Order checkout successful");
            Close();
        }
    }
}
