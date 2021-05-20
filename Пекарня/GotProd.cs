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
    public partial class GotProd : Form
    {
        public GotProd()
        {
            InitializeComponent();
        }

        private void выпечкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выпечкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void GotProd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Выпечка". При необходимости она может быть перемещена или удалена.
            this.выпечкаTableAdapter.Fill(this.бД_ПекарняDataSet.Выпечка);

        }

        private void цена__шт_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void иД_ВыпечкиLabel_Click(object sender, EventArgs e)
        {

        }

        private void наименованиеLabel_Click(object sender, EventArgs e)
        {

        }

        private void выпечкаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnObnovit_Click(object sender, EventArgs e)
        {
            выпечкаTableAdapter.Update(бД_ПекарняDataSet);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void иД_ВыпечкиTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void цена__шт_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
