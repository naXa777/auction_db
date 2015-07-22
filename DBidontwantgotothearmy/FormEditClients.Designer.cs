namespace DBidontwantgotothearmy
{
    partial class FormEditClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.N_Паспорта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.полBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aukcionDBDataSet1 = new DBidontwantgotothearmy.AukcionDBDataSet();
            this.адръсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.человекBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aukcionDBDataSet = new DBidontwantgotothearmy.AukcionDBDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID_Фирмы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оПФDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.оПФBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОПредставителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фирмаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.человекTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ЧеловекTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.фирмаTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ФирмаTableAdapter();
            this.полTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ПолTableAdapter();
            this.оПФTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ОПФTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.человекBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оПФBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Паспорта,
            this.фИОDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.адръсDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.человекBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // N_Паспорта
            // 
            this.N_Паспорта.DataPropertyName = "N_Паспорта";
            this.N_Паспорта.HeaderText = "N_Паспорта";
            this.N_Паспорта.Name = "N_Паспорта";
            this.N_Паспорта.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.DataSource = this.полBindingSource;
            this.полDataGridViewTextBoxColumn.DisplayMember = "Буква";
            this.полDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.полDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.полDataGridViewTextBoxColumn.ValueMember = "Буква";
            // 
            // полBindingSource
            // 
            this.полBindingSource.DataMember = "Пол";
            this.полBindingSource.DataSource = this.aukcionDBDataSet1;
            // 
            // aukcionDBDataSet1
            // 
            this.aukcionDBDataSet1.DataSetName = "AukcionDBDataSet";
            this.aukcionDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // адръсDataGridViewTextBoxColumn
            // 
            this.адръсDataGridViewTextBoxColumn.DataPropertyName = "Адръс";
            this.адръсDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адръсDataGridViewTextBoxColumn.Name = "адръсDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            dataGridViewCellStyle5.Format = "###-####";
            dataGridViewCellStyle5.NullValue = null;
            this.телефонDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // человекBindingSource
            // 
            this.человекBindingSource.DataMember = "Человек";
            this.человекBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // aukcionDBDataSet
            // 
            this.aukcionDBDataSet.DataSetName = "AukcionDBDataSet";
            this.aukcionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Фирмы,
            this.оПФDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.фИОПредставителяDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.фирмаBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(572, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(350, 414);
            this.dataGridView2.TabIndex = 1;
            // 
            // ID_Фирмы
            // 
            this.ID_Фирмы.DataPropertyName = "ID_Фирмы";
            dataGridViewCellStyle6.NullValue = "1";
            this.ID_Фирмы.DefaultCellStyle = dataGridViewCellStyle6;
            this.ID_Фирмы.HeaderText = "ID_Фирмы";
            this.ID_Фирмы.Name = "ID_Фирмы";
            this.ID_Фирмы.Visible = false;
            // 
            // оПФDataGridViewTextBoxColumn
            // 
            this.оПФDataGridViewTextBoxColumn.DataPropertyName = "ОПФ";
            this.оПФDataGridViewTextBoxColumn.DataSource = this.оПФBindingSource;
            this.оПФDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.оПФDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.оПФDataGridViewTextBoxColumn.HeaderText = "Организационно-правовая форма";
            this.оПФDataGridViewTextBoxColumn.Name = "оПФDataGridViewTextBoxColumn";
            this.оПФDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.оПФDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.оПФDataGridViewTextBoxColumn.ValueMember = "Название";
            // 
            // оПФBindingSource
            // 
            this.оПФBindingSource.DataMember = "ОПФ";
            this.оПФBindingSource.DataSource = this.aukcionDBDataSet1;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // фИОПредставителяDataGridViewTextBoxColumn
            // 
            this.фИОПредставителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО_Представителя";
            this.фИОПредставителяDataGridViewTextBoxColumn.HeaderText = "ФИО представителя";
            this.фИОПредставителяDataGridViewTextBoxColumn.Name = "фИОПредставителяDataGridViewTextBoxColumn";
            // 
            // фирмаBindingSource
            // 
            this.фирмаBindingSource.DataMember = "Фирма";
            this.фирмаBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // человекTableAdapter
            // 
            this.человекTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Частные лица";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Организации";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(800, 461);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(122, 42);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Применить изменения";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(800, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // фирмаTableAdapter
            // 
            this.фирмаTableAdapter.ClearBeforeFill = true;
            // 
            // полTableAdapter
            // 
            this.полTableAdapter.ClearBeforeFill = true;
            // 
            // оПФTableAdapter
            // 
            this.оПФTableAdapter.ClearBeforeFill = true;
            // 
            // FormEditClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 538);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(713, 237);
            this.Name = "FormEditClients";
            this.Text = "Личные данные клиентов";
            this.Load += new System.EventHandler(this.FormEditClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.человекBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оПФBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фирмаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AukcionDBDataSet aukcionDBDataSet;
        private System.Windows.Forms.BindingSource человекBindingSource;
        private AukcionDBDataSetTableAdapters.ЧеловекTableAdapter человекTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource фирмаBindingSource;
        private AukcionDBDataSetTableAdapters.ФирмаTableAdapter фирмаTableAdapter;
        private AukcionDBDataSet aukcionDBDataSet1;
        private System.Windows.Forms.BindingSource полBindingSource;
        private AukcionDBDataSetTableAdapters.ПолTableAdapter полTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Паспорта;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адръсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource оПФBindingSource;
        private AukcionDBDataSetTableAdapters.ОПФTableAdapter оПФTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Фирмы;
        private System.Windows.Forms.DataGridViewComboBoxColumn оПФDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПредставителяDataGridViewTextBoxColumn;
    }
}