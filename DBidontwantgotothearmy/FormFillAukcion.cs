using System;
/*using System.Collections.Generic;
using System.ComponentModel;*/
using System.Data;
using System.Data.SqlClient;
/*using System.Drawing;
using System.Linq;
using System.Text;*/
using System.Windows.Forms;

namespace DBidontwantgotothearmy
{
    public partial class FormFillAukcion : Form
    {
        public FormFillAukcion()
        {
            InitializeComponent();
        }

        private void FormFillAukcion_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ViewLotsFull". При необходимости она может быть перемещена или удалена.
                this.viewLotsFullTableAdapter.Fill(this.aukcionDBDataSet.ViewLotsFull);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Тип_Изделия". При необходимости она может быть перемещена или удалена.
                this.тип_ИзделияTableAdapter.Fill(this.aukcionDBDataSet.Тип_Изделия);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ListYurFaces". При необходимости она может быть перемещена или удалена.
                this.listYurFacesTableAdapter.Fill(this.aukcionDBDataSet.ListYurFaces);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ViewItemsAndAuks". При необходимости она может быть перемещена или удалена.
                this.viewItemsAndAuksTableAdapter.Fill(this.aukcionDBDataSet.ViewItemsAndAuks);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Аукцион". При необходимости она может быть перемещена или удалена.
                this.аукционTableAdapter.Fill(this.aukcionDBDataSet.Аукцион);
                //viewItemsAndAuksBindingSource.Filter = "ID_Аукциона = " + 0;
                viewLotsFullBindingSource.Filter = "ID_Аукциона = " + comboBox1.SelectedValue;
                //аукционBindingSource1.Filter = "Время_Окончания < GetDate()'";
                fillBy1ToolStripButton.PerformClick();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Отсутствует подключение к базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exc.StackTrace);
            }
        }

        // Функция снимает лот с аукциона
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                // Аукцион и № лота однозначно определяют то, что нам нужно удалить
                sCmdDelete.Parameters["@LotN"].Value = dataGridView1.CurrentRow.Cells["N_Лота"].Value;
                sCmdDelete.Parameters["@ID_A"].Value = dataGridView1.CurrentRow.Cells["ID_Аукциона"].Value;

                // Удаляем лот
                sc1.Open();
                sCmdDelete.ExecuteNonQuery();
                sc1.Close();

                // Обновляем данные в Таблицах
                viewLotsFullTableAdapter.Fill(aukcionDBDataSet.ViewLotsFull);
                viewItemsAndAuksTableAdapter.Fill(aukcionDBDataSet.ViewItemsAndAuks);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc, "Alarm!");
                //Console.WriteLine(exc);
            }
            finally
            {
                sc1.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int x = dataGridView2.CurrentRow.Index;
            Double startPrice = 0,
                   blitzPrice = 0;

            try
            {
                // Узнаём начальную цену
                startPrice = Convert.ToDouble(dataGridView2.CurrentRow.Cells["StartPrice"].Value);
                blitzPrice = Convert.ToDouble(dataGridView2.CurrentRow.Cells["BlitzPrice"].Value);
                if (startPrice <= 0)
                    MessageBox.Show("Ошибка! Укажите верную начальную цену!");
                else
                {
                    // Подготавливаем данные о добавляемом на аукцион изделии
                    sCmd1.Parameters["@ID_A"].Value = comboBox1.SelectedValue;
                    sCmd1.Parameters["@ID_I"].Value = dataGridView2.CurrentRow.Cells[0].Value;  // столбец ID_Изделия
                    if (blitzPrice < startPrice)
                        sCmd1.Parameters["@BLITZ_PRICE"].Value = null;
                    else
                        sCmd1.Parameters["@BLITZ_PRICE"].Value = blitzPrice;
                    sCmd1.Parameters["@START_PRICE"].Value = startPrice;

                    // Вызываем функцию добавления лота
                    sc1.Open();
                    sCmd1.ExecuteNonQuery();
                    sc1.Close();

                    // Обновляем данные в таблицах
                    viewLotsFullTableAdapter.Fill(aukcionDBDataSet.ViewLotsFull);
                    viewItemsAndAuksTableAdapter.Fill(aukcionDBDataSet.ViewItemsAndAuks);
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Начальная цена должна быть числом. Ошибка: " + exc, "Alarm!");
            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show("Вы ничего не выбрали во второй таблице. Ошибка: " + exc, "Alarm!");
            }
            catch (Exception exc2)
            {
                MessageBox.Show("Ошибка: " + exc2, "Alarm!");
            }
            finally {
                    // если исключение вылетело во время подключения к БД, соединение останется открытым;
                    // значит его нужно закрыть, чтобы программа могла работать дальше
                if (sc1.State != ConnectionState.Closed)
                    sc1.Close();
            }
            // if ()
            // try parse СтартЦена в число
            // отказ или продолжить
            // вызвать cmd1 через sc1
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && comboBox1.SelectedValue.ToString() != "")
                viewLotsFullBindingSource.Filter = "ID_Аукциона = " + comboBox1.SelectedValue;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                btnDel.Enabled = true;
            else
                btnDel.Enabled = false;
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                аукционTableAdapter.FillBy1(this.aukcionDBDataSet.Аукцион);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }
    }
}
