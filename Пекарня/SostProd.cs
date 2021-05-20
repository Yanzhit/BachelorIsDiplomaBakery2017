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
    public partial class SostProd : Form
    {
        public SostProd()
        {
            InitializeComponent();
        }

        private void состав_ПродукцииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.состав_ПродукцииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void SostProd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Состав_Продукции". При необходимости она может быть перемещена или удалена.
            this.состав_ПродукцииTableAdapter.Fill(this.бД_ПекарняDataSet.Состав_Продукции);

        }

        private void btnObnovit4_Click(object sender, EventArgs e)
        {
            состав_ПродукцииTableAdapter.Update(бД_ПекарняDataSet);
        }
    }
}
