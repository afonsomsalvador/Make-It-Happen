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
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        MySqlCommand cmd = new MySqlCommand();
        public SocialClick()
        {
            InitializeComponent();
            populateItems();
        }

        private void populateItems()
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
    }
}
