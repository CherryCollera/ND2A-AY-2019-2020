namespace LabActivity06_Jimenez
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
            this.bSCSToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSCSToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new LabActivity06_Jimenez.studentsDataSet();
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudent_InfoTableAdapter = new LabActivity06_Jimenez.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            this.bSIT11ToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSIT11ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aDDRESS_BALANGAToolStrip = new System.Windows.Forms.ToolStrip();
            this.aDDRESS_BALANGAToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._2ND_YEARToolStrip = new System.Windows.Forms.ToolStrip();
            this._2ND_YEARToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.section_2BToolStrip = new System.Windows.Forms.ToolStrip();
            this.section_2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastname_A_and_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastname_A_and_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.firstname_ConsonantToolStrip = new System.Windows.Forms.ToolStrip();
            this.firstname_ConsonantToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.refreshToolStrip.SuspendLayout();
            this.bSCSToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.bSIT11ToolStrip.SuspendLayout();
            this.aDDRESS_BALANGAToolStrip.SuspendLayout();
            this._2ND_YEARToolStrip.SuspendLayout();
            this.section_2BToolStrip.SuspendLayout();
            this.lastname_A_and_CToolStrip.SuspendLayout();
            this.firstname_ConsonantToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Moccasin;
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
            this.dataGridView1.Location = new System.Drawing.Point(99, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 242);
            this.dataGridView1.TabIndex = 0;
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
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorMovePreviousItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(549, 302);
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
            this.refreshToolStrip.BackColor = System.Drawing.Color.DarkSalmon;
            this.refreshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.refreshToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.refreshToolStrip.Location = new System.Drawing.Point(869, 327);
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.Size = new System.Drawing.Size(132, 93);
            this.refreshToolStrip.TabIndex = 2;
            this.refreshToolStrip.Text = "refreshToolStrip";
            this.refreshToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.refreshToolStrip_ItemClicked);
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.AutoSize = false;
            this.refreshToolStripButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(120, 90);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // bSCSToolStrip
            // 
            this.bSCSToolStrip.AutoSize = false;
            this.bSCSToolStrip.BackColor = System.Drawing.Color.Plum;
            this.bSCSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCSToolStripButton});
            this.bSCSToolStrip.Location = new System.Drawing.Point(727, 327);
            this.bSCSToolStrip.Name = "bSCSToolStrip";
            this.bSCSToolStrip.Size = new System.Drawing.Size(120, 35);
            this.bSCSToolStrip.TabIndex = 3;
            this.bSCSToolStrip.Text = "bSCSToolStrip";
            this.bSCSToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bSCSToolStrip_ItemClicked);
            // 
            // bSCSToolStripButton
            // 
            this.bSCSToolStripButton.BackColor = System.Drawing.Color.Plum;
            this.bSCSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCSToolStripButton.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSCSToolStripButton.Name = "bSCSToolStripButton";
            this.bSCSToolStripButton.Size = new System.Drawing.Size(64, 32);
            this.bSCSToolStripButton.Text = "BSCS";
            this.bSCSToolStripButton.Click += new System.EventHandler(this.bSCSToolStripButton_Click);
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
            // bSIT11ToolStrip
            // 
            this.bSIT11ToolStrip.AutoSize = false;
            this.bSIT11ToolStrip.BackColor = System.Drawing.Color.Plum;
            this.bSIT11ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSIT11ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSIT11ToolStripButton});
            this.bSIT11ToolStrip.Location = new System.Drawing.Point(727, 395);
            this.bSIT11ToolStrip.Name = "bSIT11ToolStrip";
            this.bSIT11ToolStrip.Size = new System.Drawing.Size(120, 35);
            this.bSIT11ToolStrip.TabIndex = 6;
            this.bSIT11ToolStrip.Text = "bSIT11ToolStrip";
            // 
            // bSIT11ToolStripButton
            // 
            this.bSIT11ToolStripButton.BackColor = System.Drawing.Color.Plum;
            this.bSIT11ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSIT11ToolStripButton.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSIT11ToolStripButton.Name = "bSIT11ToolStripButton";
            this.bSIT11ToolStripButton.Size = new System.Drawing.Size(61, 32);
            this.bSIT11ToolStripButton.Text = "BSIT";
            this.bSIT11ToolStripButton.Click += new System.EventHandler(this.bSIT11ToolStripButton_Click);
            // 
            // aDDRESS_BALANGAToolStrip
            // 
            this.aDDRESS_BALANGAToolStrip.BackColor = System.Drawing.Color.NavajoWhite;
            this.aDDRESS_BALANGAToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.aDDRESS_BALANGAToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDRESS_BALANGAToolStripButton});
            this.aDDRESS_BALANGAToolStrip.Location = new System.Drawing.Point(218, 411);
            this.aDDRESS_BALANGAToolStrip.Name = "aDDRESS_BALANGAToolStrip";
            this.aDDRESS_BALANGAToolStrip.Size = new System.Drawing.Size(262, 48);
            this.aDDRESS_BALANGAToolStrip.TabIndex = 7;
            this.aDDRESS_BALANGAToolStrip.Text = "aDDRESS_BALANGAToolStrip";
            // 
            // aDDRESS_BALANGAToolStripButton
            // 
            this.aDDRESS_BALANGAToolStripButton.AutoSize = false;
            this.aDDRESS_BALANGAToolStripButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.aDDRESS_BALANGAToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aDDRESS_BALANGAToolStripButton.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDDRESS_BALANGAToolStripButton.Name = "aDDRESS_BALANGAToolStripButton";
            this.aDDRESS_BALANGAToolStripButton.Size = new System.Drawing.Size(250, 45);
            this.aDDRESS_BALANGAToolStripButton.Text = "ADDRESS BALANGA";
            this.aDDRESS_BALANGAToolStripButton.Click += new System.EventHandler(this.aDDRESS_BALANGAToolStripButton_Click);
            // 
            // _2ND_YEARToolStrip
            // 
            this._2ND_YEARToolStrip.BackColor = System.Drawing.Color.Violet;
            this._2ND_YEARToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._2ND_YEARToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._2ND_YEARToolStripButton});
            this._2ND_YEARToolStrip.Location = new System.Drawing.Point(535, 327);
            this._2ND_YEARToolStrip.Name = "_2ND_YEARToolStrip";
            this._2ND_YEARToolStrip.Size = new System.Drawing.Size(132, 38);
            this._2ND_YEARToolStrip.TabIndex = 8;
            this._2ND_YEARToolStrip.Text = "_2ND_YEARToolStrip";
            // 
            // _2ND_YEARToolStripButton
            // 
            this._2ND_YEARToolStripButton.AutoSize = false;
            this._2ND_YEARToolStripButton.BackColor = System.Drawing.Color.Violet;
            this._2ND_YEARToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._2ND_YEARToolStripButton.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._2ND_YEARToolStripButton.Name = "_2ND_YEARToolStripButton";
            this._2ND_YEARToolStripButton.Size = new System.Drawing.Size(120, 35);
            this._2ND_YEARToolStripButton.Text = "2ND YEAR";
            this._2ND_YEARToolStripButton.Click += new System.EventHandler(this._2ND_YEARToolStripButton_Click);
            // 
            // section_2BToolStrip
            // 
            this.section_2BToolStrip.BackColor = System.Drawing.Color.Violet;
            this.section_2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.section_2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.section_2BToolStripButton});
            this.section_2BToolStrip.Location = new System.Drawing.Point(535, 395);
            this.section_2BToolStrip.Name = "section_2BToolStrip";
            this.section_2BToolStrip.Size = new System.Drawing.Size(132, 38);
            this.section_2BToolStrip.TabIndex = 9;
            this.section_2BToolStrip.Text = "section_2BToolStrip";
            // 
            // section_2BToolStripButton
            // 
            this.section_2BToolStripButton.AutoSize = false;
            this.section_2BToolStripButton.AutoToolTip = false;
            this.section_2BToolStripButton.BackColor = System.Drawing.Color.Violet;
            this.section_2BToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.section_2BToolStripButton.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_2BToolStripButton.Name = "section_2BToolStripButton";
            this.section_2BToolStripButton.Size = new System.Drawing.Size(120, 35);
            this.section_2BToolStripButton.Text = "Section 2B";
            this.section_2BToolStripButton.Click += new System.EventHandler(this.section_2BToolStripButton_Click);
            // 
            // lastname_A_and_CToolStrip
            // 
            this.lastname_A_and_CToolStrip.BackColor = System.Drawing.Color.NavajoWhite;
            this.lastname_A_and_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lastname_A_and_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastname_A_and_CToolStripButton});
            this.lastname_A_and_CToolStrip.Location = new System.Drawing.Point(218, 353);
            this.lastname_A_and_CToolStrip.Name = "lastname_A_and_CToolStrip";
            this.lastname_A_and_CToolStrip.Size = new System.Drawing.Size(262, 48);
            this.lastname_A_and_CToolStrip.TabIndex = 10;
            this.lastname_A_and_CToolStrip.Text = "lastname_A_and_CToolStrip";
            // 
            // lastname_A_and_CToolStripButton
            // 
            this.lastname_A_and_CToolStripButton.AutoSize = false;
            this.lastname_A_and_CToolStripButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.lastname_A_and_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lastname_A_and_CToolStripButton.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_A_and_CToolStripButton.Name = "lastname_A_and_CToolStripButton";
            this.lastname_A_and_CToolStripButton.Size = new System.Drawing.Size(250, 45);
            this.lastname_A_and_CToolStripButton.Text = "Lastname A and C";
            this.lastname_A_and_CToolStripButton.Click += new System.EventHandler(this.lastname_A_and_CToolStripButton_Click);
            // 
            // firstname_ConsonantToolStrip
            // 
            this.firstname_ConsonantToolStrip.BackColor = System.Drawing.Color.NavajoWhite;
            this.firstname_ConsonantToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.firstname_ConsonantToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstname_ConsonantToolStripButton});
            this.firstname_ConsonantToolStrip.Location = new System.Drawing.Point(218, 299);
            this.firstname_ConsonantToolStrip.Name = "firstname_ConsonantToolStrip";
            this.firstname_ConsonantToolStrip.Size = new System.Drawing.Size(262, 48);
            this.firstname_ConsonantToolStrip.TabIndex = 11;
            this.firstname_ConsonantToolStrip.Text = "firstname_ConsonantToolStrip";
            // 
            // firstname_ConsonantToolStripButton
            // 
            this.firstname_ConsonantToolStripButton.AutoSize = false;
            this.firstname_ConsonantToolStripButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.firstname_ConsonantToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.firstname_ConsonantToolStripButton.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_ConsonantToolStripButton.Name = "firstname_ConsonantToolStripButton";
            this.firstname_ConsonantToolStripButton.Size = new System.Drawing.Size(250, 45);
            this.firstname_ConsonantToolStripButton.Text = "Firstname Consonant";
            this.firstname_ConsonantToolStripButton.Click += new System.EventHandler(this.firstname_ConsonantToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::LabActivity06_Jimenez.Properties.Resources.IMG_20200313_1710441;
            this.ClientSize = new System.Drawing.Size(1056, 469);
            this.Controls.Add(this.firstname_ConsonantToolStrip);
            this.Controls.Add(this.lastname_A_and_CToolStrip);
            this.Controls.Add(this.section_2BToolStrip);
            this.Controls.Add(this._2ND_YEARToolStrip);
            this.Controls.Add(this.aDDRESS_BALANGAToolStrip);
            this.Controls.Add(this.bSIT11ToolStrip);
            this.Controls.Add(this.bSCSToolStrip);
            this.Controls.Add(this.refreshToolStrip);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.refreshToolStrip.ResumeLayout(false);
            this.refreshToolStrip.PerformLayout();
            this.bSCSToolStrip.ResumeLayout(false);
            this.bSCSToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.bSIT11ToolStrip.ResumeLayout(false);
            this.bSIT11ToolStrip.PerformLayout();
            this.aDDRESS_BALANGAToolStrip.ResumeLayout(false);
            this.aDDRESS_BALANGAToolStrip.PerformLayout();
            this._2ND_YEARToolStrip.ResumeLayout(false);
            this._2ND_YEARToolStrip.PerformLayout();
            this.section_2BToolStrip.ResumeLayout(false);
            this.section_2BToolStrip.PerformLayout();
            this.lastname_A_and_CToolStrip.ResumeLayout(false);
            this.lastname_A_and_CToolStrip.PerformLayout();
            this.firstname_ConsonantToolStrip.ResumeLayout(false);
            this.firstname_ConsonantToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStrip refreshToolStrip;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStrip bSCSToolStrip;
        private System.Windows.Forms.ToolStripButton bSCSToolStripButton;
        private System.Windows.Forms.ToolStrip bSIT11ToolStrip;
        private System.Windows.Forms.ToolStripButton bSIT11ToolStripButton;
        private System.Windows.Forms.ToolStrip aDDRESS_BALANGAToolStrip;
        private System.Windows.Forms.ToolStripButton aDDRESS_BALANGAToolStripButton;
        private System.Windows.Forms.ToolStrip _2ND_YEARToolStrip;
        private System.Windows.Forms.ToolStripButton _2ND_YEARToolStripButton;
        private System.Windows.Forms.ToolStrip section_2BToolStrip;
        private System.Windows.Forms.ToolStripButton section_2BToolStripButton;
        private System.Windows.Forms.ToolStrip lastname_A_and_CToolStrip;
        private System.Windows.Forms.ToolStripButton lastname_A_and_CToolStripButton;
        private System.Windows.Forms.ToolStrip firstname_ConsonantToolStrip;
        private System.Windows.Forms.ToolStripButton firstname_ConsonantToolStripButton;
    }
}

