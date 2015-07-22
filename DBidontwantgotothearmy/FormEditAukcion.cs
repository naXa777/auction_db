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
    public partial class FormEditAukcion : Form
    {
        SqlDataAdapter sda = new SqlDataAdapter();

        public FormEditAukcion()
        {
            InitializeComponent();
        }

        private void FormEditAukcion_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Аукцион". При необходимости она может быть перемещена или удалена.
            аукционTableAdapter.Fill(aukcionDBDataSet.Аукцион);

    /*        sda.SelectCommand = new SqlCommand("SELECT DISTINCT * FROM Аукцион");
            sda.Fill(aukcionDBDataSet.Аукцион);
            comboBox1.DataSource = sda;
            comboBox1.ValueMember = "Место_Проведения";
            comboBox1.DisplayMember = "Место_Проведения";*/
            // Должна быть загрузка городов в combobox
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            try
            {
                Validate();
                аукционBindingSource.EndEdit();
                аукционTableAdapter.Update(aukcionDBDataSet.Аукцион);

                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc, "Alarm!");
                //Console.WriteLine(exc);
            }


            /*SqlConnection conn = new SqlConnection("Data Source=.\\SqlExpress;Initial Catalog=AukcionDB;Integrated Security=True"); 
            SqlCommand comm = new SqlCommand("UPDATE Аукцион SET Название = @par1, Место_Проведения = @par2, Краткое_Описание = @par3, Время_Начала = @par4, Время_Окончания = @par5 WHERE ID_Аукциона=@parID", conn);
            comm.Parameters.Add("@par1", SqlDbType.VarChar).SourceColumn = "Название"; 
            comm.Parameters.Add("@par2", SqlDbType.VarChar).SourceColumn = "Место_Проведения"; 
            comm.Parameters.Add("@par3", SqlDbType.VarChar).SourceColumn = "Краткое_Описание"; 
            comm.Parameters.Add("@par4", SqlDbType.DateTime).SourceColumn = "Время_Начала";  
            comm.Parameters.Add("@par5", SqlDbType.DateTime).SourceColumn = "Время_Окончания";
            comm.Parameters.Add("@parID", SqlDbType.Int).SourceColumn = "ID_Аукциона";

            SqlCommand comm2 = new SqlCommand("INSERT INTO Аукцион VALUES(@par1, @par2, @par3, @par4, @par5", conn);
            comm.Parameters.Add("@par1", SqlDbType.VarChar).SourceColumn = "Название";
            comm.Parameters.Add("@par2", SqlDbType.VarChar).SourceColumn = "Место_Проведения";
            comm.Parameters.Add("@par3", SqlDbType.VarChar).SourceColumn = "Краткое_Описание";
            comm.Parameters.Add("@par4", SqlDbType.DateTime).SourceColumn = "Время_Начала";
            comm.Parameters.Add("@par5", SqlDbType.DateTime).SourceColumn = "Время_Окончания";

            SqlCommand comm3 = new SqlCommand("DELETE FROM Аукцион WHERE ID_Аукциона = @parID", conn);
            comm.Parameters.Add("@parID", SqlDbType.Int).SourceColumn = "ID_Аукциона";

            SqlDataAdapter ad = new SqlDataAdapter();
            аукционTableAdapter.Adapter.UpdateCommand = comm;
            аукционTableAdapter.Adapter.InsertCommand = comm2;*/
//          аукционTableAdapter.Adapter.Update(aukcionDBDataSet.Аукцион);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            аукционBindingSource.Filter = "Дата_Окончания = NULL OR Дата_Окончания >= GETDATE()";
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox1.Enabled = true;
                аукционBindingSource.Filter = "Место_Проведения LIKE '" + comboBox1.SelectedValue + "'";
            }
            else
            {
                аукционBindingSource.Filter = "";
                comboBox1.Enabled = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            аукционBindingSource.Filter = "Место_Проведения LIKE '" + comboBox1.SelectedValue + "'";
        }
    }
}