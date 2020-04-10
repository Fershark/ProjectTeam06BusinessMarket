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
    public partial class AddOrUpdateCategoriesForm : Form
    {
        private BusinessMarketplaceEntitiesContext context;
        private Category category;

        public AddOrUpdateCategoriesForm(ProjectTeam06BusinessMarketplaceForm mainForm)
        {
            InitializeComponent();

            context = mainForm.context;
            Load += AddOrUpdateCategoriesForm_Load;

            buttonAddCategories.Click += ButtonAddCategories_Click;
            listBoxCategories.SelectedIndexChanged += ListBoxCategories_SelectedIndexChanged;
            buttonSubmit.Click += ButtonSubmit_Click;
        }

        /// <summary>
        /// Select index of listbox callback.
        /// If the value selected is of type category it maps its values to the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedValue is Category c)
            {
                category = c;
                MapCategoryToForm();
            }
        }

        /// <summary>
        /// When added is clicked it cleans the form, which creates a new category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddCategories_Click(object sender, EventArgs e)
        {
            CleanForm();   
        }

        /// <summary>
        /// Load data to the listbox and cleans the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateCategoriesForm_Load(object sender, EventArgs e)
        {
            ReloadListBoxData();
            CleanForm();
        }

        /// <summary>
        /// Load the categories and load them to the list box
        /// </summary>
        private void ReloadListBoxData()
        {
            context.SaveChanges();
            context.Categories.Load();

            // We force the refresh of the listbox since without reassigning the data source
            // the listBox data doesn't change
            listBoxCategories.DataSource = null;
            listBoxCategories.DataSource = context.Categories.Local.ToBindingList();
        }

        /// <summary>
        /// Unselects items from the listbox and create a new category and map that to the form
        /// </summary>
        private void CleanForm()
        {
            listBoxCategories.SelectedIndex = -1;
            category = new Category();
            MapCategoryToForm();
        }

        /// <summary>
        /// Map the values of the category to the form fields
        /// </summary>
        private void MapCategoryToForm()
        {
            labelId.Text = category.Id.ToString();
            textBoxName.Text = category.Name == null ? "" : category.Name;
            textBoxDescription.Text = category.Description == null ? "" : category.Description;
        }

        /// <summary>
        /// Validate and save the category.
        /// It displays a message with the result.
        /// If the category is new it selects the last index from the DbSet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            string message = "";

            if (name.Trim().Length == 0)
            {
                message = "Name is required.";

            }
            else if (description.Trim().Length == 0)
            {
                message = "Description is required.";
            }
            else
            {
                category.Name = name;
                category.Description = description;
                //If id is 0 it means we need to add it
                if (category.Id == 0)
                {
                    context.Categories.Add(category);
                    ReloadListBoxData();
                    listBoxCategories.SelectedIndex = context.Categories.Count() - 1;
                    message = "Category added successfully.";
                }
                else
                {
                    ReloadListBoxData();
                    message = "Category updated successfully.";
                }
            }
            MessageBox.Show(message);
        }
    }
}
