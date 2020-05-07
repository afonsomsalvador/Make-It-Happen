using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456;database=psi18_afonsosalvador");
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from login where username= '" + textBox1.Text + "' and password= '" + txtPassword.Text + "'";
            cmd.ExecuteNonQuery();
            this.Hide();
            Map_Page mp = new Map_Page();
            mp.ShowDialog();
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Page RP = new Register_Page();
            RP.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
