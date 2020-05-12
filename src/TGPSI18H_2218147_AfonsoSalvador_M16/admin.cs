using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class admin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
        public admin()
        {
            InitializeComponent();
            addvoluntariado1.AutoScroll = false;

            addvoluntariado1.HorizontalScroll.Maximum = 0;
            
            addvoluntariado1.HorizontalScroll.Enabled = false;
            addvoluntariado1.HorizontalScroll.Visible = false;
            addvoluntariado1.AutoScroll = true;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.ForeColor = Color.Wheat;
            button3.ForeColor = Color.White;
            //UtilizadoresGridView.Hide();
            addvoluntariado1.Show();
            addvoluntariado1.BringToFront();
        }

        private void Addvoluntariado1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           

        }

        private void Panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            button3.ForeColor = Color.Wheat;
            button1.ForeColor = Color.White;
            addvoluntariado1.Hide();
            //UtilizadoresGridView.Show();
            //UtilizadoresGridView.BringToFront();
        }
    }
}
