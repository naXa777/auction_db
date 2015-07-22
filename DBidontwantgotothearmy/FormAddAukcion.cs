using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;*/
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace DBidontwantgotothearmy
{
    public partial class FormAddAukcion : Form
    {
        public FormAddAukcion()
        {
            InitializeComponent();
        }

        private void FormAddAukcion_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Тип_Изделия". При необходимости она может быть перемещена или удалена.
            this.тип_ИзделияTableAdapter.Fill(this.aukcionDBDataSet.Тип_Изделия);
            textBox1.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Функция добавляет новый аукцион
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 256)
                    textBox1.Text = textBox1.Text.Substring(0, 256);
                if (textBox2.Text.Length > 256)
                    textBox2.Text = textBox2.Text.Substring(0, 256);
                if (richTextBox1.Text.Length > 512)
                    richTextBox1.Text = richTextBox1.Text.Substring(0, 512);
                cmdAddAuk.Parameters["@NAME"].Value = textBox1.Text;
                cmdAddAuk.Parameters["@PLACE"].Value = textBox2.Text;
                cmdAddAuk.Parameters["@DESCR"].Value = richTextBox1.Text;
                cmdAddAuk.Parameters["@ST_T"].Value = dateTimePicker1.Text;
                if (dateTimePicker2.Checked)
                    cmdAddAuk.Parameters["@FIN_T"].Value = dateTimePicker2.Text;
                else
                    cmdAddAuk.Parameters["@FIN_T"].Value = "NULL";
//            sqlCmd2.Parameters.Add("@LAST_ID", SqlDbType.Int);
//            sqlCmd2.CommandText = "SET @LAST_ID = IDENT_CURRENT('Аукцион')";

                sqlConnection1.Open();
                cmdAddAuk.ExecuteNonQuery();
                sqlCmd2.ExecuteNonQuery();
                sqlConnection1.Close();

                ListBox.SelectedIndexCollection sic = listBox1.SelectedIndices;
                int ID_A = Convert.ToInt32(sqlCmd2.Parameters["@LAST_ID"].Value);
                String values = "";
                foreach (int i in sic)
                {
                    if (values.Length == 0)
                        values = "(" + ID_A + "," + listBox1.GetItemText(i) + ")";
                    else
                        values += ",(" + ID_A + "," + listBox1.GetItemText(i) + ")";
                }

                sqlCmd2.CommandText = "INSERT INTO Тип_Аукциона VALUES" + values + ";";
                sqlCmd2.Parameters.Remove(sqlCmd2.Parameters["@LAST_ID"]);

                sqlConnection1.Open();
                sqlCmd2.ExecuteNonQuery();
                sqlConnection1.Close();

                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc, "Alarm!");
                //Console.WriteLine(exc);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();// Select(0, textBox1.Text.Length);
        }
    }
}