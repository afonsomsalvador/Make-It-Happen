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
using System.Configuration;
using System.Runtime.InteropServices;
using System.IO;
namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Register_Page : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador;");

        void combobox()
        {
            string Query = ("SELECT p.idPais, l.Pais_idPais, p.nome FROM login l, pais p where p.idPais = l.Pais_idPais and p.nome = p.idPais INNER JOIN pais ON l.Pais_idPais = p.idPais");

            using (MySqlCommand mysqlcommand = new MySqlCommand(Query, conn))
            {
                MySqlDataReader myReader;
                try
                {

                    conn.Open();
                    myReader = mysqlcommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        string sName = myReader.GetString("nome");
                        cmb_nacionalidade.Items.Add(sName);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                conn.Close();
            }
        }
        public Register_Page()
        {
            InitializeComponent();
            combobox();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            string sql = ("INSERT INTO login(user, Password, nome, email, Pais_idPais) VALUES(@param1, @param2, @param3, @param4, @param5) ");
            string sql1 = ("SELECT idPais FROM login INNER JOIN pais ON idPais = pais.idPais");
            string sql2 = ("SELECT idPais FROM pais Inner join login On idPais = login.idPais ");

            using (MySqlCommand cmd= new MySqlCommand(sql,conn))
            {
                if (txt_password.Text == txt_conpass.Text)
                {
                    conn.Open();
                    cmd.Parameters.Add("@param1", MySqlDbType.VarChar, 20).Value = txt_user.Text;
                    cmd.Parameters.Add("@param2", MySqlDbType.VarChar, 8).Value = txt_password.Text;
                    cmd.Parameters.Add("@param3", MySqlDbType.VarChar, 80).Value = txt_nome.Text;
                    cmd.Parameters.Add("@param4", MySqlDbType.VarChar, 45).Value = txt_email.Text;
                    cmd.Parameters.Add("@param5", MySqlDbType.VarChar, 45).Value = cmb_nacionalidade.SelectedItem;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
      
        }

        private void Register_Page_Load(object sender, EventArgs e)
        {

        }

        private void Btnuploadimage_Click(object sender, EventArgs e)
        {
 
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
            LoginForm MP = new LoginForm();
            MP.ShowDialog();
        }

        private void Cmb_nacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
