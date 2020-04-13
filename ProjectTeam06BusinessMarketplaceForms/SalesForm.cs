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
        //Context shared through all forms
        private BusinessMarketplaceEntitiesContext context;
        private Business business;

        public SalesForm(BusinessMarketplaceEntitiesContext context, Business business = null)
        {
            InitializeComponent();

            this.context = context;
            this.business = business;

            Load += SalesForm_Load;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            context.SaveChanges();
            context.Businesses.Load();
            context.Categories.Load();
            context.Products.Load();
            context.Orders.Load();

            //If the business is null it means the admin wants to see all the sales of 
            //all business
            if (business != null)
            {
                //here the business can see only its own sales
                groupBoxSales.Text = $"{business.Name} Sales";
                List<Business> businesses = new List<Business>();
                businesses.Add(business);
                comboBoxBusiness.DataSource = businesses;
                comboBoxBusiness.SelectedIndex = 0;
            }
            else
            {
                comboBoxBusiness.DataSource = context.Businesses.Local.ToBindingList();
            }

            comboBoxCategory.DataSource = context.Categories.Local.ToBindingList();

            ResetControlsToDefault();

            buttonResetFilters.Click += ButtonResetFilters_Click;
            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
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

        private void ResetControlsToDefault()
        {
            //We remove the events to prevent updates while we clean the data
            RemoveEventsFromFilters();

            comboBoxBusiness.SelectedIndex = business == null ? -1 : 0;
            textBoxProductName.Text = "";
            comboBoxCategory.SelectedIndex = -1;

            DisplayProducts();

            AddEventsToFilters();
        }

        /// <summary>
        /// Display the products and filter it using compound logic
        /// We used a subquery in the select to count the number of times a product is sold
        /// </summary>
        public void DisplayProducts()
        {
            var businessFilters = comboBoxBusiness.SelectedItem as Business;
            var category = comboBoxCategory.SelectedItem as Category;
            var productName = textBoxProductName.Text.Trim();

            var productsSold = context.Products.Local
                .Where(p =>
                    (businessFilters == null || p.Business == businessFilters)
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

        /// <summary>
        /// Reset the buyers data grid and count
        /// </summary>
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
        /// Event handler for updating the data based on the filters selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterChanged(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        /// <summary>
        /// Display the buyers of a product.
        /// It also group the buyers and display the count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Private class to format the buyer information and displayed it in the data grid view
        /// </summary>
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
