using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam06BusinessMarketplaceForms
{
    public class FormUtils
    {
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
