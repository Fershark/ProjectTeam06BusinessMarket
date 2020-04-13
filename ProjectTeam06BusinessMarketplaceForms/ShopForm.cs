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
        //Context shared through all forms
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

            ResetControlsToDefault();

            buttonResetFilters.Click += ButtonResetFilters_Click;
        }

        /// <summary>
        /// Reset the controls to its defaults
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetFilters_Click(object sender, EventArgs e)
        {
            ResetControlsToDefault();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            context.SaveChanges();
            context.Products.Load();
            context.Businesses.Load();
            context.Categories.Load();
            order = new Order { TotalPrice = 0, Business = business };

            //Display all business expect the business who is buying in the filters
            comboBoxBusiness.DataSource = context.Businesses.Local.Where(b => b != business).ToArray();
            comboBoxCategory.DataSource = context.Categories.Local.ToBindingList();

            //Diplay which business is shopping
            groupBoxShop.Text = $"{business.Name} is shopping";

            ResetControlsToDefault();
            MapOrderToForm();
        }

        private void ResetControlsToDefault()
        {
            RemoveEventsFromFilters();

            comboBoxBusiness.SelectedIndex = -1;
            textBoxProductName.Text = "";
            comboBoxCategory.SelectedIndex = -1;

            DisplayProducts();

            AddEventsToFilters();
        }


        /// <summary>
        /// Display the products filtered with compound logic
        /// and the count of how many match the filters.
        /// We show all the products that are different from the business which is shopping
        /// and that have stock
        /// </summary>
        public void DisplayProducts()
        {
            var businessFilters = comboBoxBusiness.SelectedItem as Business;
            var category = comboBoxCategory.SelectedItem as Category;
            var productName = textBoxProductName.Text.Trim();

            var filteredProducts = context.Products.Local
                .Where(p => p.Business != business && p.QuantityInStock > 0)
                .Where(p =>
                    (businessFilters == null || p.Business == businessFilters)
                    && (category == null || p.Category == category)
                    && (productName == "" || p.Name.Contains(productName)))
                .ToArray();
            FormUtils.InitalizeDataGridView(dataGridViewOtherProducts, filteredProducts, true, "Id", "BusinessID", "Orders", "CategoryID", "Price", "Category", "Business", "QuantityInStock");

            labelProductsCountData.Text = filteredProducts.Count().ToString();
        }

        /// <summary>
        /// Display the products with the helper entity and count the total of the order,
        /// show the total of the order and count the items in the order
        /// </summary>
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
            labelProductsInOrderCountData.Text = order.Products.Count().ToString();
        }

        /// <summary>
        /// Funcionality to add the product to the order if an order is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            //When a product is added we map the order to the form
            MapOrderToForm();
        }

        /// <summary>
        /// Method to remove a selected product from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            //When a product is removed we map the order to the form
            MapOrderToForm();
        }

        /// <summary>
        /// Checkout the order. It saves the order with the current date 
        /// and decrement the stock of that product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Helper method to remove event handlers from the filters
        /// </summary>
        private void RemoveEventsFromFilters()
        {
            comboBoxBusiness.SelectedIndexChanged -= FilterChanged;
            comboBoxCategory.SelectedIndexChanged -= FilterChanged;
            textBoxProductName.TextChanged -= FilterChanged;
        }

        /// <summary>
        /// Helper method to add event handlers to the filters
        /// </summary>
        private void AddEventsToFilters()
        {
            comboBoxBusiness.SelectedIndexChanged += FilterChanged;
            comboBoxCategory.SelectedIndexChanged += FilterChanged;
            textBoxProductName.TextChanged += FilterChanged;
        }

        /// <summary>
        /// Event handler for updating the data based on the filters selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterChanged(object sender, EventArgs e)
        {
            DisplayProducts();
        }
    }
}
