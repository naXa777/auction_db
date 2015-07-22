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
    public partial class FormStatistics2 : Form
    {
        public FormStatistics2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                    // Null Reference
                listBuyers7TableAdapter.Adapter.SelectCommand.Parameters["@D1"].Value = dateTimePicker1.Value;
                listSellers6TableAdapter.Adapter.SelectCommand.Parameters["@D1"].Value = dateTimePicker1.Value;
                listBuyers7TableAdapter.Adapter.SelectCommand.Parameters["@D2"].Value = dateTimePicker2.Value;
                listSellers6TableAdapter.Adapter.SelectCommand.Parameters["@D2"].Value = dateTimePicker2.Value;

                listBuyers7TableAdapter.Connection.Open();
                listBuyers7TableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                listBuyers7TableAdapter.Connection.Close();
                listSellers6TableAdapter.Connection.Open();
                listSellers6TableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                listSellers6TableAdapter.Connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc);
            }
            finally
            {
                if (listBuyers7TableAdapter.Connection.State == ConnectionState.Open)
                    listBuyers7TableAdapter.Connection.Close();
                if (listSellers6TableAdapter.Connection.State == ConnectionState.Open)
                    listSellers6TableAdapter.Connection.Close();
            }
        }
    }
}