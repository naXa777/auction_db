namespace DBidontwantgotothearmy
{
    partial class FormSellItem
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.аукционBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aukcionDBDataSet = new DBidontwantgotothearmy.AukcionDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.аукционTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.АукционTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.viewLotsFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewLotsFullTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ViewLotsFullTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listYurFacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listYurFacesTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.ListYurFacesTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdSell = new System.Data.SqlClient.SqlCommand();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.аукционBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLotsFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listYurFacesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.аукционBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_Аукциона";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // аукционBindingSource
            // 
            this.аукционBindingSource.DataMember = "Аукцион";
            this.аукционBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // aukcionDBDataSet
            // 
            this.aukcionDBDataSet.DataSetName = "AukcionDBDataSet";
            this.aukcionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "На аукционе";
            // 
            // аукционTableAdapter
            // 
            this.аукционTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.DataSource = this.viewLotsFullBindingSource;
            this.listBox1.DisplayMember = "Название";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(111, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 160);
            this.listBox1.TabIndex = 4;
            this.listBox1.ValueMember = "N_Лота";
            // 
            // viewLotsFullBindingSource
            // 
            this.viewLotsFullBindingSource.DataMember = "ViewLotsFull";
            this.viewLotsFullBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // viewLotsFullTableAdapter
            // 
            this.viewLotsFullTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "предмет";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "был продан";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "за сумму в ";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.DataSource = this.listYurFacesBindingSource;
            this.comboBox2.DisplayMember = "Имя";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 245);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "ID";
            // 
            // listYurFacesBindingSource
            // 
            this.listYurFacesBindingSource.DataMember = "ListYurFaces";
            this.listYurFacesBindingSource.DataSource = this.aukcionDBDataSet;
            // 
            // listYurFacesTableAdapter
            // 
            this.listYurFacesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(111, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "р.";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(486, 303);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(49, 45);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(322, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 27);
            this.button2.TabIndex = 12;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\SqlExpress;Initial Catalog=AukcionDB;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdSell
            // 
            this.sqlCmdSell.CommandText = "SellItem5";
            this.sqlCmdSell.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCmdSell.Connection = this.sqlConnection1;
            this.sqlCmdSell.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID_A", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@N_L", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@ID_P", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@COST", System.Data.SqlDbType.Real, 4),
            new System.Data.SqlClient.SqlParameter("@ADDIT_INFO", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(304, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(231, 234);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Пожелания по доставке (необязательно)";
            // 
            // FormSellItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 363);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(524, 280);
            this.Name = "FormSellItem";
            this.Text = "Оформление продажи лота";
            this.Load += new System.EventHandler(this.FormSellItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.аукционBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLotsFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listYurFacesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private AukcionDBDataSet aukcionDBDataSet;
        private System.Windows.Forms.BindingSource аукционBindingSource;
        private AukcionDBDataSetTableAdapters.АукционTableAdapter аукционTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource viewLotsFullBindingSource;
        private AukcionDBDataSetTableAdapters.ViewLotsFullTableAdapter viewLotsFullTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource listYurFacesBindingSource;
        private AukcionDBDataSetTableAdapters.ListYurFacesTableAdapter listYurFacesTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCmdSell;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
    }
}