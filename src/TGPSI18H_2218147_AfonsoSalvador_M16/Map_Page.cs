﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Map_Page : Form
    {
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

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            
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

        private void VoluntariadO_CLICK1_Load(object sender, EventArgs e)
        {

        }

        private void SocialClick1_Load(object sender, EventArgs e)
        {

        }
    }

}
