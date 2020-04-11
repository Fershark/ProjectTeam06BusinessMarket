using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableAccessLayer
{
    public class BusinessMarketplaceDataAccessLayer : SqlDataTableAccessLayer
    {
        /// <summary>
        /// static method for initializing the data set and adding the tables
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet InitDataSet()
        {
            DataSet businessMarketplaceDataSet = new DataSet()
            {
                DataSetName = "BusinessMarketplaceDataSet",
            };

            businessMarketplaceDataSet.Tables.Add(GetDataTable("Businesses"));
            businessMarketplaceDataSet.Tables.Add(GetDataTable("Categories"));
            businessMarketplaceDataSet.Tables.Add(GetDataTable("Products"));
            businessMarketplaceDataSet.Tables.Add(GetDataTable("Orders"));
            businessMarketplaceDataSet.Tables.Add(GetDataTable("OrderProducts"));

            return businessMarketplaceDataSet;
        }

        /// <summary>
        /// Method to save the backup with custom name. It will be use with a dialog.
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="fileName"></param>
        public bool BackupDataSetToXML(DataSet dataSet, String fileName)
        {
            if (dataSet == null)
            {
                Debug.WriteLine("BackupDataSetToXML: Error - null dataset");
                return false;
            }

            // writes the DataSet to an xml file including the schema
            Debug.WriteLine("BackupDataSetToXML: backing up to " + dataSet.DataSetName);

            dataSet.WriteXml(fileName, XmlWriteMode.WriteSchema);

            return true;
        }

        /// <summary>
		/// Restore the DataSet from an xml file. The xml file must
		/// include a schema, and should have been written using
		/// <see cref="BackupDataSetToXML(DataSet, string)"/>
		/// 
		/// File is named using the 
		/// <see cref="DataSet.DataSetName"/> with .xml appended
		/// 
		/// DataSet tables must not be associated with views.
        /// 
        /// You need to clear the database before calling this method.
        /// It is recommended to use this method with open file dialog.
        /// 
        /// It iterates through the dataSet and insert row by row for each table.
		/// </summary>
		/// <param name="dataSet">DataSet to be restored</param>
		public bool RestoreDataSetFromBackup(DataSet dataSet, String fileName)
        {
            if (dataSet == null)
            {
                Debug.WriteLine("RestoreDataSetFromBackup: Error - null dataset");
                return false;
            }

            Debug.WriteLine("RestoreDataSetFromBackup: restoring from " + dataSet.DataSetName);

            restoringFromBackup = true;
            // Read the data from the file and add it to the dataset
            dataSet.ReadXml(fileName, XmlReadMode.ReadSchema);
            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    InsertTableRow(row);
                }
            }
            restoringFromBackup = false;

            // restore completed
            return true;
        }
    }
}
