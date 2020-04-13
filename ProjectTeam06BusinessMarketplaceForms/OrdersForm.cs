using BusinessMarketplaceEntitiesNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam06BusinessMarketplaceForms
{
    public partial class Orders : Form
    {
        //Context shared through all forms
        private BusinessMarketplaceEntitiesContext context;
        private Business business;

        public Orders(BusinessMarketplaceEntitiesContext context, Business business)
        {
            InitializeComponent();

            this.context = context;
            this.business = business;

            Load += OrdersForm_Load;
        }

        /// <summary>
        /// Display the business' orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            context.SaveChanges();
            context.Products.Load();
            context.Orders.Load();

            groupBoxOrders.Text = $"{business.Name} Orders";

            var ordersFiltered = context.Orders.Local.Where(o => o.Business == business).ToArray();
            FormUtils.InitalizeDataGridView(dataGridViewOrders, ordersFiltered, false, "Id", "BusinessId", "Products", "Business", "OrderDate", "TotalPrice");
            labelOrdersCountData.Text = ordersFiltered.Count().ToString();

            dataGridViewOrders.SelectionChanged += DataGridViewOrders_SelectionChanged;
        }

        /// <summary>
        /// If a row is selected, it displays the products from that order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var order = dataGridViewOrders.SelectedRows[0].DataBoundItem as Order;
                if (order != null)
                {
                    List<Product> products = order.Products.ToList();
                    //Here we use the class from the entities that is not in the database to display the order details
                    List<ProductInOrder> productsInOrder = new List<ProductInOrder>();
                    foreach (var product in products)
                    {
                        productsInOrder.Add(new ProductInOrder(product));
                    }

                    FormUtils.InitalizeDataGridView(dataGridViewOrderProducts, productsInOrder, true, "Product");
                    labelProductsCountData.Text = productsInOrder.Count().ToString();
                    return;
                }
            }

            //If the selection is not of type order we clean the datagrid and the counter
            dataGridViewOrderProducts.DataSource = null;
            labelProductsCountData.Text = "0";
        }
    }
}
