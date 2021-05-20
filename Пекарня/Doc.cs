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
    public partial class Doc : Form
    {
        string connectionString = @"Data Source=YANZHIT-PC;Initial Catalog=БД_Пекарня;Integrated Security=True";
        public Doc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Doc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.План_продаж". При необходимости она может быть перемещена или удалена.
            this.план_продажTableAdapter.Fill(this.бД_ПекарняDataSet.План_продаж);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.План_производства". При необходимости она может быть перемещена или удалена.
            this.план_производстваTableAdapter.Fill(this.бД_ПекарняDataSet.План_производства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Строка_чека". При необходимости она может быть перемещена или удалена.
            this.строка_чекаTableAdapter.Fill(this.бД_ПекарняDataSet.Строка_чека);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Чек". При необходимости она может быть перемещена или удалена.
            this.чекTableAdapter.Fill(this.бД_ПекарняDataSet.Чек);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Квитанция_2". При необходимости она может быть перемещена или удалена.
            this.квитанция_2TableAdapter.Fill(this.бД_ПекарняDataSet.Квитанция_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Квитанция_1". При необходимости она может быть перемещена или удалена.
            this.квитанция_1TableAdapter.Fill(this.бД_ПекарняDataSet.Квитанция_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Договор_2". При необходимости она может быть перемещена или удалена.
            this.договор_2TableAdapter.Fill(this.бД_ПекарняDataSet.Договор_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ПекарняDataSet.Договор_1". При необходимости она может быть перемещена или удалена.
            this.договор_1TableAdapter.Fill(this.бД_ПекарняDataSet.Договор_1);

        }

        private void договор_1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договор_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ПекарняDataSet);

        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            договор_1TableAdapter.Update(бД_ПекарняDataSet);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[Summa]";
            int NomDog = int.Parse(this.номерДоговораTextBox.Text); 
            myCommand.Parameters.Add("@nd", SqlDbType.Int);
            myCommand.Parameters["@nd"].Value = NomDog;
            conn.Open();
            int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
            if (UspeshnoeIzmenenie != 0)
            {
                MessageBox.Show("Изменения внесены", "Изменение записи");
            }
            else
            {
                MessageBox.Show("Не удалось внести изменения", "Изменение записи");
            }
            conn.Close();
        }

        private void btnObnov2_Click(object sender, EventArgs e)
        {
            договор_2TableAdapter.Update(бД_ПекарняDataSet);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[Summa2]";
            int NomDog = int.Parse(this.номерДоговораTextBox.Text);
            myCommand.Parameters.Add("@nd", SqlDbType.Int);
            myCommand.Parameters["@nd"].Value = NomDog;
            conn.Open();
            int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
            if (UspeshnoeIzmenenie != 0)
            {
                MessageBox.Show("Изменения внесены", "Изменение записи");
            }
            else
            {
                MessageBox.Show("Не удалось внести изменения", "Изменение записи");
            }
            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            квитанция_1TableAdapter.Update(бД_ПекарняDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            квитанция_2TableAdapter.Update(бД_ПекарняDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            строка_чекаTableAdapter.Update(бД_ПекарняDataSet);

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "[Summa3]";
            int NomDog = int.Parse(this.номерДоговораTextBox.Text);
            myCommand.Parameters.Add("@nd", SqlDbType.Int);
            myCommand.Parameters["@nd"].Value = NomDog;
            conn.Open();
            int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
            if (UspeshnoeIzmenenie != 0)
            {
                MessageBox.Show("Изменения внесены", "Изменение записи");
            }
            else
            {
                MessageBox.Show("Не удалось внести изменения", "Изменение записи");
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            чекTableAdapter.Update(бД_ПекарняDataSet);
        }

        private void договор_1BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            план_производстваTableAdapter.Update(бД_ПекарняDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            план_продажTableAdapter.Update(бД_ПекарняDataSet);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void номерДоговораTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
