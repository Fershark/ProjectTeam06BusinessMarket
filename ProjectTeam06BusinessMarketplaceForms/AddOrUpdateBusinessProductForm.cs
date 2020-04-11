using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessMarketplaceEntitiesNS;


namespace ProjectTeam06BusinessMarketplaceForms
{
    public partial class AddOrUpdateBusinessProductForm : Form
    {
        private BusinessMarketplaceEntitiesContext context;
        private Product product;
        private Business business;

        public AddOrUpdateBusinessProductForm(BusinessMarketplaceEntitiesContext context, Business business)
        {
            InitializeComponent();

            this.context = context;
            this.business = business;

            Load += AddOrUpdateBusinessProductForm_Load;

            buttonAddProduct.Click += ButtonAddProduct_Click;
            listBoxProduct.SelectedIndexChanged += ListBoxBusinessProduct_SelectedIndexChanged;
            buttonUpdateProduct.Click += ButtonUpdateProduct_Click;
        }

        /// <summary>
        /// Select index of listbox callback.
        /// If the value selected is of business name it maps its values to the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxBusinessProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProduct.SelectedValue is Product p)
            {
                product = p;
                MapProductToForm();
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void AddOrUpdateBusinessProductForm_Load(object sender, EventArgs e)
        {
            labelBusinessNameData.Text = business.Name;
            comboBoxCategory.DataSource = context.Categories.Local.ToBindingList();

            ReloadListBoxData();
            CleanForm();
        }

        private void ReloadListBoxData()
        {
            context.SaveChanges();
            context.Products.Load();

            // We force the refresh of the listbox since without reassigning the data source
            // the listBox data doesn't change
            listBoxProduct.DataSource = null;
            listBoxProduct.DataSource = context.Products.Local.Where(p => p.Business == business).ToArray();
        }

        private void CleanForm()
        {
            listBoxProduct.SelectedIndex = -1;
            product = new Product();
            product.Business = business;
            MapProductToForm();
        }

        private void MapProductToForm()
        {
            labelProductIdNumber.Text = product.Id.ToString();
            textBoxProductName.Text = product.Name == null ? "" : product.Name;
            textBoxProductDescription.Text = product.Description == null ? "" : product.Description;
            textBoxQuantityInStock.Text = product.QuantityInStock.ToString();
            textBoxProductPrice.Text = product.Price.ToString();

            if (product.Category == null)
                comboBoxCategory.SelectedIndex = 0;
            else
                comboBoxCategory.SelectedItem = product.Category;
        }

        private void ButtonUpdateProduct_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            string description = textBoxProductDescription.Text;
            string quantityInStockString = textBoxQuantityInStock.Text;
            string priceString = textBoxProductPrice.Text;
            int quantityInStock = 0;
            decimal price = 0;
            Category category = comboBoxCategory.SelectedItem as Category;
            string message = "";

            if (name.Trim().Length == 0)
            {
                message = "Name is required.";
            }
            else if (description.Trim().Length == 0)
            {
                message = "Desctiption is required";
            }
            else if (quantityInStockString.Trim().Length == 0)
            {
                message = "Quantity In Stock is required.";
            }
            else if (priceString.Trim().Length == 0)
            {
                message = "Price is required.";
            }
            else if (!Int32.TryParse(quantityInStockString.Trim(), out quantityInStock)) 
            {
                message = "Quanity in stock should be a natural number.";
            }
            else if (!Decimal.TryParse(priceString.Trim(), out price))
            {
                message = "Price should be a decimal number.";
            }
            else
            {
                product.Name = name;
                product.Description = description;
                product.QuantityInStock = quantityInStock;
                product.Price = price;
                product.Category = category;

                //if id is 0 it means we need to add it
                if (product.Id == 0)
                {
                    context.Products.Add(product);
                    ReloadListBoxData();
                    listBoxProduct.SelectedIndex = context.Products.Count() - 1;
                    message = "Product added successfully.";
                }
                else
                {
                    var selectedIndex = listBoxProduct.SelectedIndex;
                    ReloadListBoxData();
                    listBoxProduct.SelectedIndex = selectedIndex;
                    message = "Product updated successfully.";
                }
            }
            MessageBox.Show(message);
        }
    }
}


