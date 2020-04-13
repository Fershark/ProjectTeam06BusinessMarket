using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam06BusinessMarketplaceForms
{
    /// <summary>
    /// Class with static methods to be reused in all forms
    /// </summary>
    public class FormUtils
    {
        /// <summary>
        /// Method for initializing a data grid view with a data source. You can configure if you want multiple selection or not 
        /// and if you want to ignore some columns
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="bindingList"></param>
        /// <param name="multipleSelection"></param>
        /// <param name="columnsToIgnore"></param>
        public static void InitalizeDataGridView(DataGridView dataGridView, object bindingList, bool multipleSelection = true, params string[] columnsToIgnore)
        {
            dataGridView.DataSource = bindingList;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            //dataGridView.RowHeadersVisible = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // autosize the row heights, but only those displayed to improve performance
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            //We declare the font here to have consistance with the font in the data grid views because the group box sometimes changed the font
            var font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F, FontStyle.Regular);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = font;
            dataGridView.DefaultCellStyle.Font = font;
            dataGridView.MultiSelect = multipleSelection;

            foreach (var columnToIgnore in columnsToIgnore)
            {
                dataGridView.Columns[columnToIgnore].Visible = false;
            }
        }
    }
}
