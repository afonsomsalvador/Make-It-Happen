using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class LoginForm : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        public LoginForm()
        {
            InitializeComponent();
            label4.Hide();
            label5.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
        private void Label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Page RP = new Register_Page();
            RP.ShowDialog();
        }

   
       
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     
        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
        }

     

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
            label5.Hide();
           
            pictureBox6.Hide();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            label4.Hide();
            pictureBox5.Hide();

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel2_MouseDown_1(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != null || txtPassword.Text.Trim() != null)
            {
                label4.Show();
                label5.Show();
                pictureBox5.Show();
                pictureBox6.Show();
               
            }
            else
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from login where username= '" + textBox1.Text + "' and password= '" + txtPassword.Text + "'";
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        private void Label13_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
