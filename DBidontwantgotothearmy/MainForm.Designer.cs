namespace DBidontwantgotothearmy
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информационнаяСистемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.действияСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьНовыйАукционToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьАукционToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеИнформацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСтатистикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьСделкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDАукционаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоПроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.краткоеОписаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аукционBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aukcionDBDataSet = new DBidontwantgotothearmy.AukcionDBDataSet();
            this.аукционTableAdapter = new DBidontwantgotothearmy.AukcionDBDataSetTableAdapters.АукционTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аукционBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информационнаяСистемаToolStripMenuItem,
            this.действияСБДToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // информационнаяСистемаToolStripMenuItem
            // 
            this.информационнаяСистемаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.информационнаяСистемаToolStripMenuItem.Name = "информационнаяСистемаToolStripMenuItem";
            this.информационнаяСистемаToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.информационнаяСистемаToolStripMenuItem.Text = "&Информ. система";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItem2.Text = "Статистика по клиентам";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItem4.Text = "Статистика по аукционам";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // действияСБДToolStripMenuItem
            // 
            this.действияСБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьНовыйАукционToolStripMenuItem,
            this.редактироватьИнформациюToolStripMenuItem,
            this.добавитьТоварыToolStripMenuItem,
            this.завершитьАукционToolStripMenuItem,
            this.вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem});
            this.действияСБДToolStripMenuItem.Name = "действияСБДToolStripMenuItem";
            this.действияСБДToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.действияСБДToolStripMenuItem.Text = "&Аукционы";
            this.действияСБДToolStripMenuItem.Click += new System.EventHandler(this.действияСБДToolStripMenuItem_Click);
            // 
            // начатьНовыйАукционToolStripMenuItem
            // 
            this.начатьНовыйАукционToolStripMenuItem.Name = "начатьНовыйАукционToolStripMenuItem";
            this.начатьНовыйАукционToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.начатьНовыйАукционToolStripMenuItem.Text = "Начать новый";
            this.начатьНовыйАукционToolStripMenuItem.Click += new System.EventHandler(this.начатьНовыйАукционToolStripMenuItem_Click);
            // 
            // редактироватьИнформациюToolStripMenuItem
            // 
            this.редактироватьИнформациюToolStripMenuItem.Name = "редактироватьИнформациюToolStripMenuItem";
            this.редактироватьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.редактироватьИнформациюToolStripMenuItem.Text = "Редактировать информацию";
            this.редактироватьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.редактироватьИнформациюToolStripMenuItem_Click);
            // 
            // добавитьТоварыToolStripMenuItem
            // 
            this.добавитьТоварыToolStripMenuItem.Name = "добавитьТоварыToolStripMenuItem";
            this.добавитьТоварыToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.добавитьТоварыToolStripMenuItem.Text = "Управление аукционом";
            this.добавитьТоварыToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварыToolStripMenuItem_Click);
            // 
            // завершитьАукционToolStripMenuItem
            // 
            this.завершитьАукционToolStripMenuItem.Enabled = false;
            this.завершитьАукционToolStripMenuItem.Name = "завершитьАукционToolStripMenuItem";
            this.завершитьАукционToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.завершитьАукционToolStripMenuItem.Text = "Завершить";
            // 
            // вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem
            // 
            this.вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem.Name = "вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem";
            this.вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem.Text = "Статистика продаж на аукционах";
            this.вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem.Click += new System.EventHandler(this.вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеИнформацииToolStripMenuItem,
            this.просмотрСтатистикиToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "&Клиенты";
            // 
            // редактированиеИнформацииToolStripMenuItem
            // 
            this.редактированиеИнформацииToolStripMenuItem.Name = "редактированиеИнформацииToolStripMenuItem";
            this.редактированиеИнформацииToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.редактированиеИнформацииToolStripMenuItem.Text = "Регистр клиентов";
            this.редактированиеИнформацииToolStripMenuItem.Click += new System.EventHandler(this.редактированиеИнформацииToolStripMenuItem_Click);
            // 
            // просмотрСтатистикиToolStripMenuItem
            // 
            this.просмотрСтатистикиToolStripMenuItem.Enabled = false;
            this.просмотрСтатистикиToolStripMenuItem.Name = "просмотрСтатистикиToolStripMenuItem";
            this.просмотрСтатистикиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.просмотрСтатистикиToolStripMenuItem.Text = "Просмотр статистики";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеToolStripMenuItem,
            this.оформитьСделкуToolStripMenuItem});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.товарыToolStripMenuItem.Text = "&Товары";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.редактированиеToolStripMenuItem.Text = "Редактировать список товаров";
            this.редактированиеToolStripMenuItem.Click += new System.EventHandler(this.редактированиеToolStripMenuItem_Click);
            // 
            // оформитьСделкуToolStripMenuItem
            // 
            this.оформитьСделкуToolStripMenuItem.Name = "оформитьСделкуToolStripMenuItem";
            this.оформитьСделкуToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.оформитьСделкуToolStripMenuItem.Text = "Оформить сделку";
            this.оформитьСделкуToolStripMenuItem.Click += new System.EventHandler(this.оформитьСделкуToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "&Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАукционаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.местоПроведенияDataGridViewTextBoxColumn,
            this.краткоеОписаниеDataGridViewTextBoxColumn,
            this.времяНачалаDataGridViewTextBoxColumn,
            this.времяОкончанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.аукционBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(592, 332);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDАукционаDataGridViewTextBoxColumn
            // 
            this.iDАукционаDataGridViewTextBoxColumn.DataPropertyName = "ID_Аукциона";
            this.iDАукционаDataGridViewTextBoxColumn.HeaderText = "ID_Аукциона";
            this.iDАукционаDataGridViewTextBoxColumn.Name = "iDАукционаDataGridViewTextBoxColumn";
            this.iDАукционаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDАукционаDataGridViewTextBoxColumn.Visible = false;
            this.iDАукционаDataGridViewTextBoxColumn.Width = 97;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn.Width = 82;
            // 
            // местоПроведенияDataGridViewTextBoxColumn
            // 
            this.местоПроведенияDataGridViewTextBoxColumn.DataPropertyName = "Место_Проведения";
            this.местоПроведенияDataGridViewTextBoxColumn.HeaderText = "Место проведения";
            this.местоПроведенияDataGridViewTextBoxColumn.Name = "местоПроведенияDataGridViewTextBoxColumn";
            this.местоПроведенияDataGridViewTextBoxColumn.ReadOnly = true;
            this.местоПроведенияDataGridViewTextBoxColumn.Width = 116;
            // 
            // краткоеОписаниеDataGridViewTextBoxColumn
            // 
            this.краткоеОписаниеDataGridViewTextBoxColumn.DataPropertyName = "Краткое_Описание";
            this.краткоеОписаниеDataGridViewTextBoxColumn.HeaderText = "Краткое описание";
            this.краткоеОписаниеDataGridViewTextBoxColumn.Name = "краткоеОписаниеDataGridViewTextBoxColumn";
            this.краткоеОписаниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.краткоеОписаниеDataGridViewTextBoxColumn.Width = 114;
            // 
            // времяНачалаDataGridViewTextBoxColumn
            // 
            this.времяНачалаDataGridViewTextBoxColumn.DataPropertyName = "Время_Начала";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.времяНачалаDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.времяНачалаDataGridViewTextBoxColumn.HeaderText = "Время начала";
            this.времяНачалаDataGridViewTextBoxColumn.Name = "времяНачалаDataGridViewTextBoxColumn";
            this.времяНачалаDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяНачалаDataGridViewTextBoxColumn.Width = 95;
            // 
            // времяОкончанияDataGridViewTextBoxColumn
            // 
            this.времяОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Время_Окончания";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = "[не обозначено]";
            this.времяОкончанияDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.времяОкончанияDataGridViewTextBoxColumn.HeaderText = "Время окончания";
            this.времяОкончанияDataGridViewTextBoxColumn.Name = "времяОкончанияDataGridViewTextBoxColumn";
            this.времяОкончанияDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяОкончанияDataGridViewTextBoxColumn.Width = 111;
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
            // аукционTableAdapter
            // 
            this.аукционTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Информационная система фирмы, проводящей аукционы";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аукционBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcionDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьНовыйАукционToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьАукционToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеИнформацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСтатистикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьСделкуToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private AukcionDBDataSet aukcionDBDataSet;
        private System.Windows.Forms.BindingSource аукционBindingSource;
        private AukcionDBDataSetTableAdapters.АукционTableAdapter аукционTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАукционаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоПроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn краткоеОписаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem информационнаяСистемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

