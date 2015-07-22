using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;*/
using System.Windows.Forms;

namespace DBidontwantgotothearmy
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aukcionDBDataSet.ListAukcions3". При необходимости она может быть перемещена или удалена.
            this.listAukcions3TableAdapter.Fill(this.aukcionDBDataSet.ListAukcions3);

        }
    }
}
