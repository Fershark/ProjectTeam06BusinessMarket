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
    /// Partial class to keep all the functionality of the admin in one file
    /// </summary>
    public partial class ProjectTeam06BusinessMarketplaceForm
    {
        /// <summary>
        /// Method to init the components in the admin tab
        /// </summary>
        private void InitAdminComponents()
        {
            FormUtils.InitalizeDataGridView(dataGridViewBussinessName, context.Businesses.Local.ToBindingList(), false, "Orders", "Products");
            FormUtils.InitalizeDataGridView(dataGridViewCategories, context.Categories.Local.ToBindingList(), false, "Products");

            buttonAddUpdateBusinesses.Click += ButtonAddUpdateBusinessName_Click;
            buttonAddUpdateCategories.Click += ButtonAddUpdateCategories_Click;
            buttonSalesAdmin.Click += ButtonSalesAdmin_Click;
            buttonDeleteAndSeedDatabase.Click += ButtonDeleteAndSeedDatabase_Click;
            buttonBackupDatabase.Click += ButtonBackupDatabase_Click;
            buttonRestoreDatabase.Click += ButtonRestoreDatabase_Click;
        }

        /// <summary>
        /// Method to open the form for updating or adding a business
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddUpdateBusinessName_Click(object sender, EventArgs e)
        {
            AddOrUpdateBusinessNameForm addOrUpdateBusinessNameForm = new AddOrUpdateBusinessNameForm(context);
            addOrUpdateBusinessNameForm.ShowDialog();
            dataGridViewBussinessName.Refresh();

            //For Business correct load in business tab
            SetBusinessComboBox();
        }

        /// <summary>
        /// Method to open the form for updating or adding a category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddUpdateCategories_Click(object sender, EventArgs e)
        {
            AddOrUpdateCategoriesForm addOrUpdateDepartmentForm = new AddOrUpdateCategoriesForm(context);
            addOrUpdateDepartmentForm.ShowDialog();
            dataGridViewCategories.Refresh();
        }

        /// <summary>
        /// Method to open the form to see the sales of all business' products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSalesAdmin_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm(context);
            salesForm.ShowDialog();
        }

        /// <summary>
        /// Seed data to initialize the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteAndSeedDatabase_Click(object sender, EventArgs e)
        {
            CleanDatabaseAndEntities();
            LoadEntities();

            List<Category> categories = new List<Category>()
            {
                new Category {Name = "Machinery", Description = "Factory machines or factory machine parts"},
                new Category {Name = "Electronics", Description = "Circuits or electronic components"},
                new Category {Name = "Vehicles", Description = "Vehicles or vehicle parts"},
                new Category {Name = "Textiles", Description = "Cloths or machines to make cloths"},
                new Category {Name = "Furniture", Description = "Business or factories movable articles"},
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();

            List<Business> businesses = new List<Business>()
            {
                new Business {Name = "Admin", Address = "Admin", Email = "admin@businessmarketplace.com", IsAdmin = true},
                new Business {Name = "KRONES Machinery Co. Limited", Address = "108-6285 Northam Dr, Mississauga, ON, L4V 1X5, Canada", Email = "info@krones.ca", IsAdmin = false},
                new Business {Name = "Ecolab Canada", Address = "5105 Tomken Road, Mississauga, ON, Canada L4W 2X5", Email = "info@ecolab.com", IsAdmin = false},
                new Business {Name = "Cintas Canada", Address = "6741 Cariboo Road Unit 307Burnaby, BC V3N 4A3", Email = "info@cintas.ca", IsAdmin = false},
                new Business {Name = "Traffic Tech Canada", Address = "1J9, 200-4595 Canada Way, Burnaby, BC V5G 4L6", Email = "info@traffictech.ca", IsAdmin = false},
            };
            context.Businesses.AddRange(businesses);
            context.SaveChanges();

            Dictionary<string, Category> categoriesDictionary = categories.ToDictionary(x => x.Name, x => x);
            Dictionary<string, Business> businessesDictionary = businesses.ToDictionary(x => x.Name, x => x);
            List<Product> products = new List<Product>()
            {
                new Product {Name = "VarioStore tank", Description = "Maximised product safety and product quality", QuantityInStock = 10, Price = (decimal) 100000, Category = categoriesDictionary["Machinery"], Business = businessesDictionary["KRONES Machinery Co. Limited"] },
                new Product {Name = "Krones FlexiFruit", Description = "Filling with the twin-flow method. Treats juice and fruit pieces separately", QuantityInStock = 10, Price = (decimal) 1200000, Category = categoriesDictionary["Machinery"], Business = businessesDictionary["KRONES Machinery Co. Limited"] },
                new Product {Name = "Krones VarioFlash J", Description = "Thermal product treatment for the best juice quality", QuantityInStock = 10, Price = (decimal) 1100000, Category = categoriesDictionary["Machinery"], Business = businessesDictionary["KRONES Machinery Co. Limited"] },
                new Product {Name = "Steinecker CombiCube", Description = "Modular brewing systems can be perfectly configured to meet the needs of craft brewers", QuantityInStock = 10, Price = (decimal) 2500000, Category = categoriesDictionary["Machinery"], Business = businessesDictionary["KRONES Machinery Co. Limited"] },
                new Product {Name = "Krones Cantronic", Description = "Quality control for beverage cans", QuantityInStock = 10, Price = (decimal) 1200000, Category = categoriesDictionary["Machinery"], Business = businessesDictionary["KRONES Machinery Co. Limited"] },
                new Product {Name = "HVAC AIR FILTRATION(Monthly)", Description = "Monitoring Filter Life and Performance", QuantityInStock = 10, Price = (decimal) 5000, Category = categoriesDictionary["Machinery"], Business = businessesDictionary["Ecolab Canada"] },
                new Product {Name = "RO EQUIPMENT AND SOLUTIONS(Monthly)", Description = "Reverse Osmosis Components and Systems", QuantityInStock = 10, Price = (decimal) 3000, Category = categoriesDictionary["Machinery"], Business = businessesDictionary["Ecolab Canada"] },
                new Product {Name = "BOILER WATER TREATMENT(Monthly)", Description = "Comprehensive boiler water treatment solution mitigating scale and corrosion of the boiler system", QuantityInStock = 10, Price = (decimal) 1000, Category = categoriesDictionary["Machinery"], Business = businessesDictionary["Ecolab Canada"] },
                new Product {Name = "AUTOMATION, MONITORING & CONTROL(Monthly)", Description = "Monitoring and control solutions will help you leverage technology to improve reliability, cost - effectiveness and help you meet your business goals", QuantityInStock = 10, Price = (decimal) 2000, Category = categoriesDictionary["Machinery"], Business = businessesDictionary["Ecolab Canada"] },
                new Product {Name = "Carhartt® workwear(200 sets)", Description = "Ultimate clothing for these conditions", QuantityInStock = 10, Price = (decimal) 100000, Category = categoriesDictionary["Textiles"], Business = businessesDictionary["Cintas Canada"] },
                new Product {Name = "Ready for the Workday® (200 sets)", Description = "UTILITY UNIFORMS", QuantityInStock = 10, Price = (decimal) 70000, Category = categoriesDictionary["Textiles"], Business = businessesDictionary["Cintas Canada"] },
                new Product {Name = "AUTOMOTIVE & MECHANIC UNIFORMS(200 sets)", Description = "Our extensive product line provides the right uniform for employees", QuantityInStock = 10, Price = (decimal) 80000, Category = categoriesDictionary["Textiles"], Business = businessesDictionary["Cintas Canada"] }
            };
            context.Products.AddRange(products);
            context.SaveChanges();

            List<Order> orders = new List<Order>()
            {
                new Order {OrderDate = DateTime.Now, TotalPrice = 75000, Business = businessesDictionary["KRONES Machinery Co. Limited"]},
                new Order {OrderDate = DateTime.Now.AddDays(-1), TotalPrice = 75000, Business = businessesDictionary["KRONES Machinery Co. Limited"]}
            };
            orders[0].Products.Add(products[5]);
            orders[0].Products.Add(products[10]);
            orders[1].Products.Add(products[5]);
            orders[1].Products.Add(products[10]);
            context.Orders.AddRange(orders);
            products[5].QuantityInStock -= 2;
            products[10].QuantityInStock -= 2;
            context.SaveChanges();

            //For Business correct load in business tab
            SetBusinessComboBox();

            MessageBox.Show("Database seeded correctly.");
        }

        /// <summary>
        /// Method to backup the database.
        /// We use the ADO connection to backup and restore the database.
        /// It opens a save file dialog to choose where to save the backup,
        /// it also suggest to use a timestamp with the database name to save the backup.
        /// The timestamp uses dashes for the time, since using colons in the name of a file
        /// is forbidden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method to restore the database.
        /// It opens a open file dialog to choose from where to load the backup.
        /// We use the ADO connection to backup and restore the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                //For Business correct load in business tab
                SetBusinessComboBox();

                if (result)
                {
                    message = "Backup successfully loaded.";
                }
                MessageBox.Show(message);
            }
        }
    }
}
