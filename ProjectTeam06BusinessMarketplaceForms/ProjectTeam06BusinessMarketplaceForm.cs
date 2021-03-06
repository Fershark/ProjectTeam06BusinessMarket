﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessMarketplaceEntitiesNS;
using DataTableAccessLayer;

namespace ProjectTeam06BusinessMarketplaceForms
{
    public partial class ProjectTeam06BusinessMarketplaceForm : Form
    {
        private BusinessMarketplaceEntitiesContext context;

        public ProjectTeam06BusinessMarketplaceForm()
        {
            InitializeComponent();

            context = new BusinessMarketplaceEntitiesContext();
            context.Database.Log = s => Debug.Write(s);

            this.Load += ProjectTeam06BusinessMarketplaceForm_Load;

            this.FormClosed += (s, e) => context.Dispose();
        }

        /// <summary>
        /// Method to init the main form.
        /// It init each tab and load the entities.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectTeam06BusinessMarketplaceForm_Load(object sender, EventArgs e)
        {
            LoadEntities();

            InitAdminComponents();
            InitBusinessComponents();
        }

        /// <summary>
        /// Helper method to load all the entities
        /// </summary>
        private void LoadEntities()
        {
            context.Businesses.Load();
            context.Products.Load();
            context.Orders.Load();
            context.Categories.Load();
        }

        /// <summary>
        /// Helper method to clear local and remove and create the database again
        /// </summary>
        private void CleanDatabaseAndEntities()
        {
            //Clear all the records to prevent exceptions
            context.Categories.Local.Clear();
            context.Businesses.Local.Clear();
            context.Products.Local.Clear();
            context.Orders.Local.Clear();
            context.SaveChanges();

            context.Database.Delete();
            context.Database.Create();
            context.SaveChanges();
        }
    }
}
