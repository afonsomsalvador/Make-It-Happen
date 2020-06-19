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
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class LoginForm : Form
    {

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");

        public string _current = "";
        public LoginForm()
        {
            InitializeComponent();
            label7.Hide();
            pictureBox8.Hide();
            pictureBox7.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
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
           
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
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

            if (String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(textBox1.Text))
            {
                label7.Show();
                pictureBox8.Show();
            }
            else
            {
                try
                {
                    conn.Open();
                    string sql = ("Select * from login where (user collate utf8_bin) = '" + textBox1.Text.Trim() + "' and (password collate utf8_bin) = '" + (txtPassword.Text.ToString().Trim()) + "'");
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        label7.Show();
                        pictureBox8.Show();

                    }
                    else
                    {
                        if (txtPassword.Text == "admin" || textBox1.Text == "admin")
                        {
                            this.Hide();
                            admin a = new admin();
                            a.ShowDialog();
                        }
                        else
                        {
                            Class1.USER = textBox1.Text;
                            this.Hide();
                            SplashScreen ss = new SplashScreen();
                            ss.ShowDialog();
                        }

                    }
                    conn.Close();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao executar operação na base de dados. Erro: " + ex);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Aconteceu um erro não identificado. Erro: " + erro);
                }
            }
                
        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
            pictureBox7.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register_Page RP = new Register_Page();
            RP.ShowDialog();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
