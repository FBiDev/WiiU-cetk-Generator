using System.Drawing;
namespace WiiU_cetk_Generator
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle109 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle110 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle111 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle112 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxTitles = new System.Windows.Forms.GroupBox();
            this.gridViewTitles = new System.Windows.Forms.DataGridView();
            this.TitleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.txtSelectedTitle = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSelected = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.chkSrcTypeBlank = new System.Windows.Forms.CheckBox();
            this.lblSrcType = new System.Windows.Forms.Label();
            this.chklistType = new System.Windows.Forms.CheckedListBox();
            this.chkSrcRegionBlank = new System.Windows.Forms.CheckBox();
            this.lblSrcRegion = new System.Windows.Forms.Label();
            this.chkSrcJoinFields = new System.Windows.Forms.CheckBox();
            this.chklistRegion = new System.Windows.Forms.CheckedListBox();
            this.lblTotalFoundRows = new System.Windows.Forms.Label();
            this.chkSrcNameBlank = new System.Windows.Forms.CheckBox();
            this.txtSrcName = new System.Windows.Forms.TextBox();
            this.lblSrcName = new System.Windows.Forms.Label();
            this.lblSrcID = new System.Windows.Forms.Label();
            this.txtSrcID = new System.Windows.Forms.TextBox();
            this.groupBoxTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTitles)).BeginInit();
            this.groupBoxSelected.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxTitles
            // 
            this.groupBoxTitles.Controls.Add(this.gridViewTitles);
            resources.ApplyResources(this.groupBoxTitles, "groupBoxTitles");
            this.groupBoxTitles.Name = "groupBoxTitles";
            this.groupBoxTitles.TabStop = false;
            // 
            // gridViewTitles
            // 
            this.gridViewTitles.AllowUserToAddRows = false;
            this.gridViewTitles.AllowUserToDeleteRows = false;
            this.gridViewTitles.AllowUserToResizeRows = false;
            this.gridViewTitles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewTitles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTitles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleID,
            this.TitleKey,
            this.TitleName,
            this.TitleRegion,
            this.TitleType});
            resources.ApplyResources(this.gridViewTitles, "gridViewTitles");
            this.gridViewTitles.MultiSelect = false;
            this.gridViewTitles.Name = "gridViewTitles";
            this.gridViewTitles.ReadOnly = true;
            this.gridViewTitles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewTitles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTitles.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridViewTitles_RowsAdded);
            this.gridViewTitles.SelectionChanged += new System.EventHandler(this.gridViewTitles_SelectionChanged);
            // 
            // TitleID
            // 
            this.TitleID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle109.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleID.DefaultCellStyle = dataGridViewCellStyle109;
            resources.ApplyResources(this.TitleID, "TitleID");
            this.TitleID.Name = "TitleID";
            this.TitleID.ReadOnly = true;
            // 
            // TitleKey
            // 
            this.TitleKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle110.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleKey.DefaultCellStyle = dataGridViewCellStyle110;
            resources.ApplyResources(this.TitleKey, "TitleKey");
            this.TitleKey.Name = "TitleKey";
            this.TitleKey.ReadOnly = true;
            // 
            // TitleName
            // 
            this.TitleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.TitleName, "TitleName");
            this.TitleName.Name = "TitleName";
            this.TitleName.ReadOnly = true;
            // 
            // TitleRegion
            // 
            this.TitleRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle111.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle111.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TitleRegion.DefaultCellStyle = dataGridViewCellStyle111;
            resources.ApplyResources(this.TitleRegion, "TitleRegion");
            this.TitleRegion.Name = "TitleRegion";
            this.TitleRegion.ReadOnly = true;
            // 
            // TitleType
            // 
            this.TitleType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle112.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TitleType.DefaultCellStyle = dataGridViewCellStyle112;
            resources.ApplyResources(this.TitleType, "TitleType");
            this.TitleType.Name = "TitleType";
            this.TitleType.ReadOnly = true;
            // 
            // txtBox
            // 
            resources.ApplyResources(this.txtBox, "txtBox");
            this.txtBox.Name = "txtBox";
            // 
            // txtSelectedTitle
            // 
            this.txtSelectedTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelectedTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.txtSelectedTitle, "txtSelectedTitle");
            this.txtSelectedTitle.Name = "txtSelectedTitle";
            this.txtSelectedTitle.ReadOnly = true;
            this.txtSelectedTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSelectedTitle_MouseDown);
            // 
            // lblKey
            // 
            resources.ApplyResources(this.lblKey, "lblKey");
            this.lblKey.Name = "lblKey";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBoxSelected
            // 
            this.groupBoxSelected.Controls.Add(this.label4);
            this.groupBoxSelected.Controls.Add(this.txtBox);
            this.groupBoxSelected.Controls.Add(this.label3);
            this.groupBoxSelected.Controls.Add(this.button1);
            this.groupBoxSelected.Controls.Add(this.label2);
            this.groupBoxSelected.Controls.Add(this.txtSelectedTitle);
            this.groupBoxSelected.Controls.Add(this.label1);
            this.groupBoxSelected.Controls.Add(this.lblKey);
            resources.ApplyResources(this.groupBoxSelected, "groupBoxSelected");
            this.groupBoxSelected.Name = "groupBoxSelected";
            this.groupBoxSelected.TabStop = false;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.chkSrcTypeBlank);
            this.groupBoxSearch.Controls.Add(this.lblSrcType);
            this.groupBoxSearch.Controls.Add(this.chklistType);
            this.groupBoxSearch.Controls.Add(this.chkSrcRegionBlank);
            this.groupBoxSearch.Controls.Add(this.lblSrcRegion);
            this.groupBoxSearch.Controls.Add(this.chkSrcJoinFields);
            this.groupBoxSearch.Controls.Add(this.chklistRegion);
            this.groupBoxSearch.Controls.Add(this.lblTotalFoundRows);
            this.groupBoxSearch.Controls.Add(this.chkSrcNameBlank);
            this.groupBoxSearch.Controls.Add(this.txtSrcName);
            this.groupBoxSearch.Controls.Add(this.lblSrcName);
            this.groupBoxSearch.Controls.Add(this.lblSrcID);
            this.groupBoxSearch.Controls.Add(this.txtSrcID);
            resources.ApplyResources(this.groupBoxSearch, "groupBoxSearch");
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.TabStop = false;
            // 
            // chkSrcTypeBlank
            // 
            resources.ApplyResources(this.chkSrcTypeBlank, "chkSrcTypeBlank");
            this.chkSrcTypeBlank.Checked = true;
            this.chkSrcTypeBlank.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSrcTypeBlank.Name = "chkSrcTypeBlank";
            this.chkSrcTypeBlank.UseVisualStyleBackColor = true;
            this.chkSrcTypeBlank.CheckedChanged += new System.EventHandler(this.chkSrcTypeBlank_CheckedChanged);
            // 
            // lblSrcType
            // 
            resources.ApplyResources(this.lblSrcType, "lblSrcType");
            this.lblSrcType.Name = "lblSrcType";
            // 
            // chklistType
            // 
            this.chklistType.CheckOnClick = true;
            this.chklistType.FormattingEnabled = true;
            this.chklistType.Items.AddRange(new object[] {
            resources.GetString("chklistType.Items"),
            resources.GetString("chklistType.Items1"),
            resources.GetString("chklistType.Items2"),
            resources.GetString("chklistType.Items3"),
            resources.GetString("chklistType.Items4"),
            resources.GetString("chklistType.Items5")});
            resources.ApplyResources(this.chklistType, "chklistType");
            this.chklistType.Name = "chklistType";
            this.chklistType.ThreeDCheckBoxes = true;
            this.chklistType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklistType_ItemCheck);
            // 
            // chkSrcRegionBlank
            // 
            resources.ApplyResources(this.chkSrcRegionBlank, "chkSrcRegionBlank");
            this.chkSrcRegionBlank.Checked = true;
            this.chkSrcRegionBlank.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSrcRegionBlank.Name = "chkSrcRegionBlank";
            this.chkSrcRegionBlank.UseVisualStyleBackColor = true;
            this.chkSrcRegionBlank.CheckedChanged += new System.EventHandler(this.chkSrcRegionBlank_CheckedChanged);
            // 
            // lblSrcRegion
            // 
            resources.ApplyResources(this.lblSrcRegion, "lblSrcRegion");
            this.lblSrcRegion.Name = "lblSrcRegion";
            // 
            // chkSrcJoinFields
            // 
            resources.ApplyResources(this.chkSrcJoinFields, "chkSrcJoinFields");
            this.chkSrcJoinFields.Name = "chkSrcJoinFields";
            this.chkSrcJoinFields.UseVisualStyleBackColor = true;
            // 
            // chklistRegion
            // 
            this.chklistRegion.CheckOnClick = true;
            this.chklistRegion.FormattingEnabled = true;
            this.chklistRegion.Items.AddRange(new object[] {
            resources.GetString("chklistRegion.Items"),
            resources.GetString("chklistRegion.Items1"),
            resources.GetString("chklistRegion.Items2"),
            resources.GetString("chklistRegion.Items3")});
            resources.ApplyResources(this.chklistRegion, "chklistRegion");
            this.chklistRegion.Name = "chklistRegion";
            this.chklistRegion.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklistRegion_ItemCheck);
            // 
            // lblTotalFoundRows
            // 
            resources.ApplyResources(this.lblTotalFoundRows, "lblTotalFoundRows");
            this.lblTotalFoundRows.Name = "lblTotalFoundRows";
            // 
            // chkSrcNameBlank
            // 
            resources.ApplyResources(this.chkSrcNameBlank, "chkSrcNameBlank");
            this.chkSrcNameBlank.Checked = true;
            this.chkSrcNameBlank.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSrcNameBlank.Name = "chkSrcNameBlank";
            this.chkSrcNameBlank.UseVisualStyleBackColor = true;
            this.chkSrcNameBlank.CheckedChanged += new System.EventHandler(this.chkSrcNameBlank_CheckedChanged);
            // 
            // txtSrcName
            // 
            resources.ApplyResources(this.txtSrcName, "txtSrcName");
            this.txtSrcName.Name = "txtSrcName";
            this.txtSrcName.TextChanged += new System.EventHandler(this.txtSrcName_TextChanged);
            // 
            // lblSrcName
            // 
            resources.ApplyResources(this.lblSrcName, "lblSrcName");
            this.lblSrcName.Name = "lblSrcName";
            // 
            // lblSrcID
            // 
            resources.ApplyResources(this.lblSrcID, "lblSrcID");
            this.lblSrcID.Name = "lblSrcID";
            // 
            // txtSrcID
            // 
            resources.ApplyResources(this.txtSrcID, "txtSrcID");
            this.txtSrcID.Name = "txtSrcID";
            this.txtSrcID.TextChanged += new System.EventHandler(this.txtSrcID_TextChanged);
            // 
            // frmStart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxSelected);
            this.Controls.Add(this.groupBoxTitles);
            this.Name = "frmStart";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.groupBoxTitles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTitles)).EndInit();
            this.groupBoxSelected.ResumeLayout(false);
            this.groupBoxSelected.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxTitles;
        private System.Windows.Forms.DataGridView gridViewTitles;
        private System.Windows.Forms.TextBox txtSelectedTitle;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleType;
        private System.Windows.Forms.GroupBox groupBoxSelected;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtSrcName;
        private System.Windows.Forms.Label lblSrcName;
        private System.Windows.Forms.Label lblSrcID;
        private System.Windows.Forms.TextBox txtSrcID;
        private System.Windows.Forms.CheckBox chkSrcNameBlank;
        private System.Windows.Forms.Label lblTotalFoundRows;
        private System.Windows.Forms.CheckedListBox chklistRegion;
        private System.Windows.Forms.CheckBox chkSrcJoinFields;
        private System.Windows.Forms.Label lblSrcRegion;
        private System.Windows.Forms.CheckBox chkSrcRegionBlank;
        private System.Windows.Forms.CheckBox chkSrcTypeBlank;
        private System.Windows.Forms.Label lblSrcType;
        private System.Windows.Forms.CheckedListBox chklistType;
    }
}

