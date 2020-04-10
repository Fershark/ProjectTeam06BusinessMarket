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
        private void InitAdminComponents()
        {
            InitalizeDataGridView<Business>(dataGridViewBussinessName, context.Businesses.Local.ToBindingList(), "Orders", "Products");
            InitalizeDataGridView<Category>(dataGridViewCategories, context.Categories.Local.ToBindingList(), "Products");

            buttonAddUpdateBusinesses.Click += ButtonAddUpdateBusinessName_Click;
            buttonAddUpdateCategories.Click += ButtonAddUpdateCategories_Click;
            buttonDeleteAndSeedDatabase.Click += ButtonDeleteAndSeedDatabase_Click;
            buttonBackupDatabase.Click += ButtonBackupDatabase_Click;
            buttonRestoreDatabase.Click += ButtonRestoreDatabase_Click;
        }

        private void ButtonAddUpdateBusinessName_Click(object sender, EventArgs e)
        {
            AddOrUpdateBusinessNameForm addOrUpdateBusinessNameForm = new AddOrUpdateBusinessNameForm(context);
            addOrUpdateBusinessNameForm.ShowDialog();
            dataGridViewBussinessName.Refresh();
        }

        private void ButtonAddUpdateCategories_Click(object sender, EventArgs e)
        {
            AddOrUpdateCategoriesForm addOrUpdateDepartmentForm = new AddOrUpdateCategoriesForm(context);
            addOrUpdateDepartmentForm.ShowDialog();
            dataGridViewCategories.Refresh();
        }

        private void ButtonDeleteAndSeedDatabase_Click(object sender, EventArgs e)
        {
            CleanDatabaseAndEntities();
            LoadEntities();

            List<Category> categories = new List<Category>()
            {
                new Category {Name = "Machinery", Description = "Description"},
                new Category {Name = "Electronics", Description = "Description"},
                new Category {Name = "Vehicles", Description = "Description"},
                new Category {Name = "Textiles", Description = "Description"},
                new Category {Name = "Furniture", Description = "Description"},
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();

            List<Business> businesses = new List<Business>()
            {
                new Business {Name = "Admin", Address = "Admin", Email = "admin@businessmarketplace.com", IsAdmin = true},
                new Business {Name = "SUSUMO MACHINEY COMPANY LIMITED", Address = "1560 Booth Ave, Coquitlam,BC", Email = "contact@suzumo.com", IsAdmin = false},
                new Business {Name = "MVP Electronics", Address = "807 Carnarvon St, New Westminster, BC", Email = "contact@mvpelectronics.com", IsAdmin = false}
            };
            context.Businesses.AddRange(businesses);
            context.SaveChanges();

            List<Product> products = new List<Product>()
            {
                new Product {Name = "Continuous Sushi Roll Machine", Description = "Creates delicious Norimaki with a fluffly rice sheet", QuantityInStock = 10, Price = (decimal) 1001, Category = categories[0], Business = businesses[1] }

            };
            context.Products.AddRange(products);
            context.SaveChanges();

            List<Order> orders = new List<Order>()
            {
                new Order {OrderDate = DateTime.Now, TotalPrice = 2002, Business = businesses[2]}
            };
            orders[0].Products.Add(products[0]);
            context.Orders.AddRange(orders);
            context.SaveChanges();

            MessageBox.Show("Database seeded correctly.");
        }

        private void ButtonBackupDatabase_Click(object sender, EventArgs e)
        {
            // opening the save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                // we start up in the debug directory, go two levels up to get to the main project area
                // note need to use Path.GetFullPath() as InitialDirectory does not like relative directories
                InitialDirectory = Path.GetFullPath(Application.StartupPath + "\\..\\.."),
                Filter = "XML files (*.xml)|*.xml",
                Title = "Save the backup",
                FileName = "BusinessMarketplaceBackup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm")
            };

            //Passing "this" to show dialog, so the main form can be 
            //focused after the dialog is hidden
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK && saveFileDialog.FileName != "")
            {
                BusinessMarketplaceDataAccessLayer businessMarketplaceDataAccessLayer = new BusinessMarketplaceDataAccessLayer();
                string connectionString = businessMarketplaceDataAccessLayer.GetConnectionString("BusinessMarketplaceSqlProvider");
                businessMarketplaceDataAccessLayer.OpenConnection(connectionString);
                DataSet businessMarketplaceDataSet = businessMarketplaceDataAccessLayer.InitDataSet();
                var result = false;
                var message = "There was an error saving the backup.";
                try
                {
                    result = businessMarketplaceDataAccessLayer.BackupDataSetToXML(businessMarketplaceDataSet, saveFileDialog.FileName);
                }
                catch (Exception exception)
                {
                    Debug.Print(exception.StackTrace);
                }
                businessMarketplaceDataAccessLayer.CloseConnection();


                if (result)
                {
                    message = "Backup successfully saved.";
                }
                MessageBox.Show(message);
            }
        }

        private void ButtonRestoreDatabase_Click(object sender, EventArgs e)
        {
            // opening the file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // we start up in the debug directory, go two levels up to get to the main project area
                // note need to use Path.GetFullPath() as InitialDirectory does not like relative directories
                InitialDirectory = Path.GetFullPath(Application.StartupPath + "\\..\\.."),
                Filter = "XML files (*.xml)|*.xml",
                Title = "Restore the backup"
            };

            //Passing "this" to show dialog, so the main form can be 
            //focused after the dialog is hidden
            if (openFileDialog.ShowDialog(this) == DialogResult.OK && openFileDialog.FileName != "")
            {
                CleanDatabaseAndEntities();
                BusinessMarketplaceDataAccessLayer businessMarketplaceDataAccessLayer = new BusinessMarketplaceDataAccessLayer();
                string connectionString = businessMarketplaceDataAccessLayer.GetConnectionString("BusinessMarketplaceSqlProvider");
                businessMarketplaceDataAccessLayer.OpenConnection(connectionString);
                DataSet businessMarketplaceDataSet = businessMarketplaceDataAccessLayer.InitDataSet();
                var result = false;
                var message = "There was an error loading the backup.";
                try
                {
                    result = businessMarketplaceDataAccessLayer.RestoreDataSetFromBackup(businessMarketplaceDataSet, openFileDialog.FileName);
                }
                catch (Exception exception)
                {
                    Debug.Print(exception.StackTrace);
                }
                businessMarketplaceDataAccessLayer.CloseConnection();
                LoadEntities();

                if (result)
                {
                    message = "Backup successfully loaded.";
                }
                MessageBox.Show(message);
            }
        }
    }
}
