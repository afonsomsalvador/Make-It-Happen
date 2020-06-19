using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class addnews : UserControl
    {

        private bool loadedImage = false;


        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        public addnews()
        {
            InitializeComponent();
            pictureBox3.Hide();
            pictureBox5.Hide();
            label3.Hide();
            label4.Hide();
        }
        void add()
        {
            try
            {
                string FileName = $"{Guid.NewGuid().ToString()}.jpg";

                bunifuImageButton1.Image.Save($"{ConfigurationManager.AppSettings["filesBasePath"]}{FileName}", System.Drawing.Imaging.ImageFormat.Jpeg);

                string sql = "INSERT INTO noticias(Titulo, Corpo, Imagem) VALUES(@param1, @param2, @param3)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@param1", textBox13.Text);
                    cmd.Parameters.AddWithValue("@param2", textBox14.Text);
                    cmd.Parameters.AddWithValue("@param3", FileName);
                    cmd.ExecuteNonQuery();
                    conn.Close();
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
            private void Addnews_Load(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }
        void eliminar()
        {
            bunifuImageButton1.Image = null;
            
            bunifuImageButton1.Update();
            bunifuImageButton1.Image = new Bitmap(Properties.Resources.download);
            bunifuImageButton1.Update();
            textBox13.Text = "";
            textBox14.Text = "";
            pictureBox3.Show();
            label3.Show();
            label4.Hide();
            pictureBox5.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox13.Text) || 
                String.IsNullOrEmpty(textBox14.Text) ||
                (!loadedImage))
            {
                pictureBox5.Show();
                label4.Show();
                pictureBox3.Hide();
                label3.Hide();
            }
            else
            {
                add();
                eliminar();
            }
         
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

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
