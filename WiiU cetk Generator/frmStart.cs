using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.VisualBasic.FileIO;
using WiiU_cetk_Generator.Properties;

namespace WiiU_cetk_Generator
{
    public partial class frmStart : Form
    {
        public List<DataGridViewRow> lstGridRows = new List<DataGridViewRow>();
        public List<DataGridViewRow> lstGridRowsSearch = new List<DataGridViewRow>();
        private bool formLoaded = false;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public void addRowsToList(List<DataGridViewRow> lstRows)
        {
            lstRows.Clear();

            foreach (DataGridViewRow dr in gridViewTitles.Rows)
            {
                DataGridViewRow rown = (DataGridViewRow)gridViewTitles.RowTemplate.Clone();
                rown.CreateCells(gridViewTitles, dr.Cells[0].Value, dr.Cells[1].Value, dr.Cells[2].Value, dr.Cells[3].Value, dr.Cells[4].Value);

                lstRows.Add(rown);
            }
        }

        private void CheckListSetItems(CheckedListBox chklist, bool value) 
        {
            for (int i = 0; i < chklist.Items.Count; i++)
            {
                chklist.SetItemChecked(i, value);
            }
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            this.formLoaded = true;
        }

        public frmStart()
        {
            InitializeComponent();



            CheckListSetItems(chklistRegion, true);
            CheckListSetItems(chklistType, true);

            ReadCSVEmbedded("WiiUCSV.csv");
            addRowsToList(lstGridRows);
        }





        private void ReadCSVEmbedded(string filename)
        {
            var myType = typeof(frmStart);
            filename = myType.Namespace + "." + filename;

            var thisAssembly = Assembly.GetExecutingAssembly();
            using (var stream = thisAssembly.GetManifestResourceStream(filename))
            {
                TextFieldParser tfp = new TextFieldParser(stream);

                string delimiters = ",";
                string extension = Path.GetExtension(filename);

                if (extension.ToLower() == "txt")
                    delimiters = "\t";
                else if (extension.ToLower() == "csv")
                    delimiters = ",";
                delimiters = ";";

                tfp.SetDelimiters(delimiters);

                // Get Remaining Rows from the CSV
                while (!tfp.EndOfData)
                {
                    string[] row = tfp.ReadFields();
                    gridViewTitles.Rows.Add(row);
                }
            }
        }

        public void generate()
        {
            if (gridViewTitles.SelectedRows.Count > 0 && gridViewTitles.SelectedRows[0].Cells[1].Value != null)
            {
                string byteString = "00 01 00 04 D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A D1 5E A5 ED 15 AB E1 1A 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 52 6F 6F 74 2D 43 41 30 30 30 30 30 30 30 33 2D 58 53 30 30 30 30 30 30 30 63 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE FE ED FA CE 01 00 00 D2 03 95 E4 04 28 03 6C 39 78 A4 6F B1 4D C3 B2 00 00 00 00 00 00 00 00 00 00 00 00 00 00 05 00 00 10 1B B2 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 14 00 00 00 AC 00 00 00 14 00 01 00 14 00 00 00 00 00 00 00 28 00 00 00 01 00 00 00 84 00 00 00 84 00 03 00 00 00 00 00 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
                txtBox.Text = byteString;
                byteString = byteString.Replace(" ", "");

                string oldkey = "D2 03 95 E4 04 28 03 6C 39 78 A4 6F B1 4D C3 B2";
                oldkey = oldkey.Replace(" ", "");

                string newkey = "32EFA28EDF2ADF16990A175263BA84DB";
                newkey = gridViewTitles.SelectedRows[0].Cells[1].Value.ToString().ToUpper();

                string byteStringNew = byteString.Replace(oldkey, newkey);

                File.WriteAllBytes("cetk", StringToByteArray(byteStringNew));
            }
        }

        public byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void gridViewTitles_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewTitles.SelectedRows.Count > 0 && gridViewTitles.SelectedRows[0].Cells[1].Value != null)
            {
                txtSelectedTitle.Text = gridViewTitles.SelectedRows[0].Cells[1].Value.ToString().ToUpper();
            }
            else
            {
                txtSelectedTitle.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generate();
        }

        private void txtSrcID_TextChanged(object sender, EventArgs e)
        {
            searchInGridView(gridViewTitles, 0, TitleColumn.ID);
        }

        private void txtSrcName_TextChanged(object sender, EventArgs e)
        {
            searchInGridView(gridViewTitles, 2, TitleColumn.Name);
        }

