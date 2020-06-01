using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class addvoluntariado : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");

        void combobox()
        {
            string Query = ("SELECT * FROM categorias ORDER BY nome ASC;"); /*.. where p.idPais = l.Pais_idPais and p.nome = p.idPais*/

            using (MySqlCommand mysqlcommand = new MySqlCommand(Query, conn))
            {
                MySqlDataReader myReader;
                try
                {
                    conn.Open();
                    myReader = mysqlcommand.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(myReader); // Carrega os dados para o DataTable 
                                       // Define qual coluna será manipulada via código
                    cmb_categoria.DisplayMember = "nome";
                    // Define a fonte de dados
                    cmb_categoria.ValueMember = "id_Categoria";
                    cmb_categoria.DataSource = dt;
                    cmb_categoria.SelectedText = "Selecione uma categoria";

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.Message);
                }
                finally
                {
                    conn.Close();// Fecha a conexão com o BD
                }

            }
        }
        void combobox1()
        {
            string Query = ("SELECT * FROM organizacao ORDER BY nome ASC;"); /*.. where p.idPais = l.Pais_idPais and p.nome = p.idPais*/

            using (MySqlCommand mysqlcommand = new MySqlCommand(Query, conn))
            {
                MySqlDataReader myReader;
                try
                {
                    conn.Open();
                    myReader = mysqlcommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(myReader); // Carrega os dados para o DataTable 
                                       // Define qual coluna será manipulada via código
                    cmb_organizacao.DisplayMember = "nome";
                    // Define a fonte de dados
                    cmb_organizacao.ValueMember = "idOrganizacao";
                    cmb_organizacao.DataSource = dt;
                    cmb_organizacao.SelectedText = "Selecione uma organização";

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.Message);
                }
                finally
                {
                    conn.Close();// Fecha a conexão com o BD
                }

            }
        }
        void add()
        {
            MemoryStream ms = new MemoryStream();
            bunifuImageButton1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] arrImage = ms.GetBuffer();

            string sql = "INSERT INTO voluntariado(nome, descricao, imagem, Categoria_id_Categoria, Organizacao_idOrganizacao, Detalhes_idDetalhes, Experiencia_idExperiencia) VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@param1", textBox1.Text);
                cmd.Parameters.AddWithValue("@param2", textBox2.Text);
                cmd.Parameters.AddWithValue("@param3", arrImage);
                cmd.Parameters.AddWithValue("@param4", cmb_categoria.SelectedValue);
                cmd.Parameters.AddWithValue("@param5", cmb_organizacao.SelectedValue);
                //cmd.Parameters.AddWithValue("@param6", );
                //cmd.Parameters.AddWithValue("@param7", );
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            string sql1 = "INSERT INTO detalhes(data, duracao, alojamento, alimentacao, transfers, seguro, acompanhamento, adicional, localidade) VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@param1", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@param2", textBox3.Text);
                cmd.Parameters.AddWithValue("@param3", textBox4.Text);
                cmd.Parameters.AddWithValue("@param4", textBox6.Text);
                cmd.Parameters.AddWithValue("@param5", textBox7.Text);
                cmd.Parameters.AddWithValue("@param6", textBox8.Text);
                cmd.Parameters.AddWithValue("@param7", textBox9.Text);
                cmd.Parameters.AddWithValue("@param8", textBox10.Text);
                cmd.Parameters.AddWithValue("@param9", textBox5.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            string sql2 = "INSERT INTO requisitos(Idade, Lingua, escolaridade) VALUES(@param1, @param2, @param3)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@param1", textBox12.Text);
                cmd.Parameters.AddWithValue("@param2", textBox13.Text);
                cmd.Parameters.AddWithValue("@param3", textBox14.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            string sql3 = "INSERT INTO experiencia(tipo_experiencia) VALUES(@param1)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@param1", textBox11.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
         
        }
        public addvoluntariado()
        {
            InitializeComponent();
            combobox();
            combobox1();
        }

        private void Addvoluntariado_Load(object sender, EventArgs e)
        {

        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            add();
        }


            private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {                              

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btnuploadimage_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    bunifuImageButton1.ImageLocation = imageLocation;
                    bunifuImageButton1.BackgroundImage = Image.FromFile(dialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_nacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

