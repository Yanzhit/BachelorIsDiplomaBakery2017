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
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void Otchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Строка_чека". При необходимости она может быть перемещена или удалена.
            this.строка_чекаTableAdapter.Fill(this.бД_ПекарняDataSet.Строка_чека);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.бД_ПекарняDataSet.Ингредиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Ингредиенты_в_договоре". При необходимости она может быть перемещена или удалена.
            this.ингредиенты_в_договореTableAdapter.Fill(this.бД_ПекарняDataSet.Ингредиенты_в_договоре);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet1.План_продаж". При необходимости она может быть перемещена или удалена.
            this.план_продажTableAdapter.Fill(this.бД_ПекарняDataSet1.План_продаж);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Квитанция_1". При необходимости она может быть перемещена или удалена.
            this.квитанция_1TableAdapter.Fill(this.бД_ПекарняDataSet.Квитанция_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Договор_1". При необходимости она может быть перемещена или удалена.
            this.договор_1TableAdapter.Fill(this.бД_ПекарняDataSet.Договор_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Выпечка_в_договоре". При необходимости она может быть перемещена или удалена.
            this.выпечка_в_договореTableAdapter.Fill(this.бД_ПекарняDataSet.Выпечка_в_договоре);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.План_производства". При необходимости она может быть перемещена или удалена.
            this.план_производстваTableAdapter.Fill(this.бД_ПекарняDataSet.План_производства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Выпечка". При необходимости она может быть перемещена или удалена.
            this.выпечкаTableAdapter.Fill(this.бД_ПекарняDataSet.Выпечка);
                                          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }
    
        private void выпечка_в_магBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          
        }

        private void датаDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void датаLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.квитанция_1TableAdapter.FillBy(this.бД_ПекарняDataSet.Квитанция_1, new System.Nullable<int>(((int)(System.Convert.ChangeType(nOMERDOGToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.выпечка_в_договореTableAdapter.FillBy(this.бД_ПекарняDataSet.Выпечка_в_договоре, ((int)(System.Convert.ChangeType(nOMDOGToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.договор_1TableAdapter.FillBy(this.бД_ПекарняDataSet.Договор_1, ((int)(System.Convert.ChangeType(nOMDOGToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.план_производстваTableAdapter.FillBy(this.бД_ПекарняDataSet.План_производства, dATA1ToolStripTextBox.Text, dATA2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                this.план_продажTableAdapter.FillBy(this.бД_ПекарняDataSet.План_продаж, d1ToolStripTextBox.Text, d2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.квитанция_1TableAdapter.FillBy1(this.бД_ПекарняDataSet.Квитанция_1, dataToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                this.строка_чекаTableAdapter.FillBy(this.бД_ПекарняDataSet.Строка_чека, dataToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dATA2ToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void dATA1ToolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
    
