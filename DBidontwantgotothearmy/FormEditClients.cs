using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;*/
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBidontwantgotothearmy.Properties;

namespace DBidontwantgotothearmy
{
    public partial class FormEditClients : Form
    {
        SqlConnection sc1;

        public FormEditClients()
        {
            InitializeComponent();
        }

        private void FormEditClients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet1.ОПФ". При необходимости она может быть перемещена или удалена.
            this.оПФTableAdapter.Fill(this.aukcionDBDataSet1.ОПФ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet1.Пол". При необходимости она может быть перемещена или удалена.
            this.полTableAdapter.Fill(this.aukcionDBDataSet1.Пол);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Фирма". При необходимости она может быть перемещена или удалена.
            фирмаTableAdapter.Fill(aukcionDBDataSet.Фирма);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Человек". При необходимости она может быть перемещена или удалена.
            человекTableAdapter.Fill(aukcionDBDataSet.Человек);

            try
            {
                человекTableAdapter.Adapter.InsertCommand.CommandText =
                    "EXEC AddPerson11 @ФИО, @Пол, @Адръс, @Телефон, @Дата_Рождения";
                фирмаTableAdapter.Adapter.InsertCommand.CommandText =
                    "EXEC AddFirm12 @ОПФ, @Название, @ФИО_Представителя";
                
                sc1 = человекTableAdapter.Adapter.InsertCommand.Connection;
                
                человекTableAdapter.Adapter.DeleteCommand =
                    new SqlCommand("DELETE FROM Юридическое_Лицо WHERE ID_Лица=@N_Паспорта", sc1);
                человекTableAdapter.Adapter.DeleteCommand.Parameters.Add("@N_Паспорта", SqlDbType.Int, 4, "N_Паспорта");
                фирмаTableAdapter.Adapter.DeleteCommand = new SqlCommand("DELETE FROM Юридическое_Лицо WHERE ID_Лица=@ID_Фирмы", sc1);
                фирмаTableAdapter.Adapter.DeleteCommand.Parameters.Add("@ID_Фирмы", SqlDbType.Int, 4, "ID_Фирмы");


                человекTableAdapter.Adapter.UpdateCommand = new SqlCommand(
                        "UPDATE Человек SET ФИО=@ФИО, Пол=@Пол, Адръс=@Адръс, Телефон=@Телефон, Дата_Рождения=@Дата_Рождения WHERE N_Паспорта=@N_Паспорта", sc1);
                фирмаTableAdapter.Adapter.UpdateCommand = new SqlCommand(
                        "UPDATE Фирма SET ОПФ=@ОПФ, Название=@Название, ФИО_Представителя=@ФИО_Представителя WHERE ID_Фирмы=@ID_Фирмы", sc1);

                String parName, column;
                SqlDbType parType;
                int size;
                int n = человекTableAdapter.Adapter.InsertCommand.Parameters.Count;
                for (int i = 0; i < n; ++i)
                {
                    parName = человекTableAdapter.Adapter.InsertCommand.Parameters[i].ParameterName;
                    column  = человекTableAdapter.Adapter.InsertCommand.Parameters[i].SourceColumn;
                    parType = человекTableAdapter.Adapter.InsertCommand.Parameters[i].SqlDbType;
                    size    = человекTableAdapter.Adapter.InsertCommand.Parameters[i].Size;
                    //SqlParameter sp = человекTableAdapter.Adapter.InsertCommand.Parameters[i];
                    человекTableAdapter.Adapter.UpdateCommand.Parameters.Add(parName, parType, size, column);
                }
                n = фирмаTableAdapter.Adapter.InsertCommand.Parameters.Count;
                for (int i = 0; i < n; ++i)
                {
                    parName = фирмаTableAdapter.Adapter.InsertCommand.Parameters[i].ParameterName;
                    column  = фирмаTableAdapter.Adapter.InsertCommand.Parameters[i].SourceColumn;
                    parType = фирмаTableAdapter.Adapter.InsertCommand.Parameters[i].SqlDbType;
                    size    = фирмаTableAdapter.Adapter.InsertCommand.Parameters[i].Size;
                    фирмаTableAdapter.Adapter.UpdateCommand.Parameters.Add(parName, parType, size, column);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(Resources.FormEditClients_FormEditClients_Load_Ошибка__ + exc);
            }

            // плохая идея
            //человекTableAdapter.Adapter.InsertCommand.Parameters.CopyTo(человекTableAdapter.Adapter.UpdateCommand.Parameters);
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //человекTableAdapter.Adapter.DeleteCommand.CommandText = "DELETE Юридическое_Лицо WHERE ID_Лица = @SACR";
            //человекTableAdapter.Adapter.DeleteCommand.Parameters["@SACR"].SourceColumn = "N_Паспорта";
            //фирмаTableAdapter.Adapter.DeleteCommand.CommandText = "DELETE Юридическое_Лицо WHERE ID_Лица = @SACR";
            //фирмаTableAdapter.Adapter.DeleteCommand.Parameters["@SACR"].SourceColumn = "ID_Фирмы";

            try
            {
                Validate();
                человекBindingSource.EndEdit();
                человекTableAdapter.Update(aukcionDBDataSet.Человек);

                фирмаBindingSource.EndEdit();
                фирмаTableAdapter.Update(aukcionDBDataSet.Фирма);

                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc, "Alarm!");
                //Console.WriteLine(exc);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
