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
    public partial class ProjectTeam06BusinessMarketplaceForm
    {
        private Business businessSigned;

        private void InitBusinessComponents()
        {
            comboBoxBusinessSelected.DataSource = context.Businesses.Local.ToBindingList();
           
            InitalizeDataGridView(dataGridViewOrder, context.Orders.Local.ToBindingList());

            buttonAddUpdateProduct.Click += ButtonAddUpdateProduct_Click;
            comboBoxBusinessSelected.SelectedIndexChanged += ComboBoxBusinessSelected_SelectedIndexChanged;

            //Select the first business in the Database to simulate that business is the one signed in
            //The index is changed twice to trigger the event
            comboBoxBusinessSelected.SelectedIndex = -1;
            comboBoxBusinessSelected.SelectedIndex = 0;
        }

        private void ComboBoxBusinessSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            var business = comboBoxBusinessSelected.SelectedItem as Business;
            if (business != null)
            {
                businessSigned = business;
                ShowBusinessSigned();
            }
        }

        private void ShowBusinessSigned()
        {
            groupBoxBusinessData.Text = businessSigned.Name;
            labelBusinessEmailData.Text = businessSigned.Email;
            labelBusinessAddressData.Text = businessSigned.Address;

            var filteredProducts = context.Products.Local.Where(p => p.Business == businessSigned).ToArray();
            InitalizeDataGridView(dataGridViewBusinessProduct, filteredProducts, "BusinessID", "Business", "Orders", "CategoryID");
        }

        private void ButtonAddUpdateProduct_Click(object sender, EventArgs e)
        {
            AddOrUpdateBusinessProductForm addOrUpdateBusinessProductForm = new AddOrUpdateBusinessProductForm(context, businessSigned);
            addOrUpdateBusinessProductForm.ShowDialog();
            dataGridViewBusinessProduct.Refresh();
        }
    }
}
