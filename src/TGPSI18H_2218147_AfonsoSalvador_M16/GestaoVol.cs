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
    public partial class GestaoVol : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        MySqlCommand cmd;
        public GestaoVol()
        {
            InitializeComponent();
            conn.Open();
            string query = "SELECT * FROM voluntariado ";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM voluntariado WHERE idVoluntariado = " + int.Parse(textBox4.Text);
            executeMyQuery(deleteQuery);
            populateDGV();
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
        private void GestaoVol_Load(object sender, EventArgs e)
        {
            populateDGV();
        }
        public void populateDGV()
        {
            // populate the datagridview
            string selectQuery =  "SELECT* FROM voluntariado ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }
        public void pesquisar(string pesquisa)
        {

            string pesquisarQuery = "SELECT * FROM voluntariado WHERE CONCAT( idVoluntariado, nome) LIKE '%" + pesquisa + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(pesquisarQuery, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            pesquisar(txtSearch.Text);
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox16.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox17.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox19.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            textBox14.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox18.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string updateQuery = @"UPDATE voluntariado SET nome = '" + textBox1.Text + "',Descricao = '" + textBox2.Text + 
                "',Categorias_id_Categoria = '" + int.Parse(textBox3.Text) + "',Organizacao_idOrganizacao = '" + int.Parse(textBox5.Text) +
                "',Experiencia_idExperiencia = '" + int.Parse(textBox6.Text) + "',Pais_idPais = '" + int.Parse(textBox13.Text) +
                "',Idade = '" + textBox16.Text + "',Lingua = '" + textBox17.Text +
                "',Escolaridade = '" + textBox19.Text + "',data = '" + textBox7.Text +
                "',duracao = '" + textBox8.Text + "',alojamento = '" + textBox9.Text +
                "',alimentacao = '" + textBox10.Text + "',transfers = '" + textBox11.Text +
                "',seguro = '" + textBox12.Text + "',acompanhamento = '" + textBox15.Text +
                "',localidade = '" + textBox14.Text + "',adicional = '" + textBox18.Text + "' WHERE idVoluntariado = " + int.Parse(textBox4.Text);
            executeMyQuery(updateQuery);
            populateDGV();
        }
    }
}
