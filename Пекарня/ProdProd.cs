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
    public partial class ProdProd : Form
    {
        public ProdProd()
        {
            InitializeComponent();
        }

        private void выпечка_в_магBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выпечка_в_магBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void ProdProd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Выпечка_в_маг". При необходимости она может быть перемещена или удалена.
            this.выпечка_в_магTableAdapter.Fill(this.бД_ПекарняDataSet.Выпечка_в_маг);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            выпечка_в_магTableAdapter.Update(бД_ПекарняDataSet);
        }
    }
}
