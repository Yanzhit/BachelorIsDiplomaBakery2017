using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пекарня
{
    public partial class fmain : Form
    {
        GotProd gp = new GotProd();
        Sotrudniki sotr = new Sotrudniki();
        Zakaz zak = new Zakaz();
        Postav pos = new Postav();
        Sir sir = new Sir();
        Doc doc = new Doc();
        ProdProd Prod = new ProdProd();
        ProdDog prdog = new ProdDog();
        SostProd sostprod = new SostProd();
        Otchet otchet = new Otchet();
        public fmain()
        {
            InitializeComponent();
        }

        private void выпечкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выпечкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Выпечка_в_договоре". При необходимости она может быть перемещена или удалена.
            this.выпечка_в_договореTableAdapter.Fill(this.бД_ПекарняDataSet.Выпечка_в_договоре);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Выпечка". При необходимости она может быть перемещена или удалена.
            this.выпечкаTableAdapter.Fill(this.бД_ПекарняDataSet.Выпечка);

        }

        private void выпечкаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sotr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            doc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zak.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pos.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            otchet.ShowDialog();
        }

        private void btnSir_Click(object sender, EventArgs e)
        {
            sir.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Prod.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            prdog.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sostprod.ShowDialog();
        }
    }
}
