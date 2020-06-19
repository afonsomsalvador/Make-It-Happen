using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{

    public partial class UtilizadoresGridView : UserControl
    {
        MySqlCommand cmd;
        private static string _connection = "datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador";
        private static MySqlConnection conn = new MySqlConnection(_connection);
       public void connect()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Não foi possivel ligar à base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }
        }

        public UtilizadoresGridView()
        {
            InitializeComponent();
            connect();
            try
            {
                conn.Open();
                string query = "SELECT * FROM login ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                conn.Close();
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
        public void populateDGV()
        {

            try
            { // populate the datagridview
                string selectQuery = "SELECT* FROM login ";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn);
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

        private void UtilizadoresGridView_Load(object sender, EventArgs e)
        {
            populateDGV();
            
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
   
        }
        public void pesquisar(string pesquisa)
        {
            try
            {
                string pesquisarQuery = "SELECT * FROM login WHERE CONCAT( id_user, user) LIKE '%" + pesquisa + "%'";
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
        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand(query, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query executada");
                }

                else
                {
                    MessageBox.Show("Query não executada");
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
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM login WHERE id_user = " + int.Parse(textBox1.Text);
                executeMyQuery(deleteQuery);
                populateDGV();
                textBox4.Text = "";
                textBox2.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox1.Text = "";
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE login SET user = '" + textBox4.Text + "',Password = '" + textBox2.Text + "',nome = '" + textBox6.Text + "',email = '" + textBox3.Text + "',Pais_idPais = '" + textBox5.Text + "' WHERE id_user = " + int.Parse(textBox1.Text);
                executeMyQuery(updateQuery);
                populateDGV();
                textBox4.Text = "";
                textBox2.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox1.Text = "";
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
    }
}
