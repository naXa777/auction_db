namespace DBidontwantgotothearmy
{
    partial class FormStatistics
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоПроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доходыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listAukcions3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aukcionDBDataSet = new DBidontwantgotothearmy.AukcionDBDataSet();
            this.listAukcions3TableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ListAukcions3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAukcions3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn,
            this.местоПроведенияDataGridViewTextBoxColumn,
            this.доходыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listAukcions3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(346, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // местоПроведенияDataGridViewTextBoxColumn
            // 
            this.местоПроведенияDataGridViewTextBoxColumn.DataPropertyName = "Место Проведения";
            this.местоПроведенияDataGridViewTextBoxColumn.HeaderText = "Место Проведения";
            this.местоПроведенияDataGridViewTextBoxColumn.Name = "местоПроведенияDataGridViewTextBoxColumn";
            this.местоПроведенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // доходыDataGridViewTextBoxColumn
            // 
            this.доходыDataGridViewTextBoxColumn.DataPropertyName = "Доходы";
            this.доходыDataGridViewTextBoxColumn.HeaderText = "Доходы";
            this.доходыDataGridViewTextBoxColumn.Name = "доходыDataGridViewTextBoxColumn";
            this.доходыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listAukcions3BindingSource
            // 
            this.listAukcions3BindingSource.DataMember = "ListAukcions3";
            this.listAukcions3BindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // aukcionDBDataSet
            // 
            this.aukcionDBDataSet.DataSetName = "AukcionDBDataSet";
            this.aukcionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listAukcions3TableAdapter
            // 
            this.listAukcions3TableAdapter.ClearBeforeFill = true;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 290);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormStatistics";
            this.Text = "Статистика продаж";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAukcions3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AukcionDBDataSet aukcionDBDataSet;
        private System.Windows.Forms.BindingSource listAukcions3BindingSource;
        private AukcionDBDataSetTableAdapters.ListAukcions3TableAdapter listAukcions3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоПроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn доходыDataGridViewTextBoxColumn;
    }
}