using System.Linq;
using System.Data;
using Microsoft.VisualBasic.FileIO; // This namespace usage is important or else TextFieldParser method will lead to error
using System.IO;
using System.Text;
using System;
using System.Windows.Forms;

namespace WiiU_cetk_Generator
{
    public class ReadCSV
    {
        public DataTable readCSV;

        public ReadCSV(string fileName, DataGridView grid, bool firstRowContainsFieldNames = false)
        {
            readCSV = GenerateDataTable(fileName, grid, firstRowContainsFieldNames);
        }

        private static DataTable GenerateDataTable(string fileName, DataGridView grid, bool firstRowContainsFieldNames = false)
        {
            DataTable result = new DataTable();

            if (fileName == "")
            {
                return result;
            }


            string delimiters = ",";
            string extension = Path.GetExtension(fileName);

            if (extension.ToLower() == "txt")
                delimiters = "\t";
            else if (extension.ToLower() == "csv")
                delimiters = ",";
            delimiters = ";";

            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(delimiters);

                // Get The Column Names
                if (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                        {
                            result.Columns.Add(fields[i]);
                        }
                        else
                        {
                            result.Columns.Add("Col" + i);
                        }
                    }

                    // If first line is data then add it
                    if (!firstRowContainsFieldNames)
                    {
                        result.Rows.Add(fields);
                    }
                }

                // Get Remaining Rows from the CSV
                while (!tfp.EndOfData)
                {
                    string[] row = tfp.ReadFields();
                    //result.Rows.Add(row);

                    grid.Rows.Add(row);
                }
            }
            return result;
        }
    }
}
