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
    public partial class SocialClick : UserControl
    {
        private static string _connection = "datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador";
        private static MySqlConnection conn = new MySqlConnection(_connection);
        public void connect()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não foi possivel ligar à base de dados. Erro: " + ex);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
            }

        }
        MySqlCommand cmd = new MySqlCommand();
        public SocialClick()
        {
            InitializeComponent();
            connect();
            populateItems();
        }

        private void populateItems()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM noticias", conn);
                MySqlDataReader dt;

                dt = cmd.ExecuteReader();
                while (dt.Read())
                {

                    News n = new News();

                    n.Nome = dt["Titulo"].ToString();
                    n.Descricao = dt["Corpo"].ToString();
                    n.image = $"{ConfigurationManager.AppSettings["filesBasePath"]}{ dt["Imagem"]}";
                    //p.image = dt["imagem"];

                    flowLayoutPanel2.Controls.Add(n);
                }
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
        private void SocialClick_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 150;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
      
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = flipImage;
        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
