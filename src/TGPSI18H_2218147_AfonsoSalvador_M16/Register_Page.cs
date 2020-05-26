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
        public static class Global
        {
            // set password
            public const string strPassword = "LetMeIn99$";

            // set permutations
            public const String strPermutation = "ouiveyxaqtd";
            public const Int32 bytePermutation1 = 0x19;
            public const Int32 bytePermutation2 = 0x59;
            public const Int32 bytePermutation3 = 0x17;
            public const Int32 bytePermutation4 = 0x41;
        }
        public static string Encrypt(string strData)
        {

            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(strData)));

        }
        public static byte[] Encrypt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(Global.strPermutation,
            new byte[] { Global.bytePermutation1,
                         Global.bytePermutation2,
                         Global.bytePermutation3,
                         Global.bytePermutation4
            });

            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateEncryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }

        //public static class EncryptionHelper
        //{
        //    private static byte[] keyAndIvBytes;

        //    static EncryptionHelper()
        //    {
        //        // You'll need a more secure way of storing this, I hope this isn't
        //        // the real key
        //        keyAndIvBytes = UTF8Encoding.UTF8.GetBytes("tR7nR6wZHGjYMCuV");
        //    }
        //    public static string ByteArrayToHexString(byte[] ba)
        //    {
        //        return BitConverter.ToString(ba).Replace("-", "");
        //    }

        //    public static byte[] StringToByteArray(string hex)
        //    {
        //        return Enumerable.Range(0, hex.Length)
        //                         .Where(x => x % 2 == 0)
        //                         .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
        //                         .ToArray();
        //    }
        //    public static string EncryptAndEncode(string plaintext)
        //    {
        //        return ByteArrayToHexString(AesEncrypt(plaintext));
        //    }

        //    public static byte[] AesEncrypt(string inputText)
        //    {
        //        byte[] inputBytes = UTF8Encoding.UTF8.GetBytes(inputText);//AbHLlc5uLone0D1q

        //        byte[] result = null;
        //        using (MemoryStream memoryStream = new MemoryStream())
        //        {
        //            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, GetCryptoAlgorithm().CreateEncryptor(keyAndIvBytes, keyAndIvBytes), CryptoStreamMode.Write))
        //            {
        //                cryptoStream.Write(inputBytes, 0, inputBytes.Length);
        //                cryptoStream.FlushFinalBlock();

        //                result = memoryStream.ToArray();
        //            }
        //        }

        //        return result;
        //    }
        //    private static RijndaelManaged GetCryptoAlgorithm()
        //    {
        //        RijndaelManaged algorithm = new RijndaelManaged();
        //        //set the mode, padding and block size
        //        algorithm.Padding = PaddingMode.PKCS7;
        //        algorithm.Mode = CipherMode.CBC;
        //        algorithm.KeySize = 128;
        //        algorithm.BlockSize = 128;
        //        return algorithm;
        //    }
        //}
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
