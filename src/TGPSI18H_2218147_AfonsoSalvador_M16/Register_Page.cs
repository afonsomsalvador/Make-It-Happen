﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Register_Page : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        public Register_Page()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
                conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;

            if (txt_password.Text == txt_conpass.Text)
            {
                cmd.Parameters.Add("@user", MySqlDbType.VarChar, 20).Value = txt_user.Text;
                cmd.Parameters.Add("@Password", MySqlDbType.VarChar, 8).Value = txt_password.Text;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 80).Value = txt_nome.Text;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = txt_email.Text;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Conta criada!!");
                }
            }
            else 
            {
                
            }
            
         
            conn.Close();
        }
        private void Register_Page_Load(object sender, EventArgs e)
        {

        }



        private void Btnuploadimage_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            bunifuImageButton1.Image.Save(ms,bunifuImageButton1.Image.RawFormat);
            byte[] img = ms.ToArray();
            String insertQuery = "INSERT INTO foto";
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    bunifuImageButton1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void Label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 MP = new Form1();
            MP.ShowDialog();
        }
    }
}
