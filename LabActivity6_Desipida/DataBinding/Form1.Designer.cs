namespace DataBinding
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
            this.studentsDataSet = new DataBinding.studentsDataSet();
            this.label1 = new System.Windows.Forms.Label();
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
            this.bSCS1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSCS1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bSITToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSITToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.balangaToolStrip = new System.Windows.Forms.ToolStrip();
            this.balangaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._2nd_YearToolStrip = new System.Windows.Forms.ToolStrip();
            this._2nd_YearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.firstName_ConsonantsToolStrip = new System.Windows.Forms.ToolStrip();
            this.firstName_ConsonantsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastNameACToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastNameACToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._2B_SectionToolStrip = new System.Windows.Forms.ToolStrip();
            this._2B_SectionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tblStudent_InfoTableAdapter = new DataBinding.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.refreshToolStrip.SuspendLayout();
            this.bSCS1ToolStrip.SuspendLayout();
            this.bSITToolStrip.SuspendLayout();
            this.balangaToolStrip.SuspendLayout();
            this._2nd_YearToolStrip.SuspendLayout();
            this.firstName_ConsonantsToolStrip.SuspendLayout();
            this.lastNameACToolStrip.SuspendLayout();
            this._2B_SectionToolStrip.SuspendLayout();
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
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(34, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 298);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students\' Records Monitoring System";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.tblStudentInfoBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.bindingNavigator1.Location = new System.Drawing.Point(469, 373);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(271, 27);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // refreshToolStrip
            // 
            this.refreshToolStrip.AutoSize = false;
            this.refreshToolStrip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.refreshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.refreshToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.refreshToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.refreshToolStrip.Location = new System.Drawing.Point(892, 484);
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.Size = new System.Drawing.Size(124, 50);
            this.refreshToolStrip.TabIndex = 3;
            this.refreshToolStrip.Text = "refreshToolStrip";
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(76, 47);
            this.refreshToolStripButton.Text = "REFRESH";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // bSCS1ToolStrip
            // 
            this.bSCS1ToolStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bSCS1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCS1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bSCS1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCS1ToolStripButton});
            this.bSCS1ToolStrip.Location = new System.Drawing.Point(135, 433);
            this.bSCS1ToolStrip.Name = "bSCS1ToolStrip";
            this.bSCS1ToolStrip.Size = new System.Drawing.Size(165, 33);
            this.bSCS1ToolStrip.TabIndex = 4;
            this.bSCS1ToolStrip.Text = "bSCS1ToolStrip";
            // 
            // bSCS1ToolStripButton
            // 
            this.bSCS1ToolStripButton.AutoSize = false;
            this.bSCS1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCS1ToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSCS1ToolStripButton.Name = "bSCS1ToolStripButton";
            this.bSCS1ToolStripButton.Size = new System.Drawing.Size(153, 30);
            this.bSCS1ToolStripButton.Text = "BSCS";
            this.bSCS1ToolStripButton.Click += new System.EventHandler(this.bSCS1ToolStripButton_Click);
            // 
            // bSITToolStrip
            // 
            this.bSITToolStrip.AutoSize = false;
            this.bSITToolStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bSITToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSITToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bSITToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSITToolStripButton});
            this.bSITToolStrip.Location = new System.Drawing.Point(135, 484);
            this.bSITToolStrip.Name = "bSITToolStrip";
            this.bSITToolStrip.Size = new System.Drawing.Size(153, 33);
            this.bSITToolStrip.TabIndex = 5;
            this.bSITToolStrip.Text = "bSITToolStrip";
            // 
            // bSITToolStripButton
            // 
            this.bSITToolStripButton.AutoSize = false;
            this.bSITToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSITToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSITToolStripButton.Name = "bSITToolStripButton";
            this.bSITToolStripButton.Size = new System.Drawing.Size(42, 30);
            this.bSITToolStripButton.Text = "BSIT";
            this.bSITToolStripButton.Click += new System.EventHandler(this.bSITToolStripButton_Click);
            // 
            // balangaToolStrip
            // 
            this.balangaToolStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.balangaToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.balangaToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.balangaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balangaToolStripButton});
            this.balangaToolStrip.Location = new System.Drawing.Point(370, 433);
            this.balangaToolStrip.Name = "balangaToolStrip";
            this.balangaToolStrip.Size = new System.Drawing.Size(125, 36);
            this.balangaToolStrip.TabIndex = 6;
            this.balangaToolStrip.Text = "balangaToolStrip";
            // 
            // balangaToolStripButton
            // 
            this.balangaToolStripButton.AutoSize = false;
            this.balangaToolStripButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.balangaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.balangaToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balangaToolStripButton.Name = "balangaToolStripButton";
            this.balangaToolStripButton.Size = new System.Drawing.Size(113, 33);
            this.balangaToolStripButton.Text = "BALANGA CITY";
            this.balangaToolStripButton.Click += new System.EventHandler(this.balangaToolStripButton_Click);
            // 
            // _2nd_YearToolStrip
            // 
            this._2nd_YearToolStrip.AutoSize = false;
            this._2nd_YearToolStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this._2nd_YearToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._2nd_YearToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._2nd_YearToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._2nd_YearToolStripButton});
            this._2nd_YearToolStrip.Location = new System.Drawing.Point(370, 484);
            this._2nd_YearToolStrip.Name = "_2nd_YearToolStrip";
            this._2nd_YearToolStrip.Size = new System.Drawing.Size(111, 33);
            this._2nd_YearToolStrip.TabIndex = 7;
            this._2nd_YearToolStrip.Text = "_2nd_YearToolStrip";
            // 
            // _2nd_YearToolStripButton
            // 
            this._2nd_YearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._2nd_YearToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._2nd_YearToolStripButton.Name = "_2nd_YearToolStripButton";
            this._2nd_YearToolStripButton.Size = new System.Drawing.Size(83, 30);
            this._2nd_YearToolStripButton.Text = "2NDYEAR";
            this._2nd_YearToolStripButton.Click += new System.EventHandler(this._2nd_YearToolStripButton_Click);
            // 
            // firstName_ConsonantsToolStrip
            // 
            this.firstName_ConsonantsToolStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.firstName_ConsonantsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.firstName_ConsonantsToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.firstName_ConsonantsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstName_ConsonantsToolStripButton});
            this.firstName_ConsonantsToolStrip.Location = new System.Drawing.Point(575, 433);
            this.firstName_ConsonantsToolStrip.Name = "firstName_ConsonantsToolStrip";
            this.firstName_ConsonantsToolStrip.Size = new System.Drawing.Size(165, 36);
            this.firstName_ConsonantsToolStrip.TabIndex = 9;
            this.firstName_ConsonantsToolStrip.Text = "firstName_ConsonantsToolStrip";
            // 
            // firstName_ConsonantsToolStripButton
            // 
            this.firstName_ConsonantsToolStripButton.AutoSize = false;
            this.firstName_ConsonantsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.firstName_ConsonantsToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_ConsonantsToolStripButton.Name = "firstName_ConsonantsToolStripButton";
            this.firstName_ConsonantsToolStripButton.Size = new System.Drawing.Size(153, 33);
            this.firstName_ConsonantsToolStripButton.Text = "FIRST_CONSONANTS";
            this.firstName_ConsonantsToolStripButton.Click += new System.EventHandler(this.firstName_ConsonantsToolStripButton_Click);
            // 
            // lastNameACToolStrip
            // 
            this.lastNameACToolStrip.AutoSize = false;
            this.lastNameACToolStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lastNameACToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lastNameACToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lastNameACToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastNameACToolStripButton});
            this.lastNameACToolStrip.Location = new System.Drawing.Point(860, 433);
            this.lastNameACToolStrip.Name = "lastNameACToolStrip";
            this.lastNameACToolStrip.Size = new System.Drawing.Size(220, 33);
            this.lastNameACToolStrip.TabIndex = 10;
            this.lastNameACToolStrip.Text = "lastNameACToolStrip";
            // 
            // lastNameACToolStripButton
            // 
            this.lastNameACToolStripButton.AutoSize = false;
            this.lastNameACToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lastNameACToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameACToolStripButton.Name = "lastNameACToolStripButton";
            this.lastNameACToolStripButton.Size = new System.Drawing.Size(153, 33);
            this.lastNameACToolStripButton.Text = "LASTNAMEAC";
            this.lastNameACToolStripButton.Click += new System.EventHandler(this.lastNameACToolStripButton_Click);
            // 
            // _2B_SectionToolStrip
            // 
            this._2B_SectionToolStrip.AutoSize = false;
            this._2B_SectionToolStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this._2B_SectionToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._2B_SectionToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._2B_SectionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._2B_SectionToolStripButton});
            this._2B_SectionToolStrip.Location = new System.Drawing.Point(575, 484);
            this._2B_SectionToolStrip.Name = "_2B_SectionToolStrip";
            this._2B_SectionToolStrip.Size = new System.Drawing.Size(153, 33);
            this._2B_SectionToolStrip.TabIndex = 11;
            this._2B_SectionToolStrip.Text = "_2B_SectionToolStrip";
            // 
            // _2B_SectionToolStripButton
            // 
            this._2B_SectionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._2B_SectionToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._2B_SectionToolStripButton.Name = "_2B_SectionToolStripButton";
            this._2B_SectionToolStripButton.Size = new System.Drawing.Size(100, 30);
            this._2B_SectionToolStripButton.Text = "2B_SECTION";
            this._2B_SectionToolStripButton.Click += new System.EventHandler(this._2B_SectionToolStripButton_Click);
            // 
            // tblStudent_InfoTableAdapter
            // 
            this.tblStudent_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 569);
            this.Controls.Add(this._2B_SectionToolStrip);
            this.Controls.Add(this.lastNameACToolStrip);
            this.Controls.Add(this.firstName_ConsonantsToolStrip);
            this.Controls.Add(this._2nd_YearToolStrip);
            this.Controls.Add(this.balangaToolStrip);
            this.Controls.Add(this.bSITToolStrip);
            this.Controls.Add(this.bSCS1ToolStrip);
            this.Controls.Add(this.refreshToolStrip);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Grid View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.refreshToolStrip.ResumeLayout(false);
            this.refreshToolStrip.PerformLayout();
            this.bSCS1ToolStrip.ResumeLayout(false);
            this.bSCS1ToolStrip.PerformLayout();
            this.bSITToolStrip.ResumeLayout(false);
            this.bSITToolStrip.PerformLayout();
            this.balangaToolStrip.ResumeLayout(false);
            this.balangaToolStrip.PerformLayout();
            this._2nd_YearToolStrip.ResumeLayout(false);
            this._2nd_YearToolStrip.PerformLayout();
            this.firstName_ConsonantsToolStrip.ResumeLayout(false);
            this.firstName_ConsonantsToolStrip.PerformLayout();
            this.lastNameACToolStrip.ResumeLayout(false);
            this.lastNameACToolStrip.PerformLayout();
            this._2B_SectionToolStrip.ResumeLayout(false);
            this._2B_SectionToolStrip.PerformLayout();
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
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ToolStrip bSCS1ToolStrip;
        private System.Windows.Forms.ToolStripButton bSCS1ToolStripButton;
        private System.Windows.Forms.ToolStrip bSITToolStrip;
        private System.Windows.Forms.ToolStripButton bSITToolStripButton;
        private System.Windows.Forms.ToolStrip balangaToolStrip;
        private System.Windows.Forms.ToolStripButton balangaToolStripButton;
        private System.Windows.Forms.ToolStrip _2nd_YearToolStrip;
        private System.Windows.Forms.ToolStripButton _2nd_YearToolStripButton;
        private System.Windows.Forms.ToolStrip firstName_ConsonantsToolStrip;
        private System.Windows.Forms.ToolStripButton firstName_ConsonantsToolStripButton;
        private System.Windows.Forms.ToolStrip lastNameACToolStrip;
        private System.Windows.Forms.ToolStripButton lastNameACToolStripButton;
        private System.Windows.Forms.ToolStrip _2B_SectionToolStrip;
        private System.Windows.Forms.ToolStripButton _2B_SectionToolStripButton;
    }
}

