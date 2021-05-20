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
    public partial class Sir : Form
    {
        public Sir()
        {
            InitializeComponent();
        }

        private void ингредиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ингредиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void Sir_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Ингредиенты_в_договоре". При необходимости она может быть перемещена или удалена.
            this.ингредиенты_в_договореTableAdapter.Fill(this.бД_ПекарняDataSet.Ингредиенты_в_договоре);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.бД_ПекарняDataSet.Ингредиенты);

        }

        private void btnObnovit4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnObnovit3_Click(object sender, EventArgs e)
        {
            ингредиентыTableAdapter.Update(бД_ПекарняDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ингредиенты_в_договореTableAdapter.Update(бД_ПекарняDataSet);
        }
    }
}
