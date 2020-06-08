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

        private string _current;
        private string _image;
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

   
       
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
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
       
        public string current_user
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                _current = value;
                textBox1.Text = value;
            }
        }
        public string image
        {
            get
            {
                return _image;
            }
            set
            {
                if (File.Exists(value))
                    pictureBox1.Image = System.Drawing.Image.FromFile(value);

                _image = value;
            }
        }

        // definir uma cchavemestre
        // a password do utilizador adicionar a chave mestre
        // codificar com um algoritmo de HASH (SHA256 ou semelhante)
        // guardar a password na bd desta forma
        // quando for para comparar, fazer os calculos entre o que utilizador coloca como password e o que está na BD.



        //public static class Global
        //{
        //    // set password
        //    public const string strPassword = "LetMeIn99$";

        //    // set permutations
        //    public const String strPermutation = "ouiveyxaqtd";
        //    public const Int32 bytePermutation1 = 0x19;
        //    public const Int32 bytePermutation2 = 0x59;
        //    public const Int32 bytePermutation3 = 0x17;
        //    public const Int32 bytePermutation4 = 0x41;
        //}

        //public static string Decrypt(string strData)
        //{
        //    byte[] bytePass = Encoding.ASCII.GetBytes(strData);
        //    return Encoding.UTF8.GetString(DecryptByte(bytePass));

        //}
        //public static byte[] DecryptByte(byte[] strData)
        //{
        //    PasswordDeriveBytes passbytes =
        //    new PasswordDeriveBytes(Global.strPermutation,
        //    new byte[] { Global.bytePermutation1,
        //                 Global.bytePermutation2,
        //                 Global.bytePermutation3,
        //                 Global.bytePermutation4
        //    });

        //    MemoryStream memstream = new MemoryStream();
        //    Aes aes = new AesManaged();
        //    aes.Key = passbytes.GetBytes(aes.KeySize / 8);
        //    aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

        //    CryptoStream cryptostream = new CryptoStream(memstream,
        //    aes.CreateDecryptor(), CryptoStreamMode.Write);
        //    cryptostream.Write(strData, 0, strData.Length);
        //    cryptostream.Close();
        //    return memstream.ToArray();
        //}
        //FIMMMM
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

        //    public static string DecodeAndDecrypt(string cipherText)
        //    {
        //        string DecodeAndDecrypt = AesDecrypt(StringToByteArray(cipherText));
        //        return (DecodeAndDecrypt);
        //    }



        //    public static string AesDecrypt(Byte[] inputBytes)
        //    {
        //        Byte[] outputBytes = inputBytes;

        //        string plaintext = string.Empty;

        //        using (MemoryStream memoryStream = new MemoryStream(outputBytes))
        //        {
        //            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, GetCryptoAlgorithm().CreateDecryptor(keyAndIvBytes, keyAndIvBytes), CryptoStreamMode.Read))
        //            {
        //                using (StreamReader srDecrypt = new StreamReader(cryptoStream))
        //                {
        //                    plaintext = srDecrypt.ReadToEnd();
        //                }
        //            }
        //        }

        //        return plaintext;
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
        private void Button1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string sql = ("Select * from login where user= '" + textBox1.Text.Trim() + "' and password= '" + (txtPassword.Text.ToString().Trim()) + "'");
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if(txtPassword.Text == "admin" || textBox1.Text == "admin")
                {
                    this.Hide();
                    admin a = new admin();
                    a.ShowDialog();
                }
                current_user = textBox1.Text;
                this.Hide();
                SplashScreen ss = new SplashScreen();
                ss.ShowDialog();
                conn.Close();
            }
            else
            {
                label7.Show();
                pictureBox8.Show();
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
    }
}
