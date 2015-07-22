using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;*/
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBidontwantgotothearmy
{
    public partial class FormGoods : Form
    {
        public FormGoods()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ListYurFaces". При необходимости она может быть перемещена или удалена.
            this.listYurFacesTableAdapter.Fill(this.aukcionDBDataSet.ListYurFaces);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Тип_Изделия". При необходимости она может быть перемещена или удалена.
            this.тип_ИзделияTableAdapter.Fill(this.aukcionDBDataSet.Тип_Изделия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ViewItemsAndAuks". При необходимости она может быть перемещена или удалена.
            this.viewItemsAndAuksTableAdapter.Fill(this.aukcionDBDataSet.ViewItemsAndAuks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ViewItemsAndAuks". При необходимости она может быть перемещена или удалена.
            this.viewItemsAndAuksTableAdapter.Fill(this.aukcionDBDataSet.ViewItemsAndAuks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Аукцион". При необходимости она может быть перемещена или удалена.
            //comboBox1.Items.Add("Все аукционы");
            this.аукционTableAdapter.Fill(this.aukcionDBDataSet.Аукцион);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Изделие". При необходимости она может быть перемещена или удалена.
            //this.изделиеTableAdapter.Fill(this.aukcionDBDataSet.Изделие);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddNewGood fang = new FormAddNewGood();
            fang.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewItemsAndAuksBindingSource.Filter = "[Название аукциона] LIKE '" + comboBox1.Text + "'";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox1.Enabled = true;
                viewItemsAndAuksBindingSource.Filter = "[Название аукциона] LIKE '" + comboBox1.Text + "'";
            }
            else
            {
                comboBox1.Enabled = false;
                viewItemsAndAuksBindingSource.Filter = "";
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                comboBox1.Enabled = false;
                viewItemsAndAuksBindingSource.Filter = "[Название аукциона] LIKE '-'";
            }
            else
                viewItemsAndAuksBindingSource.Filter = "";
            
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            /*if ((e.RowIndex < 0) || (dataGridView1.Rows.Count == 0))
                return;
            e.*/

            /*String IDs = "(";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (src.Contains(dataGridView1.Rows[i + 1]))
                {
                    IDs += dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (i + 1 != dataGridView1.Rows.Count)
                        IDs += ", ";
                }
                if (i + 1 == dataGridView1.Rows.Count)
                    IDs += ")";}*/
            if (e.Row.Cells[0].Value.ToString().Equals("-"))
            {
                MessageBox.Show("Это изделие сейчас выставлено на аукцион. Его нельзя удалить до завершения торгов.");
            } else
                try
                {
                
                    String sacrifice = e.Row.Cells[0].Value.ToString();
                    sda1.DeleteCommand = new SqlCommand("DELETE FROM Изделие WHERE ID_Изделия=" + sacrifice, sc1);

                    sc1.Open();
                    sda1.DeleteCommand.ExecuteNonQuery();
                
                    sc1.Close();
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            dataGridView1_UserDeletingRow(sender, new DataGridViewRowCancelEventArgs(dataGridView1.CurrentRow));
        }
    }
}