namespace LabActivity6_Salas
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
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStrip = new System.Windows.Forms.ToolStrip();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bSITToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSITToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new LabActivity6_Salas.studentsDataSet();
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudent_InfoTableAdapter = new LabActivity6_Salas.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            this.bSCS1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSCS1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._2ND_YEAR1ToolStrip = new System.Windows.Forms.ToolStrip();
            this._2ND_YEAR1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aDDRESSBALANGAToolStrip = new System.Windows.Forms.ToolStrip();
            this.aDDRESSBALANGAToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sECTION_2BToolStrip = new System.Windows.Forms.ToolStrip();
            this.sECTION_2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastName_A_and_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastName_A_and_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.first_Name_ConsonantToolStrip = new System.Windows.Forms.ToolStrip();
            this.first_Name_ConsonantToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.refreshToolStrip.SuspendLayout();
            this.bSITToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.bSCS1ToolStrip.SuspendLayout();
            this._2ND_YEAR1ToolStrip.SuspendLayout();
            this.aDDRESSBALANGAToolStrip.SuspendLayout();
            this.sECTION_2BToolStrip.SuspendLayout();
            this.lastName_A_and_CToolStrip.SuspendLayout();
            this.first_Name_ConsonantToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
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
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(101, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(357, 305);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // refreshToolStrip
            // 
            this.refreshToolStrip.AutoSize = false;
            this.refreshToolStrip.BackColor = System.Drawing.Color.Black;
            this.refreshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.refreshToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.refreshToolStrip.Location = new System.Drawing.Point(757, 338);
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.Size = new System.Drawing.Size(81, 81);
            this.refreshToolStrip.TabIndex = 2;
            this.refreshToolStrip.Text = "refreshToolStrip";
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.ForeColor = System.Drawing.Color.Salmon;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(50, 78);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // bSITToolStrip
            // 
            this.bSITToolStrip.AutoSize = false;
            this.bSITToolStrip.BackColor = System.Drawing.Color.Black;
            this.bSITToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSITToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSITToolStripButton});
            this.bSITToolStrip.Location = new System.Drawing.Point(159, 383);
            this.bSITToolStrip.Name = "bSITToolStrip";
            this.bSITToolStrip.Size = new System.Drawing.Size(80, 36);
            this.bSITToolStrip.TabIndex = 4;
            this.bSITToolStrip.Text = "bSITToolStrip";
            this.bSITToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bSITToolStrip_ItemClicked);
            // 
            // bSITToolStripButton
            // 
            this.bSITToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSITToolStripButton.Name = "bSITToolStripButton";
            this.bSITToolStripButton.Size = new System.Drawing.Size(34, 33);
            this.bSITToolStripButton.Text = "BSIT";
            this.bSITToolStripButton.Click += new System.EventHandler(this.bSITToolStripButton_Click);
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
            // tblStudent_InfoTableAdapter
            // 
            this.tblStudent_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // bSCS1ToolStrip
            // 
            this.bSCS1ToolStrip.AutoSize = false;
            this.bSCS1ToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSCS1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCS1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCS1ToolStripButton});
            this.bSCS1ToolStrip.Location = new System.Drawing.Point(159, 338);
            this.bSCS1ToolStrip.Name = "bSCS1ToolStrip";
            this.bSCS1ToolStrip.Size = new System.Drawing.Size(80, 37);
            this.bSCS1ToolStrip.TabIndex = 7;
            this.bSCS1ToolStrip.Text = "bSCS1ToolStrip";
            // 
            // bSCS1ToolStripButton
            // 
            this.bSCS1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCS1ToolStripButton.Name = "bSCS1ToolStripButton";
            this.bSCS1ToolStripButton.Size = new System.Drawing.Size(44, 34);
            this.bSCS1ToolStripButton.Text = "BSCS1";
            this.bSCS1ToolStripButton.Click += new System.EventHandler(this.bSCS1ToolStripButton_Click);
            // 
            // _2ND_YEAR1ToolStrip
            // 
            this._2ND_YEAR1ToolStrip.AutoSize = false;
            this._2ND_YEAR1ToolStrip.BackColor = System.Drawing.Color.Black;
            this._2ND_YEAR1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._2ND_YEAR1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._2ND_YEAR1ToolStripButton});
            this._2ND_YEAR1ToolStrip.Location = new System.Drawing.Point(258, 338);
            this._2ND_YEAR1ToolStrip.Name = "_2ND_YEAR1ToolStrip";
            this._2ND_YEAR1ToolStrip.Size = new System.Drawing.Size(147, 37);
            this._2ND_YEAR1ToolStrip.TabIndex = 8;
            this._2ND_YEAR1ToolStrip.Text = "_2ND_YEAR1ToolStrip";
            // 
            // _2ND_YEAR1ToolStripButton
            // 
            this._2ND_YEAR1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._2ND_YEAR1ToolStripButton.Name = "_2ND_YEAR1ToolStripButton";
            this._2ND_YEAR1ToolStripButton.Size = new System.Drawing.Size(78, 34);
            this._2ND_YEAR1ToolStripButton.Text = "_2ND_YEAR1";
            this._2ND_YEAR1ToolStripButton.Click += new System.EventHandler(this._2ND_YEAR1ToolStripButton_Click);
            // 
            // aDDRESSBALANGAToolStrip
            // 
            this.aDDRESSBALANGAToolStrip.AutoSize = false;
            this.aDDRESSBALANGAToolStrip.BackColor = System.Drawing.Color.Black;
            this.aDDRESSBALANGAToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.aDDRESSBALANGAToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDRESSBALANGAToolStripButton});
            this.aDDRESSBALANGAToolStrip.Location = new System.Drawing.Point(258, 383);
            this.aDDRESSBALANGAToolStrip.Name = "aDDRESSBALANGAToolStrip";
            this.aDDRESSBALANGAToolStrip.Size = new System.Drawing.Size(147, 36);
            this.aDDRESSBALANGAToolStrip.TabIndex = 9;
            this.aDDRESSBALANGAToolStrip.Text = "aDDRESSBALANGAToolStrip";
            // 
            // aDDRESSBALANGAToolStripButton
            // 
            this.aDDRESSBALANGAToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aDDRESSBALANGAToolStripButton.Name = "aDDRESSBALANGAToolStripButton";
            this.aDDRESSBALANGAToolStripButton.Size = new System.Drawing.Size(114, 33);
            this.aDDRESSBALANGAToolStripButton.Text = "ADDRESSBALANGA";
            this.aDDRESSBALANGAToolStripButton.Click += new System.EventHandler(this.aDDRESSBALANGAToolStripButton_Click);
            // 
            // sECTION_2BToolStrip
            // 
            this.sECTION_2BToolStrip.AutoSize = false;
            this.sECTION_2BToolStrip.BackColor = System.Drawing.Color.Black;
            this.sECTION_2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.sECTION_2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sECTION_2BToolStripButton});
            this.sECTION_2BToolStrip.Location = new System.Drawing.Point(426, 383);
            this.sECTION_2BToolStrip.Name = "sECTION_2BToolStrip";
            this.sECTION_2BToolStrip.Size = new System.Drawing.Size(117, 36);
            this.sECTION_2BToolStrip.TabIndex = 10;
            this.sECTION_2BToolStrip.Text = "sECTION_2BToolStrip";
            this.sECTION_2BToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sECTION_2BToolStrip_ItemClicked);
            // 
            // sECTION_2BToolStripButton
            // 
            this.sECTION_2BToolStripButton.AutoSize = false;
            this.sECTION_2BToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sECTION_2BToolStripButton.Name = "sECTION_2BToolStripButton";
            this.sECTION_2BToolStripButton.Size = new System.Drawing.Size(77, 22);
            this.sECTION_2BToolStripButton.Text = "SECTION_2B";
            this.sECTION_2BToolStripButton.Click += new System.EventHandler(this.sECTION_2BToolStripButton_Click);
            // 
            // lastName_A_and_CToolStrip
            // 
            this.lastName_A_and_CToolStrip.AutoSize = false;
            this.lastName_A_and_CToolStrip.BackColor = System.Drawing.Color.Black;
            this.lastName_A_and_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lastName_A_and_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastName_A_and_CToolStripButton});
            this.lastName_A_and_CToolStrip.Location = new System.Drawing.Point(562, 383);
            this.lastName_A_and_CToolStrip.Name = "lastName_A_and_CToolStrip";
            this.lastName_A_and_CToolStrip.Size = new System.Drawing.Size(181, 36);
            this.lastName_A_and_CToolStrip.TabIndex = 11;
            this.lastName_A_and_CToolStrip.Text = "lastName_A_and_CToolStrip";
            // 
            // lastName_A_and_CToolStripButton
            // 
            this.lastName_A_and_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lastName_A_and_CToolStripButton.Name = "lastName_A_and_CToolStripButton";
            this.lastName_A_and_CToolStripButton.Size = new System.Drawing.Size(115, 33);
            this.lastName_A_and_CToolStripButton.Text = "LastName_A_and_C";
            this.lastName_A_and_CToolStripButton.Click += new System.EventHandler(this.lastName_A_and_CToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Students\'  Records Monitoring System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // first_Name_ConsonantToolStrip
            // 
            this.first_Name_ConsonantToolStrip.AutoSize = false;
            this.first_Name_ConsonantToolStrip.BackColor = System.Drawing.Color.Black;
            this.first_Name_ConsonantToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.first_Name_ConsonantToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.first_Name_ConsonantToolStripButton});
            this.first_Name_ConsonantToolStrip.Location = new System.Drawing.Point(426, 338);
            this.first_Name_ConsonantToolStrip.Name = "first_Name_ConsonantToolStrip";
            this.first_Name_ConsonantToolStrip.Size = new System.Drawing.Size(317, 37);
            this.first_Name_ConsonantToolStrip.TabIndex = 14;
            this.first_Name_ConsonantToolStrip.Text = "first_Name_ConsonantToolStrip";
            // 
            // first_Name_ConsonantToolStripButton
            // 
            this.first_Name_ConsonantToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.first_Name_ConsonantToolStripButton.Name = "first_Name_ConsonantToolStripButton";
            this.first_Name_ConsonantToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.first_Name_ConsonantToolStripButton.Text = "First_Name_Consonant";
            this.first_Name_ConsonantToolStripButton.Click += new System.EventHandler(this.first_Name_ConsonantToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 439);
            this.Controls.Add(this.first_Name_ConsonantToolStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName_A_and_CToolStrip);
            this.Controls.Add(this.sECTION_2BToolStrip);
            this.Controls.Add(this.aDDRESSBALANGAToolStrip);
            this.Controls.Add(this._2ND_YEAR1ToolStrip);
            this.Controls.Add(this.bSCS1ToolStrip);
            this.Controls.Add(this.bSITToolStrip);
            this.Controls.Add(this.refreshToolStrip);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.refreshToolStrip.ResumeLayout(false);
            this.refreshToolStrip.PerformLayout();
            this.bSITToolStrip.ResumeLayout(false);
            this.bSITToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.bSCS1ToolStrip.ResumeLayout(false);
            this.bSCS1ToolStrip.PerformLayout();
            this._2ND_YEAR1ToolStrip.ResumeLayout(false);
            this._2ND_YEAR1ToolStrip.PerformLayout();
            this.aDDRESSBALANGAToolStrip.ResumeLayout(false);
            this.aDDRESSBALANGAToolStrip.PerformLayout();
            this.sECTION_2BToolStrip.ResumeLayout(false);
            this.sECTION_2BToolStrip.PerformLayout();
            this.lastName_A_and_CToolStrip.ResumeLayout(false);
            this.lastName_A_and_CToolStrip.PerformLayout();
            this.first_Name_ConsonantToolStrip.ResumeLayout(false);
            this.first_Name_ConsonantToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStrip bSITToolStrip;
        private System.Windows.Forms.ToolStripButton bSITToolStripButton;
        private System.Windows.Forms.ToolStrip bSCS1ToolStrip;
        private System.Windows.Forms.ToolStripButton bSCS1ToolStripButton;
        private System.Windows.Forms.ToolStrip _2ND_YEAR1ToolStrip;
        private System.Windows.Forms.ToolStripButton _2ND_YEAR1ToolStripButton;
        private System.Windows.Forms.ToolStrip aDDRESSBALANGAToolStrip;
        private System.Windows.Forms.ToolStripButton aDDRESSBALANGAToolStripButton;
        private System.Windows.Forms.ToolStrip sECTION_2BToolStrip;
        private System.Windows.Forms.ToolStripButton sECTION_2BToolStripButton;
        private System.Windows.Forms.ToolStrip lastName_A_and_CToolStrip;
        private System.Windows.Forms.ToolStripButton lastName_A_and_CToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip first_Name_ConsonantToolStrip;
        private System.Windows.Forms.ToolStripButton first_Name_ConsonantToolStripButton;
    }
}

