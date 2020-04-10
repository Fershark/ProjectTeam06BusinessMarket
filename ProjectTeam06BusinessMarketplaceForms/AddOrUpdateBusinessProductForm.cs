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

            public AddOrUpdateBusinessProductForm(BusinessMarketplaceEntitiesContext context)
            {
                InitializeComponent();

                this.context = context;
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
                ReloadListBoxData();
                CleanForm();
            }

            private void ReloadListBoxData()
            {
                context.SaveChanges();
                context.Businesses.Load();

                // We force the refresh of the listbox since without reassigning the data source
                // the listBox data doesn't change
                listBoxProduct.DataSource = null;
                listBoxProduct.DataSource = context.Products.Local.ToBindingList();
            }

            private void CleanForm()
            {
                listBoxProduct.SelectedIndex = -1;
                product = new Product();
                MapProductToForm();
            }
            private void MapProductToForm()
            {
                labelProductIdNumber.Text = product.Id.ToString();
                textBoxProductName.Text = product.Name == null ? "" : product.Name;
                textBoxProductDescription.Text = product.Description == null ? "" : product.Description;
                textBoxQuantityInStock.Text = product.QuantityInStock.ToString();
                textBoxProductPrice.Text = product.Price.ToString();
                labelBusinessIdNumber.Text = product.BusinessId.ToString();
                labelCategoriesIdNumber.Text = product.CategoryId.ToString();
            }


            private void ButtonUpdateProduct_Click(object sender, EventArgs e)
            {
                string name = textBoxProductName.Text;
                string description = textBoxProductDescription.Text;
                string quantityInStock = textBoxQuantityInStock.Text;
                string price = textBoxProductPrice.Text;
                string message = "";
           


                if (name.Trim().Length == 0)
                {
                    message = "Name is reuired.";
                }
                else if (description.Trim().Length == 0)
                {
                    message = "Desctiption is required";
                }
                else if (quantityInStock.Trim().Length == 0)
                {
                    message = "Quantity In Stock is required.";
                }
                else if (price.Trim().Length == 0)
                {
                    message = "Price is required.";
                }
                else
                {

                    product.Name = name;
                    product.Description = description;
                    //if id is 0 it means we need to add id 
                    if (product.Id == 0)
                    {
                        context.Products.Add(product);
                        ReloadListBoxData();
                        listBoxProduct.SelectedIndex = context.Businesses.Count() - 1;
                        message = "Product added successfully.";
                    }
                    else
                    {
                        ReloadListBoxData();
                        message = "Product updated seccessfully";
                    }
                }
                MessageBox.Show(message);


            }

        //mistake
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


