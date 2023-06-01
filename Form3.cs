using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form3 : Form
    {
        string sql_conn = @"Data Source=LAB206-11\SQLEXPRESS;Initial Catalog=CtoloviePribori;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(sql_conn);

                string select = "SELECT * FROM [CtoloviePribori].[dbo].[CtoloviePribori] ORDER BY RazmerMaksimalnoVozmoznoiSkidki";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) > 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label3.Text = $"{b} из {a} записей";
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(sql_conn);

                string select = "SELECT * FROM [CtoloviePribori].[dbo].[CtoloviePribori] ORDER BY RazmerMaksimalnoVozmoznoiSkidki DESC";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) > 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label3.Text = $"{b} из {a} записей";
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                SqlConnection sqlConnection = new SqlConnection(sql_conn);

                string select = "select * from [CtoloviePribori].[dbo].[CtoloviePribori]";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) > 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                    }
                }
                string a = "30";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label3.Text = $"{b} из {a} записей";
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(sql_conn);

                string select = "select * from [CtoloviePribori].[dbo].[CtoloviePribori]";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                listBox1.DataSource = dataTable;
                listBox1.DisplayMember = "Naimenovanie";
                dataGridView1.DataSource = dataTable;


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) > 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label3.Text = $"{b} из {a} записей";
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(sql_conn);

                string select = "select * from [CtoloviePribori].[dbo].[CtoloviePribori] where Naimenovanie Like '" + textBox3.Text + "%'";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) > 14)
                    {
                        dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                    }
                }
                string a = "";
                string b = Convert.ToString(dataGridView1.Rows.Count);
                label3.Text = $"{b} из {a} записей";
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}