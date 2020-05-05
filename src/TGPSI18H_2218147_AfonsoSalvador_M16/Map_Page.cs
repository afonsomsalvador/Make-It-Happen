using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Map_Page : Form
    {
        public Map_Page()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void GeoMap1_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            
            Console.WriteLine(arg2.Id);
           
            if (arg2.Id == ("PT"))
            {
                
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
