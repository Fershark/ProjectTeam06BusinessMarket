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
    public partial class SalesForm : Form
    {
        private BusinessMarketplaceEntitiesContext context;

        public SalesForm(BusinessMarketplaceEntitiesContext context)
        {
            InitializeComponent();

            this.context = context;

            Load += SalesForm_Load;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            context.SaveChanges();
            context.Businesses.Load();
            context.Categories.Load();
            context.Products.Load();
            context.Orders.Load();

            comboBoxBusiness.DataSource = context.Businesses.Local.ToBindingList();
            comboBoxCategory.DataSource = context.Categories.Local.ToBindingList();

            ResetControlsToDefault();

            buttonResetFilters.Click += ButtonResetFilters_Click;
            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
        }

        private void ButtonResetFilters_Click(object sender, EventArgs e)
        {
            ResetControlsToDefault();
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

        public void DisplayProducts()
        {
            var business = comboBoxBusiness.SelectedItem as Business;
            var category = comboBoxCategory.SelectedItem as Category;
            var productName = textBoxProductName.Text.Trim();

            var productsSold = context.Products.Local
                .Where(p => 
                    (business == null || p.Business == business) 
                    && (category == null || p.Category == category) 
                    && (productName == "" || p.Name.Contains(productName)))
                .Select(p => new ProductSales
                {
                    ProductId = p.Id,
                    BusinessName = p.Business.Name,
                    CategoryName = p.CategoryName,
                    ProductName = p.Name,
                    TimesSold = context.Orders.Local.Where(o => o.Products.Contains(p)).Count(),
                    Product = p
                });
            FormUtils.InitalizeDataGridView(dataGridViewProducts, productsSold.ToArray(), false, "Product");
            labelProductsCountData.Text = productsSold.Count().ToString();

            ResetBuyers();
        }

        private void ResetBuyers()
        {
            dataGridViewBuyers.DataSource = null;
            labelBuyerssCountData.Text = "0";
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
        /// Event handler for updating the selected transactions based on the filters selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterChanged(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var productSales = dataGridViewProducts.SelectedRows[0].DataBoundItem as ProductSales;
                if (productSales != null)
                {
                    var buyers = context.Orders.Local
                        .Where(o => o.Products.Contains(productSales.Product))
                        .Select(o => new Buyer
                        {
                            OrderDateString = o.OrderDateString,
                            BusinessName = o.Business.Name,
                            BusinessEmail = o.Business.Email,
                            BusinessAddress = o.Business.Address,
                            Business = o.Business
                        });

                    FormUtils.InitalizeDataGridView(dataGridViewBuyers, buyers.ToArray(), false, "Business");
                    labelBuyerssCountData.Text = buyers.GroupBy(b => b.Business).Count().ToString();
                    return;
                }
            }

            ResetBuyers();
        }

        /// <summary>
        /// Private class to display the product information correctly
        /// </summary>
        private class ProductSales
        {
            [DisplayName("Product ID")]
            public int ProductId { get; set; }

            [DisplayName("Product Name")]
            public string ProductName { get; set; }

            [DisplayName("Business")]
            public string BusinessName { get; set; }

            [DisplayName("Category")]
            public string CategoryName { get; set; }

            [DisplayName("Times Sold")]
            public int TimesSold { get; set; }

            public Product Product { get; set; }
        }

        private class Buyer
        {
            [DisplayName("Purchase Date")]
            public string OrderDateString { get; set; }

            [DisplayName("Business Name")]
            public string BusinessName { get; set; }

            [DisplayName("Business Email")]
            public string BusinessEmail { get; set; }

            [DisplayName("Business Address")]
            public string BusinessAddress { get; set; }

            public Business Business { get; set; }
        }
    }
}
