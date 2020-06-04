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
    public partial class SplashScreen : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private int _Progress = 0;
        public SplashScreen()
        {
            InitializeComponent();
            LoginForm lf = new LoginForm();
            lf.current_user = label2.Text.ToString().Trim();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 150;    
            timer1.Tick += Timer1_Tick;
            timer1.Start();

          
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = flipImage;

            if (_Progress < 100)
            {
                _Progress = _Progress + 5;
                label3.Text = _Progress.ToString() + "%";
                while(_Progress == 100)
                {
                    this.Hide();
                    Map_Page mp = new Map_Page();
                    mp.ShowDialog();
                }
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
