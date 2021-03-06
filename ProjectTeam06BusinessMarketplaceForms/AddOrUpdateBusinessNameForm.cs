﻿using System;
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
        //Context shared by all forms
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

        /// <summary>
        /// When a business is selected from the list box map it to the form to display its details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxBusinessName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBusinessName.SelectedValue is Business b)
            {
                business = b;
                MapBusinessToForm();
            }
        }

        /// <summary>
        /// Clean the form when the add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddBusinessName_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        /// <summary>
        /// When this form load; load the data to the list box and clean the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateBusinessNameForm_Load(object sender, EventArgs e)
        {
            ReloadListBoxData();
            CleanForm();
        }

        /// <summary>
        /// Load the data to the list box
        /// </summary>
        private void ReloadListBoxData()
        {
            context.SaveChanges();
            context.Businesses.Load();

            // We force the refresh of the listbox since without reassigning the data source
            // the listBox data doesn't change
            listBoxBusinessName.DataSource = null;
            listBoxBusinessName.DataSource = context.Businesses.Local.ToBindingList();
        }

        /// <summary>
        /// Clean the form by clearing the selection from the list box and creating a new object and map it to the form
        /// </summary>
        private void CleanForm()
        {
            listBoxBusinessName.SelectedIndex = -1;
            business = new Business();
            MapBusinessToForm();
        }

        /// <summary>
        /// Map the object to the form fields
        /// </summary>
        private void MapBusinessToForm()
        {
            labelBusinessIdNumber.Text = business.Id.ToString();
            textBoxBusinessName.Text = business.Name == null ? "" : business.Name;
            textBoxBusinessAddress.Text = business.Address == null ? "" : business.Address;
            textBoxBusinessEmail.Text = business.Email == null ? "" : business.Email;
            checkBoxIsAdmin.Checked = business.IsAdmin.Equals(true);
        }

        /// <summary>
        /// Method to validate the data and add it or update it in the context
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxBusinessName.Text;
            string address = textBoxBusinessAddress.Text;
            string email = textBoxBusinessEmail.Text;
            string message = "";

            if (name.Trim().Length == 0)
            {
                message = "Name is required.";
            }
            else if (address.Trim().Length == 0)
            {
                message = "Address is required.";
            }
            else if (email.Trim().Length == 0)
            {
                message = "Email is required.";
            }
            else
            {
                business.Name = name;
                business.Address = address;
                business.Email = email;
                business.IsAdmin = checkBoxIsAdmin.Checked;

                //if id is 0 it means we need to add it
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
    }
}
