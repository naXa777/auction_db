using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBidontwantgotothearmy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormGoods().Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void редактироватьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditAukcion().Show();
        }

        private void добавитьТоварыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFillAukcion().Show();
        }

        private void редактированиеИнформацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditClients fec = new FormEditClients();
            fec.ShowDialog();
        }

        private void начатьНовыйАукционToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddAukcion().Show();
        }

        private void действияСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оформитьСделкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSellItem().Show();
        }

        private void вывестиИнформациюОПроводящихсяАукционахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormStatistics().Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new FormStatistics().Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new FormStatistics2().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.Аукцион". При необходимости она может быть перемещена или удалена.
                this.аукционTableAdapter.Fill(this.aukcionDBDataSet.Аукцион);
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Не удаётся установить подключение к базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exc.StackTrace);
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            try
            {
                аукционTableAdapter.Fill(aukcionDBDataSet.Аукцион);
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.StackTrace);
            }
        }
    }
}
