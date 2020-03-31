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
        private int id = -1;

        public AddOrUpdateCategoriesForm()
        {
            InitializeComponent();

            context = new BusinessMarketplaceEntitiesContext();
            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();

            context.Categories.Load();

            Load += AddOrUpdateCategoriesForm_Load;

            buttonAddCategories.Click += ButtonAddCategories_Click;
        }
        
        private void ButtonAddCategories_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void AddOrUpdateCategoriesForm_Load(object sender, EventArgs e)
        {
            listBoxCategories.DataSource = context.Categories.Local.ToBindingList();
            cleanForm();
        }

        private void cleanForm()
        {
            listBoxCategories.SelectedIndex = -1;
            id = -1;

            textBoxName.ResetText();
            textBoxDescription.ResetText();
        }

    }
}
