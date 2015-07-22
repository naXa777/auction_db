namespace DBidontwantgotothearmy
{
    partial class FormAddNewGood
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.типИзделияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aukcionDBDataSet = new DBidontwantgotothearmy.AukcionDBDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.изделиеTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ИзделиеTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listYurFacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.тип_ИзделияTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.Тип_ИзделияTableAdapter();
            this.изделиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listYurFacesTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ListYurFacesTableAdapter();
            this.состояниеbindingSrc = new System.Windows.Forms.BindingSource(this.components);
            this.состояниеTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.СостояниеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.типИзделияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listYurFacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.состояниеbindingSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Тип товара";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DataSource = this.типИзделияBindingSource;
            this.comboBox2.DisplayMember = "Наименование";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(551, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "ID_Типа";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // типИзделияBindingSource
            // 
            this.типИзделияBindingSource.DataMember = "Тип_Изделия";
            this.типИзделияBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // aukcionDBDataSet
            // 
            this.aukcionDBDataSet.DataSetName = "AukcionDBDataSet";
            this.aukcionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 129);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(732, 79);
            this.dataGridView2.TabIndex = 12;
            // 
            // изделиеTableAdapter
            // 
            this.изделиеTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.listYurFacesBindingSource;
            this.comboBox1.DisplayMember = "Имя";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(551, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "ID";
            // 
            // listYurFacesBindingSource
            // 
            this.listYurFacesBindingSource.DataMember = "ListYurFaces";
            this.listYurFacesBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(551, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Владелец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Прочие свойства";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(632, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(632, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\SqlExpress;Initial Catalog=AukcionDB;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // тип_ИзделияTableAdapter
            // 
            this.тип_ИзделияTableAdapter.ClearBeforeFill = true;
            // 
            // изделиеBindingSource
            // 
            this.изделиеBindingSource.DataMember = "Изделие";
            this.изделиеBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // listYurFacesTableAdapter
            // 
            this.listYurFacesTableAdapter.ClearBeforeFill = true;
            // 
            // состояниеbindingSrc
            // 
            this.состояниеbindingSrc.DataMember = "Состояние";
            this.состояниеbindingSrc.DataSource = this.aukcionDBDataSet;
            // 
            // состояниеTableAdapter
            // 
            this.состояниеTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddNewGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.MinimumSize = new System.Drawing.Size(300, 310);
            this.Name = "FormAddNewGood";
            this.Text = "Добавление нового товара";
            this.Load += new System.EventHandler(this.FormAddNewGood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.типИзделияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listYurFacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.состояниеbindingSrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private AukcionDBDataSet aukcionDBDataSet;
        private System.Windows.Forms.BindingSource типИзделияBindingSource;
        private AukcionDBDataSetTableAdapters.Тип_ИзделияTableAdapter тип_ИзделияTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource изделиеBindingSource;
        private AukcionDBDataSetTableAdapters.ИзделиеTableAdapter изделиеTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource listYurFacesBindingSource;
        private AukcionDBDataSetTableAdapters.ListYurFacesTableAdapter listYurFacesTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.BindingSource состояниеbindingSrc;
        private AukcionDBDataSetTableAdapters.СостояниеTableAdapter состояниеTableAdapter;
    }
}