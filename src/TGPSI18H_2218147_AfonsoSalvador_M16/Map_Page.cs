using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{

    public partial class Map_Page : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador;");
        MySqlCommand cmd = new MySqlCommand();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public Map_Page()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            voluntariadO_CLICK1.Hide();
            panels1.Hide();
        }
        public Pais_Click pais;
        public void PaisClick()
        {
            this.panels1.ButtonClick += new EventHandler(evento);
        }
        public void evento(object sender, EventArgs e)
        {
            VOLUNTARIADO_CLICK vc = new VOLUNTARIADO_CLICK();
            vc.BringToFront();
        }
  
        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            button3.ForeColor = Color.Wheat;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            categoria1.Show();
            categoria1.BringToFront();
     
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.ForeColor = Color.Wheat;
            button4.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            pais_Click2.Hide();
            categoria1.Hide();
            organizacao1.Hide();
            socialClick1.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            button2.ForeColor = Color.Wheat;
            button1.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            organizacao1.Show();
            organizacao1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            button4.ForeColor = Color.Wheat;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            socialClick1.Show();
            socialClick1.BringToFront();
        }

      

        private void Map_Page_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geomap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> d = new Dictionary<string, double>();
            geomap.HeatMap = d;
            geomap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geomap);
            geomap.Dock = DockStyle.Fill;
            geomap.LandClick += GeoMap1_LandClick;
            geomap.Hoverable = true;
            geomap.BringToFront();

     
        }
   
        public void GeoMap1_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {

            Console.WriteLine(arg2.Id);
           
            if (arg2.Id == ("PT"))
            {
                pais_Click2.Show();
                pais_Click2.BringToFront();
                pais_Click2.texto = "Projecto de voluntariado de Portugal";

                //string sql = "SELECT localidade from detalhes where localidade = Portugal";
                //using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                //{

                //}
            }
                if (arg2.Id == ("BR"))
            {
           
                pais_Click2.Show();
                pais_Click2.BringToFront();
                pais_Click2.texto = "Projecto de voluntariado do Brasil";
                //string sql = "SELECT localidade from detalhes where localidade = Brasil  ";
                //using (MySqlCommand cmd = new MySqlCommand(sql, conn)) 
                //{

                //}
            }
            if (arg2.Id == ("ES"))
            {
                pais_Click2.Show();
                pais_Click2.BringToFront();
                pais_Click2.texto = "Projecto de voluntariado de Espanha";
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pais_Click2_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.ShowDialog();
        }

        private void VoluntariadO_CLICK2_Load(object sender, EventArgs e)
        {

        }

        private void Pais_Click1_Load(object sender, EventArgs e)
        {

        }
    }

}
