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
    public partial class AddOrUpdateBusinessNameForm : Form
    {
        private BusinessMarketplaceEntitiesContext context;
        private Business business;
        public AddOrUpdateBusinessNameForm(BusinessMarketplaceEntitiesContext context)
        {
            InitializeComponent();

            this.context = context;
            Load += AddOrUpdateBusinessNameForm_Load;

            buttonAddBusinessName.Click += ButtonAddBusinessName_Click;
            listBoxBusinessName.SelectedIndexChanged += ListBoxBusinessName_SelectedIndexChanged;
            buttonSubmitBusinessName.Click += ButtonSubmit_Click;


        }

        private void ListBoxBusinessName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBusinessName.SelectedValue is Business b)
            {
                business = b;
                MapBusinessToForm();
            }
        }
        private void ButtonAddBusinessName_Click(object sender, EventArgs e)
        {
            CleanForm();

        }

        private void AddOrUpdateBusinessNameForm_Load(object sender, EventArgs e)
        {
            ReloadListBoxData();
            CleanForm();
        }

        private void ReloadListBoxData()
        {
            context.SaveChanges();
            context.Categories.Load();

            // We force the refresh of the listbox since without reassigning the data source
            // the listBox data doesn't change
            listBoxBusinessName.DataSource = null;
            listBoxBusinessName.DataSource = context.Businesses.Local.ToBindingList();
        }

        private void CleanForm()
        {
            listBoxBusinessName.SelectedIndex = -1;
            business = new Business();
            MapBusinessToForm();
        }


        private void MapBusinessToForm()
        {
            labelBusinessIdNumber.Text = business.Id.ToString();
            textBoxBusinessName.Text = business.Name == null ? "" : business.Name;
            textBoxBusinessAddress.Text = business.Address == null ? "" : business.Address;
            textBoxBusinessEmail.Text = business.Email == null ? "" : business.Email;
            checkBoxIsAdmin.Checked = business.IsAdmin.Equals(true);
        }

      
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxBusinessName.Text;
            string address = textBoxBusinessAddress.Text;
            string email = textBoxBusinessEmail.Text;
            string message = "";

            if (name.Trim().Length == 0)
            {
                message = "Name is required.";

            } else if (address.Trim().Length == 0)
            {
                message = "Address is required.";

            } else if (email.Trim().Length == 0)
            {
                message = "Email is required.";

            } else
            {
                business.Name = name;
                business.Address = address;
                business.Email = email;
                //
                if (business.Id == 0)
                {
                    context.Businesses.Add(business);
                    ReloadListBoxData();
                    listBoxBusinessName.SelectedIndex = context.Businesses.Count() - 1;
                    message = "Business added successfully.";
                }
                else
                {
                    ReloadListBoxData();
                    message = "Business updated successfully.";
                }
            }
            MessageBox.Show(message);
        }


        //mistake for double click on the form
        //will fix later
        private void listBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
