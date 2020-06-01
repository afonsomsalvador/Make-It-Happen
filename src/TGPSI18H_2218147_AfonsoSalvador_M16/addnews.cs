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

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class addnews : UserControl
    {

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        public addnews()
        {
            InitializeComponent();
        }
        void add()
        {
            MemoryStream ms = new MemoryStream();
            bunifuImageButton1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] arrImage = ms.GetBuffer();

            string sql = "INSERT INTO noticias(Titulo,Corpo,Imagem) VALUES(@param1, @param2, @param3)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@param1", textBox13.Text);
                cmd.Parameters.AddWithValue("@param2", textBox14.Text);
                cmd.Parameters.AddWithValue("@param3", arrImage);
                cmd.ExecuteNonQuery();
                conn.Close();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            add();
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
    }
}
