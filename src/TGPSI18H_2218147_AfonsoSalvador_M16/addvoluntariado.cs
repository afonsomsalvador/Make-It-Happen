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
using System.Configuration;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class addvoluntariado : UserControl
    {

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");

        private bool loadedImage = false;
        void combobox()
        {
            try
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao executar operação na base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }
            
        }
        void combobox1()
        {

            try
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao executar operação na base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }
        }
        void combobox2()
        {
            try
            {
                string Query = ("SELECT idExperiencia, tipo_experiencia FROM experiencia ORDER BY tipo_experiencia ASC;"); /*.. where p.idPais = l.Pais_idPais and p.nome = p.idPais*/

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
                        cmb_Experiencia.DisplayMember = "tipo_experiencia";
                        // Define a fonte de dados
                        cmb_Experiencia.ValueMember = "idExperiencia";
                        cmb_Experiencia.DataSource = dt;
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao executar operação na base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }
           
        }
        void combobox3()
        {
            try
            {
                string Query = ("SELECT * FROM pais ORDER BY nome ASC;"); /*.. where p.idPais = l.Pais_idPais and p.nome = p.idPais*/

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
                        cmb_pais.DisplayMember = "nome";
                        // Define a fonte de dados
                        cmb_pais.ValueMember = "idPais";
                        cmb_pais.DataSource = dt;
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao executar operação na base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }
        }
        void eliminar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            bunifuImageButton1.Image = null;
            bunifuImageButton1.Update();
            bunifuImageButton1.Image = new Bitmap(Properties.Resources.download);
            bunifuImageButton1.Update();
            cmb_categoria.ResetText();
            cmb_organizacao.ResetText();
            cmb_Experiencia.ResetText();
            _ = dateTimePicker1.Value == null;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox5.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            cmb_pais.ResetText();
        }
            void add()
            {
            try
            {
                string FileName = $"{Guid.NewGuid().ToString()}.jpg";

                //MemoryStream ms = new MemoryStream();
                bunifuImageButton1.Image.Save($"{ConfigurationManager.AppSettings["filesBasePath"]}{FileName}", System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] arrImage = ms.GetBuffer();

                string sql = "INSERT INTO voluntariado(nome, descricao, imagem, Categorias_id_Categoria, Organizacao_idOrganizacao, Experiencia_idExperiencia, data, duracao, alojamento, alimentacao, transfers, seguro, acompanhamento, adicional, localidade, Idade, Lingua, escolaridade, Pais_idPais) VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11, @param12, @param13, @param14, @param15, @param16, @param17, @param18, @param19)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@param1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@param2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@param3", FileName);
                    cmd.Parameters.AddWithValue("@param4", cmb_categoria.SelectedValue);
                    cmd.Parameters.AddWithValue("@param5", cmb_organizacao.SelectedValue);
                    cmd.Parameters.AddWithValue("@param6", cmb_Experiencia.SelectedValue);
                    cmd.Parameters.AddWithValue("@param7", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@param8", textBox3.Text);
                    cmd.Parameters.AddWithValue("@param9", textBox4.Text);
                    cmd.Parameters.AddWithValue("@param10", textBox6.Text);
                    cmd.Parameters.AddWithValue("@param11", textBox7.Text);
                    cmd.Parameters.AddWithValue("@param12", textBox8.Text);
                    cmd.Parameters.AddWithValue("@param13", textBox9.Text);
                    cmd.Parameters.AddWithValue("@param14", textBox10.Text);
                    cmd.Parameters.AddWithValue("@param15", textBox5.Text);
                    cmd.Parameters.AddWithValue("@param16", textBox12.Text);
                    cmd.Parameters.AddWithValue("@param17", textBox13.Text);
                    cmd.Parameters.AddWithValue("@param18", textBox14.Text);
                    cmd.Parameters.AddWithValue("@param19", cmb_pais.SelectedValue);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    pictureBox3.Show();
                    label42.Show();
                    pictureBox5.Hide();
                    label43.Hide();
                }
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
        public addvoluntariado()
        {
            InitializeComponent();
            pictureBox3.Hide();
            label42.Hide();
            pictureBox5.Hide();
            label43.Hide();
            combobox();
            combobox1();
            combobox2();
            combobox3();
        }

        private void Addvoluntariado_Load(object sender, EventArgs e)
        {

        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            if ((!loadedImage) || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(cmb_categoria.Text) || String.IsNullOrEmpty(cmb_organizacao.Text) || String.IsNullOrEmpty(cmb_Experiencia.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text) || String.IsNullOrEmpty(textBox8.Text) || String.IsNullOrEmpty(textBox9.Text) || String.IsNullOrEmpty(textBox10.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox12.Text) || String.IsNullOrEmpty(textBox13.Text) || String.IsNullOrEmpty(textBox14.Text) || String.IsNullOrEmpty(cmb_pais.Text))
            {
                pictureBox3.Hide();
                label42.Hide();
                pictureBox5.Show();
                label43.Show();
            }
            else
            {
                add();
                eliminar();
            }
           
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
                    bunifuImageButton1.Image = Image.FromFile(dialog.FileName);
                    loadedImage = true;
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

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }
    }
}

