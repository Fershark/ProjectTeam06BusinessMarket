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
        public void InitBusinessComponents()
        {
            InitalizeDataGridView<Product>(dataGridViewBusinessProduct, context.Products.Local.ToBindingList());
            InitalizeDataGridView<Order>(dataGridViewOrder, context.Orders.Local.ToBindingList());

            buttonAddUpdateProduct.Click += ButtonAddUpdateProduct_Click;
        }

        private void ButtonAddUpdateProduct_Click(object sender, EventArgs e)
        {
            AddOrUpdateBusinessProductForm addOrUpdateBusinessProductForm = new AddOrUpdateBusinessProductForm(context);
            addOrUpdateBusinessProductForm.ShowDialog();
            dataGridViewBusinessProduct.Refresh();
        }
    }
}
