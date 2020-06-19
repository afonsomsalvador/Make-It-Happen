using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class GestaoNews : UserControl
    {

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        MySqlCommand cmd;
        public GestaoNews()
        {
            InitializeComponent();
            try
            {
                openConnection();
                string query = "SELECT * FROM noticias";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao executar operação na base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }
           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM noticias WHERE idNoticias = " + int.Parse(textBox4.Text);
                executeMyQuery(deleteQuery);
                populateDGV();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro ao executar operação na base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
          
        }
        public void pesquisar(string pesquisa)
        {
            try
            {
                string pesquisarQuery = "SELECT * FROM noticias WHERE  CONCAT( idNoticias, Titulo, Corpo ) LIKE '%" + pesquisa + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(pesquisarQuery, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao executar operação na base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }
          
             
        }

            private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand(query, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Query Not Executed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void GestaoNews_Load(object sender, EventArgs e)
        {
            populateDGV();
        }
        public void populateDGV()
        {
            try
            {
                // populate the datagridview
                string selectQuery = "SELECT * FROM noticias";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (MySqlException  e)
            {
                MessageBox.Show("Ocorreu um erro ao executar operação na base de dados. Erro: " + e);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro);
            }
        }
        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE noticias SET Titulo = '" + textBox1.Text + "',Corpo = '" + textBox2.Text + "' WHERE idNoticias = " + int.Parse(textBox4.Text);
                executeMyQuery(updateQuery);
                populateDGV();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao executar operação na base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }
            
          
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            pesquisar(txtSearch.Text);
        }
    }
}
