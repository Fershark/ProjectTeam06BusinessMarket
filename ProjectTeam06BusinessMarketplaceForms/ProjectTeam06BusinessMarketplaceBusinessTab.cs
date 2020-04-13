using BusinessMarketplaceEntitiesNS;
using DataTableAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam06BusinessMarketplaceForms
{
    /// <summary>
    /// Partial class to keep all the functionality of the business in one file
    /// </summary>
    public partial class ProjectTeam06BusinessMarketplaceForm
    {
        private Business businessSigned;

        /// <summary>
        /// Method to init the components in the business tab
        /// </summary>
        private void InitBusinessComponents()
        {
            SetBusinessComboBox();

            buttonAddUpdateProduct.Click += ButtonAddUpdateProduct_Click;
            buttonShop.Click += ButtonShop_Click;
            buttonOrders.Click += ButtonOrders_Click;
            buttonBusinessSales.Click += ButtonBusinessSales_Click;
            comboBoxBusinessSelected.SelectedIndexChanged += ComboBoxBusinessSelected_SelectedIndexChanged;
            //Select the first business in the Database to simulate that business is the one signed in
            //The index is changed twice to trigger the event
            comboBoxBusinessSelected.SelectedIndex = -1;
            if (context.Businesses.Local.Count() > 0)
                comboBoxBusinessSelected.SelectedIndex = 0;
        }

        /// <summary>
        /// Method to set the business combo box.
        /// </summary>
        private void SetBusinessComboBox()
        {
            // We force the refresh of the listbox since without reassigning the data source
            // the listBox data doesn't change
            comboBoxBusinessSelected.DataSource = null;
            comboBoxBusinessSelected.DataSource = context.Businesses.Local.ToBindingList();
        }

        /// <summary>
        /// Method to open the form for adding or updating products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddUpdateProduct_Click(object sender, EventArgs e)
        {
            if (businessSigned == null)
            {
                MessageBox.Show("A business should be selected.");
            }
            else
            {
                AddOrUpdateBusinessProductForm addOrUpdateBusinessProductForm = new AddOrUpdateBusinessProductForm(context, businessSigned);
                addOrUpdateBusinessProductForm.ShowDialog();
                dataGridViewBusinessProduct.Refresh();
            }
        }

        /// <summary>
        /// Method to show the shopping form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShop_Click(object sender, EventArgs e)
        {
            if (businessSigned == null)
            {
                MessageBox.Show("A business should be selected.");
            }
            else
            {
                Shop shopForm = new Shop(context, businessSigned);
                shopForm.ShowDialog();
                dataGridViewBusinessProduct.Refresh();
            }
        }

        /// <summary>
        /// Method to show the orders form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOrders_Click(object sender, EventArgs e)
        {
            if (businessSigned == null)
            {
                MessageBox.Show("A business should be selected.");
            }
            else
            {
                Orders ordersForm = new Orders(context, businessSigned);
                ordersForm.ShowDialog();
            }
        }

        /// <summary>
        /// Method to show the sales from the business selected.
        /// To simulate as if a business is signed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBusinessSales_Click(object sender, EventArgs e)
        {
            if (businessSigned == null)
            {
                MessageBox.Show("A business should be selected.");
            }
            else
            {
                SalesForm salesForm = new SalesForm(context, businessSigned);
                salesForm.ShowDialog();
            }
        }

        /// <summary>
        /// Method to call when a different business is selected from the combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxBusinessSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            var business = comboBoxBusinessSelected.SelectedItem as Business;
            if (business != null)
            {
                businessSigned = business;
                ShowBusinessSigned();
            }
        }

        /// <summary>
        /// Method to map the business selected to the form.
        /// It displayed the business information in the form.
        /// </summary>
        private void ShowBusinessSigned()
        {
            groupBoxBusinessData.Text = businessSigned.Name;
            labelBusinessEmailData.Text = businessSigned.Email;
            labelBusinessAddressData.Text = businessSigned.Address;

            var filteredProducts = context.Products.Local.Where(p => p.Business == businessSigned).ToArray();
            FormUtils.InitalizeDataGridView(dataGridViewBusinessProduct, filteredProducts, false, "BusinessID", "Business", "Orders", "CategoryID", "Price", "Category", "Business");
        }
    }
}
