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


            utilizadoresGridView2.AutoScroll = true;
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.ForeColor = Color.Wheat;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            utilizadoresGridView2.SendToBack();
            addvoluntariado1.BringToFront();
            gestaoVol1.SendToBack();
            addnews1.SendToBack();
            gestaoNews2.SendToBack();
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
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            gestaoVol1.SendToBack();
            utilizadoresGridView2.SendToBack();
            addvoluntariado1.BringToFront();
            addnews1.SendToBack();
            gestaoNews2.SendToBack();
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
            button5.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            addvoluntariado1.SendToBack();
            utilizadoresGridView2.BringToFront();
            gestaoVol1.SendToBack();
            addnews1.SendToBack();
            gestaoNews2.SendToBack();


        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            button3.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button2.ForeColor = Color.Wheat;
            button1.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            addvoluntariado1.SendToBack();
            gestaoVol1.SendToBack();
            utilizadoresGridView2.SendToBack();
            addnews1.BringToFront();
            gestaoNews2.SendToBack();

        }

        private void Addnews1_Load(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button1.ForeColor = Color.White;
            button4.ForeColor = Color.Wheat;
            button5.ForeColor = Color.White;
            addvoluntariado1.SendToBack();
            gestaoVol1.BringToFront();
            utilizadoresGridView2.SendToBack();
            addnews1.SendToBack();
            gestaoNews2.SendToBack();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            
        }

        private void GestaoNews2_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button1.ForeColor = Color.White;
            button5.ForeColor = Color.Wheat;
            button4.ForeColor = Color.White;
            addvoluntariado1.SendToBack();
            gestaoVol1.SendToBack();
            gestaoNews2.BringToFront();
            utilizadoresGridView2.SendToBack();
            addnews1.SendToBack();
        }

        private void UtilizadoresGridView2_Load(object sender, EventArgs e)
        {

        }
    }
}
