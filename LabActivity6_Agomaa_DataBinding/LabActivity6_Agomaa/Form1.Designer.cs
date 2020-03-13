namespace LabActivity6_Agomaa
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new LabActivity6_Agomaa.studentsDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStrip = new System.Windows.Forms.ToolStrip();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bSCSToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSCSToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bSITToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSITToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tblStudent_InfoTableAdapter = new LabActivity6_Agomaa.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            this._2ND_YEAR3ToolStrip = new System.Windows.Forms.ToolStrip();
            this._2ND_YEAR3ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aDDRESS_BALANGA1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.aDDRESS_BALANGA1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sECTION_2BToolStrip = new System.Windows.Forms.ToolStrip();
            this.sECTION_2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lASTNAME_A_AND_C1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.lASTNAME_A_AND_C1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fIRSTNAME_CONSONANTToolStrip = new System.Windows.Forms.ToolStrip();
            this.fIRSTNAME_CONSONANTToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.refreshToolStrip.SuspendLayout();
            this.bSCSToolStrip.SuspendLayout();
            this.bSITToolStrip.SuspendLayout();
            this._2ND_YEAR3ToolStrip.SuspendLayout();
            this.aDDRESS_BALANGA1ToolStrip.SuspendLayout();
            this.sECTION_2BToolStrip.SuspendLayout();
            this.lASTNAME_A_AND_C1ToolStrip.SuspendLayout();
            this.fIRSTNAME_CONSONANTToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(939, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // studIDDataGridViewTextBoxColumn
            // 
            this.studIDDataGridViewTextBoxColumn.DataPropertyName = "StudID";
            this.studIDDataGridViewTextBoxColumn.HeaderText = "StudID";
            this.studIDDataGridViewTextBoxColumn.Name = "studIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // yearLevelDataGridViewTextBoxColumn
            // 
            this.yearLevelDataGridViewTextBoxColumn.DataPropertyName = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.HeaderText = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.Name = "yearLevelDataGridViewTextBoxColumn";
            // 
            // tblStudentInfoBindingSource
            // 
            this.tblStudentInfoBindingSource.DataMember = "tblStudent_Info";
            this.tblStudentInfoBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Gray;
            this.bindingNavigator1.BindingSource = this.tblStudentInfoBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(233, 226);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(451, 36);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 36);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // refreshToolStrip
            // 
            this.refreshToolStrip.AutoSize = false;
            this.refreshToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refreshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.refreshToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.refreshToolStrip.Location = new System.Drawing.Point(765, 226);
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.Size = new System.Drawing.Size(186, 54);
            this.refreshToolStrip.TabIndex = 3;
            this.refreshToolStrip.Text = "refreshToolStrip";
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.AutoSize = false;
            this.refreshToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripButton.ForeColor = System.Drawing.Color.White;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(50, 67);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // bSCSToolStrip
            // 
            this.bSCSToolStrip.AutoSize = false;
            this.bSCSToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bSCSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCSToolStripButton});
            this.bSCSToolStrip.Location = new System.Drawing.Point(692, 280);
            this.bSCSToolStrip.Name = "bSCSToolStrip";
            this.bSCSToolStrip.Size = new System.Drawing.Size(134, 36);
            this.bSCSToolStrip.TabIndex = 4;
            this.bSCSToolStrip.Text = "BSCSToolStrip";
            // 
            // bSCSToolStripButton
            // 
            this.bSCSToolStripButton.BackColor = System.Drawing.Color.Fuchsia;
            this.bSCSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCSToolStripButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSCSToolStripButton.Name = "bSCSToolStripButton";
            this.bSCSToolStripButton.Size = new System.Drawing.Size(40, 33);
            this.bSCSToolStripButton.Text = "BSCS";
            this.bSCSToolStripButton.Click += new System.EventHandler(this.bSCSToolStripButton_Click);
            // 
            // bSITToolStrip
            // 
            this.bSITToolStrip.AutoSize = false;
            this.bSITToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bSITToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSITToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSITToolStripButton});
            this.bSITToolStrip.Location = new System.Drawing.Point(692, 317);
            this.bSITToolStrip.Name = "bSITToolStrip";
            this.bSITToolStrip.Size = new System.Drawing.Size(134, 37);
            this.bSITToolStrip.TabIndex = 5;
            this.bSITToolStrip.Text = "bSITToolStrip";
            // 
            // bSITToolStripButton
            // 
            this.bSITToolStripButton.BackColor = System.Drawing.Color.Fuchsia;
            this.bSITToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSITToolStripButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSITToolStripButton.Name = "bSITToolStripButton";
            this.bSITToolStripButton.Size = new System.Drawing.Size(38, 34);
            this.bSITToolStripButton.Text = "BSIT";
            this.bSITToolStripButton.Click += new System.EventHandler(this.bSITToolStripButton_Click);
            // 
            // tblStudent_InfoTableAdapter
            // 
            this.tblStudent_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // _2ND_YEAR3ToolStrip
            // 
            this._2ND_YEAR3ToolStrip.AutoSize = false;
            this._2ND_YEAR3ToolStrip.BackColor = System.Drawing.Color.Olive;
            this._2ND_YEAR3ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._2ND_YEAR3ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._2ND_YEAR3ToolStripButton});
            this._2ND_YEAR3ToolStrip.Location = new System.Drawing.Point(24, 272);
            this._2ND_YEAR3ToolStrip.Name = "_2ND_YEAR3ToolStrip";
            this._2ND_YEAR3ToolStrip.Size = new System.Drawing.Size(180, 35);
            this._2ND_YEAR3ToolStrip.TabIndex = 8;
            this._2ND_YEAR3ToolStrip.Text = "_2ND_YEARToolStrip";
            // 
            // _2ND_YEAR3ToolStripButton
            // 
            this._2ND_YEAR3ToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._2ND_YEAR3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._2ND_YEAR3ToolStripButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._2ND_YEAR3ToolStripButton.Name = "_2ND_YEAR3ToolStripButton";
            this._2ND_YEAR3ToolStripButton.Size = new System.Drawing.Size(73, 32);
            this._2ND_YEAR3ToolStripButton.Text = "2ND_YEAR";
            this._2ND_YEAR3ToolStripButton.Click += new System.EventHandler(this._2ND_YEAR3ToolStripButton_Click);
            // 
            // aDDRESS_BALANGA1ToolStrip
            // 
            this.aDDRESS_BALANGA1ToolStrip.AutoSize = false;
            this.aDDRESS_BALANGA1ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.aDDRESS_BALANGA1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.aDDRESS_BALANGA1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDRESS_BALANGA1ToolStripButton});
            this.aDDRESS_BALANGA1ToolStrip.Location = new System.Drawing.Point(484, 278);
            this.aDDRESS_BALANGA1ToolStrip.Name = "aDDRESS_BALANGA1ToolStrip";
            this.aDDRESS_BALANGA1ToolStrip.Size = new System.Drawing.Size(179, 66);
            this.aDDRESS_BALANGA1ToolStrip.TabIndex = 9;
            this.aDDRESS_BALANGA1ToolStrip.Text = "aDDRESS_BALANGA1ToolStrip";
            // 
            // aDDRESS_BALANGA1ToolStripButton
            // 
            this.aDDRESS_BALANGA1ToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aDDRESS_BALANGA1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aDDRESS_BALANGA1ToolStripButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDDRESS_BALANGA1ToolStripButton.Name = "aDDRESS_BALANGA1ToolStripButton";
            this.aDDRESS_BALANGA1ToolStripButton.Size = new System.Drawing.Size(125, 63);
            this.aDDRESS_BALANGA1ToolStripButton.Text = "ADDRESS_BALANGA";
            this.aDDRESS_BALANGA1ToolStripButton.Click += new System.EventHandler(this.aDDRESS_BALANGA1ToolStripButton_Click);
            // 
            // sECTION_2BToolStrip
            // 
            this.sECTION_2BToolStrip.AutoSize = false;
            this.sECTION_2BToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sECTION_2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.sECTION_2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sECTION_2BToolStripButton});
            this.sECTION_2BToolStrip.Location = new System.Drawing.Point(24, 317);
            this.sECTION_2BToolStrip.Name = "sECTION_2BToolStrip";
            this.sECTION_2BToolStrip.Size = new System.Drawing.Size(180, 37);
            this.sECTION_2BToolStrip.TabIndex = 10;
            this.sECTION_2BToolStrip.Text = "sECTION_2BToolStrip";
            // 
            // sECTION_2BToolStripButton
            // 
            this.sECTION_2BToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sECTION_2BToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sECTION_2BToolStripButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sECTION_2BToolStripButton.Name = "sECTION_2BToolStripButton";
            this.sECTION_2BToolStripButton.Size = new System.Drawing.Size(82, 34);
            this.sECTION_2BToolStripButton.Text = "SECTION_2B";
            this.sECTION_2BToolStripButton.Click += new System.EventHandler(this.sECTION_2BToolStripButton_Click);
            // 
            // lASTNAME_A_AND_C1ToolStrip
            // 
            this.lASTNAME_A_AND_C1ToolStrip.AutoSize = false;
            this.lASTNAME_A_AND_C1ToolStrip.BackColor = System.Drawing.Color.Yellow;
            this.lASTNAME_A_AND_C1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lASTNAME_A_AND_C1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lASTNAME_A_AND_C1ToolStripButton});
            this.lASTNAME_A_AND_C1ToolStrip.Location = new System.Drawing.Point(244, 272);
            this.lASTNAME_A_AND_C1ToolStrip.Name = "lASTNAME_A_AND_C1ToolStrip";
            this.lASTNAME_A_AND_C1ToolStrip.Size = new System.Drawing.Size(201, 35);
            this.lASTNAME_A_AND_C1ToolStrip.TabIndex = 11;
            this.lASTNAME_A_AND_C1ToolStrip.Text = "lASTNAME_A_AND_C1ToolStrip";
            // 
            // lASTNAME_A_AND_C1ToolStripButton
            // 
            this.lASTNAME_A_AND_C1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lASTNAME_A_AND_C1ToolStripButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lASTNAME_A_AND_C1ToolStripButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.lASTNAME_A_AND_C1ToolStripButton.Name = "lASTNAME_A_AND_C1ToolStripButton";
            this.lASTNAME_A_AND_C1ToolStripButton.Size = new System.Drawing.Size(130, 32);
            this.lASTNAME_A_AND_C1ToolStripButton.Text = "LASTNAME_A_AND_C";
            this.lASTNAME_A_AND_C1ToolStripButton.Click += new System.EventHandler(this.lASTNAME_A_AND_C1ToolStripButton_Click_1);
            // 
            // fIRSTNAME_CONSONANTToolStrip
            // 
            this.fIRSTNAME_CONSONANTToolStrip.AutoSize = false;
            this.fIRSTNAME_CONSONANTToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fIRSTNAME_CONSONANTToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fIRSTNAME_CONSONANTToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIRSTNAME_CONSONANTToolStripButton});
            this.fIRSTNAME_CONSONANTToolStrip.Location = new System.Drawing.Point(244, 317);
            this.fIRSTNAME_CONSONANTToolStrip.Name = "fIRSTNAME_CONSONANTToolStrip";
            this.fIRSTNAME_CONSONANTToolStrip.Size = new System.Drawing.Size(201, 37);
            this.fIRSTNAME_CONSONANTToolStrip.TabIndex = 12;
            this.fIRSTNAME_CONSONANTToolStrip.Text = "fIRSTNAME_CONSONANTToolStrip";
            this.fIRSTNAME_CONSONANTToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fIRSTNAME_CONSONANTToolStrip_ItemClicked);
            // 
            // fIRSTNAME_CONSONANTToolStripButton
            // 
            this.fIRSTNAME_CONSONANTToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fIRSTNAME_CONSONANTToolStripButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIRSTNAME_CONSONANTToolStripButton.ForeColor = System.Drawing.Color.Red;
            this.fIRSTNAME_CONSONANTToolStripButton.Name = "fIRSTNAME_CONSONANTToolStripButton";
            this.fIRSTNAME_CONSONANTToolStripButton.Size = new System.Drawing.Size(158, 34);
            this.fIRSTNAME_CONSONANTToolStripButton.Text = "FIRSTNAME_CONSONANT";
            this.fIRSTNAME_CONSONANTToolStripButton.Click += new System.EventHandler(this.fIRSTNAME_CONSONANTToolStripButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "\"STUDENT\'S  RECORDS  MONITORING  SYSTEM\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::LabActivity6_Agomaa.Properties.Resources._20200313_174119;
            this.ClientSize = new System.Drawing.Size(971, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fIRSTNAME_CONSONANTToolStrip);
            this.Controls.Add(this.lASTNAME_A_AND_C1ToolStrip);
            this.Controls.Add(this.sECTION_2BToolStrip);
            this.Controls.Add(this.aDDRESS_BALANGA1ToolStrip);
            this.Controls.Add(this._2ND_YEAR3ToolStrip);
            this.Controls.Add(this.bSITToolStrip);
            this.Controls.Add(this.bSCSToolStrip);
            this.Controls.Add(this.refreshToolStrip);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.refreshToolStrip.ResumeLayout(false);
            this.refreshToolStrip.PerformLayout();
            this.bSCSToolStrip.ResumeLayout(false);
            this.bSCSToolStrip.PerformLayout();
            this.bSITToolStrip.ResumeLayout(false);
            this.bSITToolStrip.PerformLayout();
            this._2ND_YEAR3ToolStrip.ResumeLayout(false);
            this._2ND_YEAR3ToolStrip.PerformLayout();
            this.aDDRESS_BALANGA1ToolStrip.ResumeLayout(false);
            this.aDDRESS_BALANGA1ToolStrip.PerformLayout();
            this.sECTION_2BToolStrip.ResumeLayout(false);
            this.sECTION_2BToolStrip.PerformLayout();
            this.lASTNAME_A_AND_C1ToolStrip.ResumeLayout(false);
            this.lASTNAME_A_AND_C1ToolStrip.PerformLayout();
            this.fIRSTNAME_CONSONANTToolStrip.ResumeLayout(false);
            this.fIRSTNAME_CONSONANTToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private studentsDataSetTableAdapters.tblStudent_InfoTableAdapter tblStudent_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip refreshToolStrip;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStrip bSCSToolStrip;
        private System.Windows.Forms.ToolStripButton bSCSToolStripButton;
        private System.Windows.Forms.ToolStrip bSITToolStrip;
        private System.Windows.Forms.ToolStripButton bSITToolStripButton;
        private System.Windows.Forms.ToolStrip _2ND_YEAR3ToolStrip;
        private System.Windows.Forms.ToolStripButton _2ND_YEAR3ToolStripButton;
        private System.Windows.Forms.ToolStrip aDDRESS_BALANGA1ToolStrip;
        private System.Windows.Forms.ToolStripButton aDDRESS_BALANGA1ToolStripButton;
        private System.Windows.Forms.ToolStrip sECTION_2BToolStrip;
        private System.Windows.Forms.ToolStripButton sECTION_2BToolStripButton;
        private System.Windows.Forms.ToolStrip lASTNAME_A_AND_C1ToolStrip;
        private System.Windows.Forms.ToolStripButton lASTNAME_A_AND_C1ToolStripButton;
        private System.Windows.Forms.ToolStrip fIRSTNAME_CONSONANTToolStrip;
        private System.Windows.Forms.ToolStripButton fIRSTNAME_CONSONANTToolStripButton;
        private System.Windows.Forms.Label label1;
    }
}

