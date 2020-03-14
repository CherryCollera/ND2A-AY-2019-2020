namespace DataGridView1_Miller
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
            this.iTToolStrip = new System.Windows.Forms.ToolStrip();
            this.iTToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.balangaToolStrip = new System.Windows.Forms.ToolStrip();
            this.balangaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.secondYearToolStrip = new System.Windows.Forms.ToolStrip();
            this.secondYearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastname_A_and_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastname_A_and_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.section_2BToolStrip = new System.Windows.Forms.ToolStrip();
            this.section_2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new DataGridView1_Miller.studentsDataSet();
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudent_InfoTableAdapter = new DataGridView1_Miller.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            this.firstName_A_and_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.firstName_A_and_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.refreshToolStrip.SuspendLayout();
            this.bSCSToolStrip.SuspendLayout();
            this.iTToolStrip.SuspendLayout();
            this.balangaToolStrip.SuspendLayout();
            this.secondYearToolStrip.SuspendLayout();
            this.lastname_A_and_CToolStrip.SuspendLayout();
            this.section_2BToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.firstName_A_and_CToolStrip.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(60, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(945, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.tblStudentInfoBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.bindingNavigator1.Location = new System.Drawing.Point(385, 314);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(304, 31);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // refreshToolStrip
            // 
            this.refreshToolStrip.AutoSize = false;
            this.refreshToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.refreshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.refreshToolStrip.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.refreshToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.refreshToolStrip.Location = new System.Drawing.Point(788, 392);
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.Size = new System.Drawing.Size(172, 150);
            this.refreshToolStrip.TabIndex = 2;
            this.refreshToolStrip.Text = "refreshToolStrip";
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(100, 147);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // bSCSToolStrip
            // 
            this.bSCSToolStrip.AutoSize = false;
            this.bSCSToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(119)))));
            this.bSCSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCSToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bSCSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCSToolStripButton});
            this.bSCSToolStrip.Location = new System.Drawing.Point(385, 431);
            this.bSCSToolStrip.Name = "bSCSToolStrip";
            this.bSCSToolStrip.Size = new System.Drawing.Size(106, 38);
            this.bSCSToolStrip.TabIndex = 3;
            this.bSCSToolStrip.Text = "bSCSToolStrip";
            // 
            // bSCSToolStripButton
            // 
            this.bSCSToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(119)))));
            this.bSCSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCSToolStripButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSCSToolStripButton.ForeColor = System.Drawing.Color.White;
            this.bSCSToolStripButton.Name = "bSCSToolStripButton";
            this.bSCSToolStripButton.Size = new System.Drawing.Size(68, 29);
            this.bSCSToolStripButton.Text = "BSCS";
            this.bSCSToolStripButton.Click += new System.EventHandler(this.bSCSToolStripButton_Click);
            // 
            // iTToolStrip
            // 
            this.iTToolStrip.AutoSize = false;
            this.iTToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(119)))));
            this.iTToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.iTToolStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.iTToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTToolStripButton});
            this.iTToolStrip.Location = new System.Drawing.Point(565, 431);
            this.iTToolStrip.Name = "iTToolStrip";
            this.iTToolStrip.Size = new System.Drawing.Size(86, 38);
            this.iTToolStrip.TabIndex = 4;
            this.iTToolStrip.Text = "iTToolStrip";
            // 
            // iTToolStripButton
            // 
            this.iTToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.iTToolStripButton.ForeColor = System.Drawing.Color.White;
            this.iTToolStripButton.Name = "iTToolStripButton";
            this.iTToolStripButton.Size = new System.Drawing.Size(42, 29);
            this.iTToolStripButton.Text = "IT";
            this.iTToolStripButton.Click += new System.EventHandler(this.iTToolStripButton_Click);
            // 
            // balangaToolStrip
            // 
            this.balangaToolStrip.AutoSize = false;
            this.balangaToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(119)))));
            this.balangaToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.balangaToolStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balangaToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.balangaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balangaToolStripButton});
            this.balangaToolStrip.Location = new System.Drawing.Point(69, 372);
            this.balangaToolStrip.Name = "balangaToolStrip";
            this.balangaToolStrip.Size = new System.Drawing.Size(154, 42);
            this.balangaToolStrip.TabIndex = 5;
            this.balangaToolStrip.Text = "balangaToolStrip";
            // 
            // balangaToolStripButton
            // 
            this.balangaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.balangaToolStripButton.ForeColor = System.Drawing.Color.White;
            this.balangaToolStripButton.Name = "balangaToolStripButton";
            this.balangaToolStripButton.Size = new System.Drawing.Size(107, 30);
            this.balangaToolStripButton.Text = "Balanga";
            this.balangaToolStripButton.Click += new System.EventHandler(this.balangaToolStripButton_Click);
            // 
            // secondYearToolStrip
            // 
            this.secondYearToolStrip.AutoSize = false;
            this.secondYearToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(119)))));
            this.secondYearToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.secondYearToolStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondYearToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.secondYearToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondYearToolStripButton});
            this.secondYearToolStrip.Location = new System.Drawing.Point(69, 491);
            this.secondYearToolStrip.Name = "secondYearToolStrip";
            this.secondYearToolStrip.Size = new System.Drawing.Size(194, 51);
            this.secondYearToolStrip.TabIndex = 6;
            this.secondYearToolStrip.Text = "secondYearToolStrip";
            // 
            // secondYearToolStripButton
            // 
            this.secondYearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.secondYearToolStripButton.ForeColor = System.Drawing.Color.White;
            this.secondYearToolStripButton.Name = "secondYearToolStripButton";
            this.secondYearToolStripButton.Size = new System.Drawing.Size(146, 41);
            this.secondYearToolStripButton.Text = "SecondYear";
            this.secondYearToolStripButton.Click += new System.EventHandler(this.secondYearToolStripButton_Click);
            // 
            // lastname_A_and_CToolStrip
            // 
            this.lastname_A_and_CToolStrip.AutoSize = false;
            this.lastname_A_and_CToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(119)))));
            this.lastname_A_and_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lastname_A_and_CToolStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_A_and_CToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.lastname_A_and_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastname_A_and_CToolStripButton});
            this.lastname_A_and_CToolStrip.Location = new System.Drawing.Point(385, 370);
            this.lastname_A_and_CToolStrip.Name = "lastname_A_and_CToolStrip";
            this.lastname_A_and_CToolStrip.Size = new System.Drawing.Size(266, 44);
            this.lastname_A_and_CToolStrip.TabIndex = 7;
            this.lastname_A_and_CToolStrip.Text = "lastname_A_and_CToolStrip";
            // 
            // lastname_A_and_CToolStripButton
            // 
            this.lastname_A_and_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lastname_A_and_CToolStripButton.ForeColor = System.Drawing.Color.White;
            this.lastname_A_and_CToolStripButton.Name = "lastname_A_and_CToolStripButton";
            this.lastname_A_and_CToolStripButton.Size = new System.Drawing.Size(224, 41);
            this.lastname_A_and_CToolStripButton.Text = "Lastname_A_and_C";
            this.lastname_A_and_CToolStripButton.Click += new System.EventHandler(this.lastname_A_and_CToolStripButton_Click);
            // 
            // section_2BToolStrip
            // 
            this.section_2BToolStrip.AutoSize = false;
            this.section_2BToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(119)))));
            this.section_2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.section_2BToolStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_2BToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.section_2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.section_2BToolStripButton});
            this.section_2BToolStrip.Location = new System.Drawing.Point(69, 431);
            this.section_2BToolStrip.Name = "section_2BToolStrip";
            this.section_2BToolStrip.Size = new System.Drawing.Size(184, 45);
            this.section_2BToolStrip.TabIndex = 8;
            this.section_2BToolStrip.Text = "section_2BToolStrip";
            // 
            // section_2BToolStripButton
            // 
            this.section_2BToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.section_2BToolStripButton.ForeColor = System.Drawing.Color.White;
            this.section_2BToolStripButton.Name = "section_2BToolStripButton";
            this.section_2BToolStripButton.Size = new System.Drawing.Size(146, 36);
            this.section_2BToolStripButton.Text = "Section_2B";
            this.section_2BToolStripButton.Click += new System.EventHandler(this.section_2BToolStripButton_Click);
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
            // firstName_A_and_CToolStrip
            // 
            this.firstName_A_and_CToolStrip.AutoSize = false;
            this.firstName_A_and_CToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(119)))));
            this.firstName_A_and_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.firstName_A_and_CToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.firstName_A_and_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstName_A_and_CToolStripButton});
            this.firstName_A_and_CToolStrip.Location = new System.Drawing.Point(385, 491);
            this.firstName_A_and_CToolStrip.Name = "firstName_A_and_CToolStrip";
            this.firstName_A_and_CToolStrip.Size = new System.Drawing.Size(299, 51);
            this.firstName_A_and_CToolStrip.TabIndex = 9;
            this.firstName_A_and_CToolStrip.Text = "firstName_A_and_CToolStrip";
            // 
            // firstName_A_and_CToolStripButton
            // 
            this.firstName_A_and_CToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(119)))));
            this.firstName_A_and_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.firstName_A_and_CToolStripButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_A_and_CToolStripButton.ForeColor = System.Drawing.Color.White;
            this.firstName_A_and_CToolStripButton.Name = "firstName_A_and_CToolStripButton";
            this.firstName_A_and_CToolStripButton.Size = new System.Drawing.Size(263, 31);
            this.firstName_A_and_CToolStripButton.Text = "FirstName_Consonant";
            this.firstName_A_and_CToolStripButton.Click += new System.EventHandler(this.firstName_A_and_CToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 56);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student\'s Records Monitoring System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(207)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1077, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName_A_and_CToolStrip);
            this.Controls.Add(this.section_2BToolStrip);
            this.Controls.Add(this.lastname_A_and_CToolStrip);
            this.Controls.Add(this.secondYearToolStrip);
            this.Controls.Add(this.balangaToolStrip);
            this.Controls.Add(this.iTToolStrip);
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
            this.iTToolStrip.ResumeLayout(false);
            this.iTToolStrip.PerformLayout();
            this.balangaToolStrip.ResumeLayout(false);
            this.balangaToolStrip.PerformLayout();
            this.secondYearToolStrip.ResumeLayout(false);
            this.secondYearToolStrip.PerformLayout();
            this.lastname_A_and_CToolStrip.ResumeLayout(false);
            this.lastname_A_and_CToolStrip.PerformLayout();
            this.section_2BToolStrip.ResumeLayout(false);
            this.section_2BToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.firstName_A_and_CToolStrip.ResumeLayout(false);
            this.firstName_A_and_CToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStrip iTToolStrip;
        private System.Windows.Forms.ToolStripButton iTToolStripButton;
        private System.Windows.Forms.ToolStrip balangaToolStrip;
        private System.Windows.Forms.ToolStripButton balangaToolStripButton;
        private System.Windows.Forms.ToolStrip secondYearToolStrip;
        private System.Windows.Forms.ToolStripButton secondYearToolStripButton;
        private System.Windows.Forms.ToolStrip lastname_A_and_CToolStrip;
        private System.Windows.Forms.ToolStripButton lastname_A_and_CToolStripButton;
        private System.Windows.Forms.ToolStrip section_2BToolStrip;
        private System.Windows.Forms.ToolStripButton section_2BToolStripButton;
        private System.Windows.Forms.ToolStrip firstName_A_and_CToolStrip;
        private System.Windows.Forms.ToolStripButton firstName_A_and_CToolStripButton;
        private System.Windows.Forms.Label label1;
    }
}

