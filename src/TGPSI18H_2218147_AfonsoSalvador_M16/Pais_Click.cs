using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Pais_Click : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        MySqlDataReader dr ;
        MySqlCommand cmd = new MySqlCommand(); 
        public string texto
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        private void populateItems()
       {
            //Panels[] panel = new Panels[20];
            //for (int i = 0; i < panel.Length; i++)
            //{
            //    panel[i] = new Panels();
            //    panel[i].Nome = "";
            //    panel[i].Descricao = "";
            //    //panel[i].image = ;

            //    //if (flowLayoutPanel1.Controls.Count > 0)
            //    //{
            //    //    flowLayoutPanel1.Controls.Clear();
            //    //}
            //    //else
            //    //{

            //    flowLayoutPanel1.Controls.Add(panel[i]);
            //}

        }
    
        private void GetData()
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT descricao, nome, imagem from voluntariado", conn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[len + 1];
                dr.GetBytes(0, 0, array, 0, 0);
                pictureBox1 = new PictureBox();
                pictureBox1.Width = 100;
                pictureBox1.Height = 100;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pictureBox1.BackgroundImage = bitmap;

                flowLayoutPanel1.Controls.Add(pictureBox1);
            }
            dr.Close();
            conn.Close();
        }
            public Pais_Click()
        {
            InitializeComponent();
        }
        private void Pais_Click_Load(object sender, EventArgs e)
        {
            label1.Text = texto;
            populateItems();
            VerticalScroll.Enabled = true;
            GetData();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
