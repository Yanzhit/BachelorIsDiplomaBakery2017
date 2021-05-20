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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void заказчикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказчикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this.бД_ПекарняDataSet.Заказчик);

        }

        private void btnObnovit3_Click(object sender, EventArgs e)
        {
            заказчикTableAdapter.Update(бД_ПекарняDataSet);
        }
    }
}
