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
    public partial class ProdDog : Form
    {
        public ProdDog()
        {
            InitializeComponent();
        }

        private void выпечка_в_договореBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выпечка_в_договореBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void ProdDog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Выпечка_в_договоре". При необходимости она может быть перемещена или удалена.
            this.выпечка_в_договореTableAdapter.Fill(this.бД_ПекарняDataSet.Выпечка_в_договоре);

        }

        private void выпечка_в_договореDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            выпечка_в_договореTableAdapter.Update(бД_ПекарняDataSet);
        }
    }
}