        private void searchInGridView(DataGridView gridview, int cellIndex, TitleColumn column)
        {
            lstGridRowsSearch.Clear();

            foreach (DataGridViewRow cRow in lstGridRows)
            {
                //if (cellValue.Equals(searchString))
                //{
                //cRow.Visible = false;
                //cRow.Selected = true;
                //gridViewTitles.FirstDisplayedScrollingRowIndex = gridViewTitles.SelectedRows[0].Index;
                //break;
                //}

                string cellValue = cRow.Cells[cellIndex].Value.ToString().Trim();
                bool rowFound = false;

                if (chkSrcJoinFields.Checked)
                {
                    cellValue = cRow.Cells[0].Value.ToString().Trim();
                    bool id = searchInGridViewTextBox(cRow, txtSrcID, cellValue);

                    cellValue = cRow.Cells[2].Value.ToString().Trim();
                    bool name = searchInGridViewTextBox(cRow, txtSrcName, cellValue, chkSrcNameBlank);

                    cellValue = cRow.Cells[3].Value.ToString().Trim();
                    bool region = searchInGridViewCheckedListBox(cRow, chklistRegion, cellValue, chkSrcRegionBlank);

                    cellValue = cRow.Cells[4].Value.ToString().Trim();
                    bool type = searchInGridViewCheckedListBox(cRow, chklistType, cellValue, chkSrcTypeBlank);

                    rowFound = (id && name && region && type);
                }
                else
                {
                    switch (column)
                    {
                        case TitleColumn.ID:
                            rowFound = searchInGridViewTextBox(cRow, txtSrcID, cellValue);
                            break;
                        case TitleColumn.Key:
                            break;
                        case TitleColumn.Name:
                            rowFound = searchInGridViewTextBox(cRow, txtSrcName, cellValue, chkSrcNameBlank);
                            break;
                        case TitleColumn.Region:
                            rowFound = searchInGridViewCheckedListBox(cRow, chklistRegion, cellValue, chkSrcRegionBlank);
                            break;
                        case TitleColumn.Type:
                            rowFound = searchInGridViewCheckedListBox(cRow, chklistType, cellValue, chkSrcTypeBlank);
                            break;
                    }
                }

                if (rowFound)
                {
                    lstGridRowsSearch.Add(cRow);
                }
            }

            gridview.Rows.Clear();
            gridview.Rows.InsertRange(0, lstGridRowsSearch.ToArray());
        }

        private bool searchInGridViewTextBox(DataGridViewRow cRow, TextBox txtBox, string cellValue, CheckBox chkBox = null)
        {
            string searchString = string.Empty;
            int indexFound = -1;

            searchString = txtBox.Text;
            indexFound = cellValue.IndexOf(searchString, StringComparison.CurrentCultureIgnoreCase);

            if (cellValue == string.Empty && chkBox != null && chkBox.Checked)
            {
                return true;
            }
            else if (indexFound > -1)
            {
                return true;
            }
            return false;
        }

        private bool searchInGridViewCheckedListBox(DataGridViewRow cRow, CheckedListBox chkList, string cellValue, CheckBox chkBox = null)
        {
            string searchString = string.Empty;
            int indexFound = -1;

            if (cellValue == string.Empty && chkBox != null && chkBox.Checked)
            {
                return true;
            }

            if (chkList.CheckedItems.Count > 0)
            {
                for (int i = 0; i < chkList.CheckedItems.Count; i++)
                {
                    searchString = chkList.CheckedItems[i].ToString();

                    indexFound = cellValue.IndexOf(searchString, StringComparison.CurrentCultureIgnoreCase);
                    if (indexFound > -1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void gridViewTitles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalFoundRows.Text = "Total Rows Found: " + gridViewTitles.Rows.Count;
        }

        private void chkSrcNameBlank_CheckedChanged(object sender, EventArgs e)
        {
            searchInGridView(gridViewTitles, 2, TitleColumn.Name);
        }

        private void chkSrcRegionBlank_CheckedChanged(object sender, EventArgs e)
        {
            searchInGridView(gridViewTitles, 3, TitleColumn.Region);
        }

        private void chkSrcTypeBlank_CheckedChanged(object sender, EventArgs e)
        {
            searchInGridView(gridViewTitles, 4, TitleColumn.Type);
        }

        private void chklistRegion_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (this.formLoaded)
            {
                this.BeginInvoke((MethodInvoker)(() =>
                    searchInGridView(gridViewTitles, 3, TitleColumn.Region)
                ));
            }
        }

        private void chklistType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (this.formLoaded)
            {
                this.BeginInvoke((MethodInvoker)(() =>
                    searchInGridView(gridViewTitles, 4, TitleColumn.Type)
                ));
            }
        }

        private void txtSelectedTitle_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(txtSelectedTitle.Handle);
            txtSelectedTitle.SelectionStart = 0;
            txtSelectedTitle.SelectionLength = txtSelectedTitle.Text.Length;
        }
    }

    enum TitleColumn
    {
        ID = 0,
        Key,
        Name,
        Region,
        Type
    }
}
