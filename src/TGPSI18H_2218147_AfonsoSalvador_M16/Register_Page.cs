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
using System.Security.Cryptography;
using System.IO;
namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Register_Page : Form
    {
        String imageLocation = "";
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador;");

        void combobox()
        {
            string Query = ("SELECT * FROM pais ORDER BY nome ASC;"); /*.. where p.idPais = l.Pais_idPais and p.nome = p.idPais*/

            using (MySqlCommand mysqlcommand = new MySqlCommand(Query, conn))
            {
                MySqlDataReader myReader;
                try
                {
              
                    conn.Open();
                    myReader = mysqlcommand.ExecuteReader();
                                
                    
                 
                   
                   
                       
                        DataTable dt = new DataTable();
                        dt.Load(myReader); // Carrega os dados para o DataTable 
                        // Define qual coluna será manipulada via código
                        cmb_nacionalidade.DisplayMember = "nome";
                        // Define a fonte de dados
                        cmb_nacionalidade.ValueMember = "idPais";
                        cmb_nacionalidade.DataSource = dt;
                        cmb_nacionalidade.SelectedText = "Selecione uma nacionalidade";

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.Message);
                }
                finally
                {
                    conn.Close();// Fecha a conexão com o BD
                }
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


            if (txt_password.Text == txt_conpass.Text)
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@param1", txt_user.Text);
                    cmd.Parameters.AddWithValue("@param2", Encrypt(txt_password.Text.Trim()));
                    cmd.Parameters.AddWithValue("@param3", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@param4", txt_email.Text);
                    cmd.Parameters.AddWithValue("@param5", cmb_nacionalidade.SelectedValue);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {

            }
            
      
        }
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
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

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
