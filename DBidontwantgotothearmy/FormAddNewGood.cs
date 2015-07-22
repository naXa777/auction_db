using System;
/*using System.Collections.Generic;
using System.ComponentModel;*/
using System.Data;
/*using System.Drawing;
using System.Linq;
using System.Text;*/
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBidontwantgotothearmy
{
    public partial class FormAddNewGood : Form
    {
        public FormAddNewGood()
        {
            InitializeComponent();
        }

        private void FormAddNewGood_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Состояние". При необходимости она может быть перемещена или удалена.
            this.состояниеTableAdapter.Fill(this.aukcionDBDataSet.Состояние);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ListYurFaces". При необходимости она может быть перемещена или удалена.
            listYurFacesTableAdapter.Fill(aukcionDBDataSet.ListYurFaces);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Изделие". При необходимости она может быть перемещена или удалена.
            изделиеTableAdapter.Fill(aukcionDBDataSet.Изделие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Тип_Изделия". При необходимости она может быть перемещена или удалена.
            тип_ИзделияTableAdapter.Fill(aukcionDBDataSet.Тип_Изделия);

            comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tblName = comboBox2.Text;
            tblName = tblName.Replace(' ', '_');
            tblName = tblName.Replace('/', '_');
            sqlDataAdapter1.SelectCommand = new SqlCommand("SELECT TOP 1 * FROM " + tblName, sqlConnection1);
            sqlDataAdapter1.Fill(aukcionDBDataSet);
            int x = aukcionDBDataSet.Tables.IndexOf(tblName);
            dataGridView2.DataSource = aukcionDBDataSet.Tables[x];
            dataGridView2.Columns[0].Visible = false;
            //dataGridView2.Rows.Count = 1;

            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                if (col.DataPropertyName == "Состояние")
                {
                    //col.
                    // как программно изменить тип столбца?
                }

            }
        }

        // Функция добавления нового изделия
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Подготовка первого запроса
                sqlDataAdapter1.InsertCommand =
                    new SqlCommand(
                        "INSERT INTO Изделие VALUES(@Название, @Хозяин, @Тип_Изделия);SET @Новый_ID=SCOPE_IDENTITY();",
                        sqlConnection1);
                sqlDataAdapter1.InsertCommand.Parameters.Add("@Название", SqlDbType.VarChar).Value = textBox1.Text;
                sqlDataAdapter1.InsertCommand.Parameters.Add("@Хозяин", SqlDbType.Int).Value = comboBox1.SelectedValue;
                sqlDataAdapter1.InsertCommand.Parameters.Add("@Тип_Изделия", SqlDbType.Int).Value =
                    comboBox2.SelectedValue;
                // параметр, в который запомним ID
                var pID = new SqlParameter();
                pID.ParameterName = "Новый_ID";
                pID.Size = 4;
                pID.Direction = ParameterDirection.Output;
                sqlDataAdapter1.InsertCommand.Parameters.Add(pID);

                // Первый запрос. Добавление общей информации об Изделии
                int insertedID; // переменная, в которой будет сохранён ID вставленной записи
                sqlConnection1.Open();
                sqlDataAdapter1.InsertCommand.ExecuteNonQuery();
                insertedID = Int32.Parse(pID.Value.ToString());
                sqlConnection1.Close();

                // Второй запрос. Подготовка вставляемых данных
                String content = "";
                int mx = dataGridView2.Columns.Count;
                for (int i = 1; i < mx; ++i)
                {
                    if (dataGridView2.Rows[0].Cells[i].ValueType.Equals(Type.GetType("System.String")))
                        content += "'" + dataGridView2.Rows[0].Cells[i].Value + "'";
                    else if (dataGridView2.Rows[0].Cells[i].Value == null)
                        content += "NULL";
                    else
                        content += dataGridView2.Rows[0].Cells[i].Value;
                    if (i < mx - 1)
                        content += ", ";
                }

                String tblName = comboBox2.Text; // Определяем, в какую таблицу вставить данные
                SqlCommand cmd =
                    new SqlCommand("INSERT INTO " + tblName + " VALUES(" + insertedID + ", " + content + ")",
                                   sqlConnection1);

                // Второй запрос. Добавление детальной информации об изделии
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
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

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}