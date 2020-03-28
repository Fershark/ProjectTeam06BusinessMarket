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
using BusinessMarketplaceEntities;

namespace ProjectTeam06BusinessMarketplaceForms
{
    public partial class ProjectTeam06BusinessMarketplaceForm : Form
    {
        private BusinessMarketplaceEntities.BusinessMarketplaceEntities context;

        public ProjectTeam06BusinessMarketplaceForm()
        {
            InitializeComponent();

            context = new BusinessMarketplaceEntities.BusinessMarketplaceEntities();

            this.Load += ProjectTeam06BusinessMarketplaceForm_Load;

            this.FormClosed += (s, e) => context.Dispose();
        }

        private void ProjectTeam06BusinessMarketplaceForm_Load(object sender, EventArgs e)
        {
            SeedBusinessMarketplaceDataTables();
        }

        private void SeedBusinessMarketplaceDataTables() 
        {
            context.Database.Log = s => Debug.Write(s);
            
            context.Database.Delete();
            context.Database.Create();

            context.SaveChanges();

            context.Businesses.Load();
            context.Products.Load();
            context.Orders.Load();
            context.Categories.Load();

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

            /*List<Product> products = new List<Product>()
            {
                new Product {Name = "Continuous Sushi Roll Machine", Description = "Creates delicious Norimaki with a fluffly rice sheet", QuantityInStock = 10, Price = (decimal) 1001, Category = categories[0], Business = businesses[1] }
            };
            context.Products.AddRange(products);
            context.SaveChanges();*/

            /*List<Order> orders = new List<Order>()
            {
                new Order {OrderDate = DateTime.Now, TotalPrice = 2002, Business = businesses[2]}
            };
            orders[0].Products.Add(products[0]);
            context.Orders.AddRange(orders);
            context.SaveChanges();
            
            List<Order> orders = new List<Order>()
            {
                new Order {OrderDate = DateTime.Now, TotalPrice = 2002, Business = businesses[2]}
            };
            orders[0].Products.Add(products[0]);
            context.Orders.AddRange(orders);
            context.SaveChanges();
             */
        }
    }
}
