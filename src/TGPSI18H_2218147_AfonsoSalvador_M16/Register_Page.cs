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
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador;");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private bool loadedImage = false;

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
            txt_password.UseSystemPasswordChar = false;
            txt_conpass.UseSystemPasswordChar = false;
            pictureBox16.Hide();
            label21.Hide();
            combobox();
            // Email
            label14.Hide();
            pictureBox6.Hide();
            // User
            label15.Hide();
            pictureBox4.Hide();
            // Conta Existe
            label20.Hide();
            pictureBox14.Hide();
            txt_password.UseSystemPasswordChar = false;
            // Conta Criada
            pictureBox17.Hide(); 
            label42.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if ((!loadedImage) || String.IsNullOrEmpty(txt_email.Text) || String.IsNullOrEmpty(txt_user.Text) || String.IsNullOrEmpty(txt_password.Text) || String.IsNullOrEmpty(txt_conpass.Text) || String.IsNullOrEmpty(txt_nome.Text) || String.IsNullOrEmpty(cmb_nacionalidade.Text))
            {
                label15.Show();
                pictureBox4.Show();
                pictureBox17.Hide();
                label42.Hide();
            }
            else
            {
                label15.Hide();
                pictureBox4.Hide();
                //// Email
                //label14.Hide();
                //pictureBox6.Hide();
                //// User
                //label15.Hide();
                //pictureBox4.Hide();
                //// Password
                //label16.Hide();
                //pictureBox5.Hide();
                //// Confirmar Password
                //label17.Hide();
                //pictureBox7.Hide();
                //// Nacionalidade
                //label19.Hide();
                //pictureBox9.Hide();
                //// Nome Completo
                //label18.Hide();
                //pictureBox8.Hide();
                ////cmb
                //label19.Hide();
                //pictureBox9.Hide();
                //// Conta Existe
                //label20.Hide();
                //pictureBox14.Hide();

                if (txt_password.Text != txt_conpass.Text)
                {
                    pictureBox16.Show();
                    label21.Show();
                    pictureBox17.Hide();
                    label42.Hide();
                }
                else
                {
                    pictureBox16.Hide();
                    label21.Hide();
                    string sql = ("INSERT INTO login(user, Password, nome, email, Pais_idPais, foto) VALUES(@param1, @param2, @param3, @param4, @param5, @param6) ");
                    DataTable dt = new DataTable();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        MemoryStream ms = new MemoryStream();
                        bunifuImageButton1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] arrImage = ms.GetBuffer();
                        try
                        {
                            if (dt.Rows.Count == 0)
                            {
                                label20.Hide();
                                pictureBox14.Hide();
                                conn.Open();
                                cmd.Parameters.AddWithValue("@param1", txt_user.Text);
                                cmd.Parameters.AddWithValue("@param2", txt_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@param3", txt_nome.Text);
                                cmd.Parameters.AddWithValue("@param4", txt_email.Text);
                                cmd.Parameters.AddWithValue("@param5", cmb_nacionalidade.SelectedValue);
                                cmd.Parameters.AddWithValue("@param6", arrImage);
                                da.Fill(dt);
                                bunifuImageButton1.Image = null;
                                bunifuImageButton1.Update();
                                bunifuImageButton1.Image = new Bitmap(Properties.Resources.download);
                                bunifuImageButton1.Update();
                                pictureBox17.Show();
                                label42.Show();
                                txt_email.Clear();
                                txt_user.Clear();
                                txt_password.Clear();
                                txt_conpass.Clear();
                                txt_nome.Clear();
                                cmb_nacionalidade.ResetText();
                            }
                            else
                            {
                                label20.Show();
                                pictureBox14.Show();
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Username já existe");
                        }
                        finally
                        {
                            conn.Close();
                        }
                 
                    }
                    
                 
                }
            }
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm MP = new LoginForm();
            MP.ShowDialog();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
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
                    bunifuImageButton1.Image = Image.FromFile(dialog.FileName);
                    loadedImage = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool ValidarEmail(string strEmail)
        {
            string mail = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, mail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Txt_email_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(txt_email.Text) == false)
            {
                label14.Show();
                pictureBox6.Show();
            }
            else
            {
                label14.Hide();
                pictureBox6.Hide();
            }
        }
    

        private void PictureBox7_Click_1(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            txt_password.UseSystemPasswordChar = true;
        }

        private void PictureBox1_Click_2(object sender, EventArgs e)
        {
            pictureBox7.BringToFront();
            txt_password.UseSystemPasswordChar = false;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox8.BringToFront();
            txt_conpass.UseSystemPasswordChar = true;
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
            txt_conpass.UseSystemPasswordChar = false;
        }
    }
    }

