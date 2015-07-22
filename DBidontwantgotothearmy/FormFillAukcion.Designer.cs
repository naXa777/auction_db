namespace DBidontwantgotothearmy
{
    partial class FormFillAukcion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.аукционBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aukcionDBDataSet = new DBidontwantgotothearmy.AukcionDBDataSet();
            this.аукционBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аукционTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.АукционTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.N_Лота = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИзделияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хозяинDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.listYurFacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типИзделияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.типИзделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Покупатель = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.названиеАукционаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Аукциона = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewLotsFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewItemsAndAuksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.хозяинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.типИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.названиеАукционаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDАукционаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlitzPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewItemsAndAuksTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ViewItemsAndAuksTableAdapter();
            this.listYurFacesTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ListYurFacesTableAdapter();
            this.тип_ИзделияTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.Тип_ИзделияTableAdapter();
            this.viewLotsFullTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ViewLotsFullTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.sCmd1 = new System.Data.SqlClient.SqlCommand();
            this.sc1 = new System.Data.SqlClient.SqlConnection();
            this.sCmdDelete = new System.Data.SqlClient.SqlCommand();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.аукционBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аукционBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listYurFacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типИзделияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLotsFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItemsAndAuksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.аукционBindingSource1;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_Аукциона";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // аукционBindingSource1
            // 
            this.аукционBindingSource1.DataMember = "Аукцион";
            this.аукционBindingSource1.DataSource = this.aukcionDBDataSet;
            this.аукционBindingSource1.Filter = "";
            // 
            // aukcionDBDataSet
            // 
            this.aukcionDBDataSet.DataSetName = "AukcionDBDataSet";
            this.aukcionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аукционBindingSource
            // 
            this.аукционBindingSource.DataMember = "Аукцион";
            this.аукционBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // аукционTableAdapter
            // 
            this.аукционTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите аукцион:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Лота,
            this.iDИзделияDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn1,
            this.хозяинDataGridViewTextBoxColumn1,
            this.типИзделияDataGridViewTextBoxColumn1,
            this.Покупатель,
            this.названиеАукционаDataGridViewTextBoxColumn1,
            this.ID_Аукциона});
            this.dataGridView1.DataSource = this.viewLotsFullBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 382);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // N_Лота
            // 
            this.N_Лота.DataPropertyName = "N_Лота";
            this.N_Лота.HeaderText = "№ лота";
            this.N_Лота.Name = "N_Лота";
            this.N_Лота.ReadOnly = true;
            // 
            // iDИзделияDataGridViewTextBoxColumn1
            // 
            this.iDИзделияDataGridViewTextBoxColumn1.DataPropertyName = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn1.HeaderText = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn1.Name = "iDИзделияDataGridViewTextBoxColumn1";
            this.iDИзделияDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDИзделияDataGridViewTextBoxColumn1.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            this.названиеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // хозяинDataGridViewTextBoxColumn1
            // 
            this.хозяинDataGridViewTextBoxColumn1.DataPropertyName = "Хозяин";
            this.хозяинDataGridViewTextBoxColumn1.DataSource = this.listYurFacesBindingSource;
            this.хозяинDataGridViewTextBoxColumn1.DisplayMember = "Имя";
            this.хозяинDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.хозяинDataGridViewTextBoxColumn1.HeaderText = "Хозяин";
            this.хозяинDataGridViewTextBoxColumn1.Name = "хозяинDataGridViewTextBoxColumn1";
            this.хозяинDataGridViewTextBoxColumn1.ReadOnly = true;
            this.хозяинDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.хозяинDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.хозяинDataGridViewTextBoxColumn1.ValueMember = "ID";
            // 
            // listYurFacesBindingSource
            // 
            this.listYurFacesBindingSource.DataMember = "ListYurFaces";
            this.listYurFacesBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // типИзделияDataGridViewTextBoxColumn1
            // 
            this.типИзделияDataGridViewTextBoxColumn1.DataPropertyName = "Тип_Изделия";
            this.типИзделияDataGridViewTextBoxColumn1.DataSource = this.типИзделияBindingSource;
            this.типИзделияDataGridViewTextBoxColumn1.DisplayMember = "Наименование";
            this.типИзделияDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.типИзделияDataGridViewTextBoxColumn1.HeaderText = "Тип изделия";
            this.типИзделияDataGridViewTextBoxColumn1.Name = "типИзделияDataGridViewTextBoxColumn1";
            this.типИзделияDataGridViewTextBoxColumn1.ReadOnly = true;
            this.типИзделияDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.типИзделияDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.типИзделияDataGridViewTextBoxColumn1.ValueMember = "ID_Типа";
            // 
            // типИзделияBindingSource
            // 
            this.типИзделияBindingSource.DataMember = "Тип_Изделия";
            this.типИзделияBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // Покупатель
            // 
            this.Покупатель.DataPropertyName = "Покупатель";
            this.Покупатель.DataSource = this.listYurFacesBindingSource;
            this.Покупатель.DisplayMember = "Имя";
            this.Покупатель.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Покупатель.HeaderText = "Покупатель";
            this.Покупатель.Name = "Покупатель";
            this.Покупатель.ReadOnly = true;
            this.Покупатель.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Покупатель.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Покупатель.ValueMember = "ID";
            // 
            // названиеАукционаDataGridViewTextBoxColumn1
            // 
            this.названиеАукционаDataGridViewTextBoxColumn1.DataPropertyName = "Название аукциона";
            this.названиеАукционаDataGridViewTextBoxColumn1.HeaderText = "Название аукциона";
            this.названиеАукционаDataGridViewTextBoxColumn1.Name = "названиеАукционаDataGridViewTextBoxColumn1";
            this.названиеАукционаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.названиеАукционаDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ID_Аукциона
            // 
            this.ID_Аукциона.DataPropertyName = "ID_Аукциона";
            this.ID_Аукциона.HeaderText = "ID_Аукциона";
            this.ID_Аукциона.Name = "ID_Аукциона";
            this.ID_Аукциона.ReadOnly = true;
            this.ID_Аукциона.Visible = false;
            // 
            // viewLotsFullBindingSource
            // 
            this.viewLotsFullBindingSource.DataMember = "ViewLotsFull";
            this.viewLotsFullBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // viewItemsAndAuksBindingSource
            // 
            this.viewItemsAndAuksBindingSource.DataMember = "ViewItemsAndAuks";
            this.viewItemsAndAuksBindingSource.DataSource = this.aukcionDBDataSet;
            this.viewItemsAndAuksBindingSource.Filter = "ID_Аукциона = 0";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDИзделияDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.хозяинDataGridViewTextBoxColumn,
            this.типИзделияDataGridViewTextBoxColumn,
            this.названиеАукционаDataGridViewTextBoxColumn,
            this.iDАукционаDataGridViewTextBoxColumn,
            this.StartPrice,
            this.BlitzPrice});
            this.dataGridView2.DataSource = this.viewItemsAndAuksBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(676, 36);
            this.dataGridView2.MinimumSize = new System.Drawing.Size(856, 384);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(856, 415);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // iDИзделияDataGridViewTextBoxColumn
            // 
            this.iDИзделияDataGridViewTextBoxColumn.DataPropertyName = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.HeaderText = "ID_Изделия";
            this.iDИзделияDataGridViewTextBoxColumn.Name = "iDИзделияDataGridViewTextBoxColumn";
            this.iDИзделияDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // хозяинDataGridViewTextBoxColumn
            // 
            this.хозяинDataGridViewTextBoxColumn.DataPropertyName = "Хозяин";
            this.хозяинDataGridViewTextBoxColumn.DataSource = this.listYurFacesBindingSource;
            this.хозяинDataGridViewTextBoxColumn.DisplayMember = "Имя";
            this.хозяинDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.хозяинDataGridViewTextBoxColumn.HeaderText = "Хозяин";
            this.хозяинDataGridViewTextBoxColumn.Name = "хозяинDataGridViewTextBoxColumn";
            this.хозяинDataGridViewTextBoxColumn.ReadOnly = true;
            this.хозяинDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.хозяинDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.хозяинDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // типИзделияDataGridViewTextBoxColumn
            // 
            this.типИзделияDataGridViewTextBoxColumn.DataPropertyName = "Тип_Изделия";
            this.типИзделияDataGridViewTextBoxColumn.DataSource = this.типИзделияBindingSource;
            this.типИзделияDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.типИзделияDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.типИзделияDataGridViewTextBoxColumn.HeaderText = "Тип изделия";
            this.типИзделияDataGridViewTextBoxColumn.Name = "типИзделияDataGridViewTextBoxColumn";
            this.типИзделияDataGridViewTextBoxColumn.ReadOnly = true;
            this.типИзделияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.типИзделияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.типИзделияDataGridViewTextBoxColumn.ValueMember = "ID_Типа";
            // 
            // названиеАукционаDataGridViewTextBoxColumn
            // 
            this.названиеАукционаDataGridViewTextBoxColumn.DataPropertyName = "Название аукциона";
            this.названиеАукционаDataGridViewTextBoxColumn.HeaderText = "Название аукциона";
            this.названиеАукционаDataGridViewTextBoxColumn.Name = "названиеАукционаDataGridViewTextBoxColumn";
            this.названиеАукционаDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеАукционаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDАукционаDataGridViewTextBoxColumn
            // 
            this.iDАукционаDataGridViewTextBoxColumn.DataPropertyName = "ID_Аукциона";
            this.iDАукционаDataGridViewTextBoxColumn.HeaderText = "ID_Аукциона";
            this.iDАукционаDataGridViewTextBoxColumn.Name = "iDАукционаDataGridViewTextBoxColumn";
            this.iDАукционаDataGridViewTextBoxColumn.Visible = false;
            // 
            // StartPrice
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.StartPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.StartPrice.HeaderText = "Начальная Цена";
            this.StartPrice.Name = "StartPrice";
            // 
            // BlitzPrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.BlitzPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.BlitzPrice.HeaderText = "Блиц-цена";
            this.BlitzPrice.Name = "BlitzPrice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Предметы, представленные на этом аукционе:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(673, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Свободные предметы:";
            // 
            // viewItemsAndAuksTableAdapter
            // 
            this.viewItemsAndAuksTableAdapter.ClearBeforeFill = true;
            // 
            // listYurFacesTableAdapter
            // 
            this.listYurFacesTableAdapter.ClearBeforeFill = true;
            // 
            // тип_ИзделияTableAdapter
            // 
            this.тип_ИзделияTableAdapter.ClearBeforeFill = true;
            // 
            // viewLotsFullTableAdapter
            // 
            this.viewLotsFullTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.Location = new System.Drawing.Point(567, 144);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(103, 34);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "==>";
            this.toolTip1.SetToolTip(this.btnDel, "Снять лот с аукциона.");
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(567, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "<==";
            this.toolTip1.SetToolTip(this.btnAdd, "Добавить лот на аукцион.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinish.Location = new System.Drawing.Point(949, 465);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(223, 33);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Завершить добавление";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // sCmd1
            // 
            this.sCmd1.CommandText = "AddItem2";
            this.sCmd1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sCmd1.Connection = this.sc1;
            this.sCmd1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID_A", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@ID_I", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@START_PRICE", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@BLITZ_PRICE", System.Data.SqlDbType.Real, 4)});
            // 
            // sc1
            // 
            this.sc1.ConnectionString = "Data Source=.\\SqlExpress;Initial Catalog=AukcionDB;Integrated Security=True";
            this.sc1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sCmdDelete
            // 
            this.sCmdDelete.CommandText = "DELETE FROM Лот\r\n WHERE N_Лота=@LotN AND ID_Аукциона=@ID_A";
            this.sCmdDelete.Connection = this.sc1;
            this.sCmdDelete.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LotN", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N_Лота", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ID_A", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID_Аукциона", System.Data.DataRowVersion.Original, null)});
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1215, 25);
            this.fillBy1ToolStrip.TabIndex = 9;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // FormFillAukcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 510);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormFillAukcion";
            this.Text = "Управление товарами на аукционе";
            this.Load += new System.EventHandler(this.FormFillAukcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аукционBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аукционBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listYurFacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типИзделияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLotsFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItemsAndAuksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private AukcionDBDataSet aukcionDBDataSet;
        private System.Windows.Forms.BindingSource аукционBindingSource;
        private AukcionDBDataSetTableAdapters.АукционTableAdapter аукционTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource viewItemsAndAuksBindingSource;
        private AukcionDBDataSetTableAdapters.ViewItemsAndAuksTableAdapter viewItemsAndAuksTableAdapter;
        private System.Windows.Forms.BindingSource listYurFacesBindingSource;
        private AukcionDBDataSetTableAdapters.ListYurFacesTableAdapter listYurFacesTableAdapter;
        private System.Windows.Forms.BindingSource типИзделияBindingSource;
        private AukcionDBDataSetTableAdapters.Тип_ИзделияTableAdapter тип_ИзделияTableAdapter;
        private System.Windows.Forms.BindingSource viewLotsFullBindingSource;
        private AukcionDBDataSetTableAdapters.ViewLotsFullTableAdapter viewLotsFullTableAdapter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFinish;
        private System.Data.SqlClient.SqlCommand sCmd1;
        private System.Data.SqlClient.SqlConnection sc1;
        private System.Data.SqlClient.SqlCommand sCmdDelete;
        private System.Windows.Forms.BindingSource аукционBindingSource1;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn хозяинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn типИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеАукционаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАукционаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlitzPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Лота;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИзделияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn хозяинDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn типИзделияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Покупатель;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеАукционаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Аукциона;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}