using System;
/*using System.Collections.Generic;
using System.ComponentModel;*/
using System.Data;
/*using System.Drawing;
using System.Linq;
using System.Text;*/
using System.Windows.Forms;

namespace DBidontwantgotothearmy
{
    public partial class FormSellItem : Form
    {
        public FormSellItem()
        {
            InitializeComponent();
        }

        private void FormSellItem_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ListYurFaces". При необходимости она может быть перемещена или удалена.
            this.listYurFacesTableAdapter.Fill(this.aukcionDBDataSet.ListYurFaces);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ViewLotsFull". При необходимости она может быть перемещена или удалена.
            this.viewLotsFullTableAdapter.Fill(this.aukcionDBDataSet.ViewLotsFull);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Аукцион". При необходимости она может быть перемещена или удалена.
            this.аукционTableAdapter.Fill(this.aukcionDBDataSet.Аукцион);
            viewLotsFullBindingSource.Filter = "(ID_Аукциона = " + comboBox1.SelectedValue + ")";//+ " AND (Покупатель = NULL)";
            //listYurFacesBindingSource.Filter = "ID != " + comboBox1.SelectedValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price;
            if (!Int32.TryParse(textBox1.Text, out price))
            {
                MessageBox.Show("Укажите верную цену.", "Оформление прервано.");
                return;
            }

            try
            {
                sqlCmdSell.Parameters["@ID_A"].Value = comboBox1.SelectedValue;
                sqlCmdSell.Parameters["@ID_P"].Value = comboBox2.SelectedValue;
                sqlCmdSell.Parameters["@N_L"].Value  = listBox1.SelectedValue;
                sqlCmdSell.Parameters["@COST"].Value = price;
                sqlCmdSell.Parameters["@ADDIT_INFO"].Value = richTextBox1.Text;

                sqlConnection1.Open();
                sqlCmdSell.ExecuteNonQuery();
                sqlConnection1.Close();

                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc);
            }
            finally
            {
                if (sqlConnection1.State == ConnectionState.Open)
                    sqlConnection1.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewLotsFullBindingSource.Filter = "(ID_Аукциона = " + comboBox1.SelectedValue + ")";//+ " AND (Покупатель = NULL)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}