using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пекарня
{
    public partial class Sotrudniki : Form
    {
        public Sotrudniki()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void сотрудникиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void btnSotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.бД_ПекарняDataSet.Сотрудники);

        }

        private void сотрудникиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnObnovit2_Click(object sender, EventArgs e)
        {
            сотрудникиTableAdapter.Update(бД_ПекарняDataSet);
        }
    }
}
