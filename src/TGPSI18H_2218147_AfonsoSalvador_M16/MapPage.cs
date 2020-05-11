using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class MapPage : UserControl
    {
        public MapPage()
        {
            InitializeComponent();
        }

        private void MapPage_Load(object sender, EventArgs e)
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
    }
}
