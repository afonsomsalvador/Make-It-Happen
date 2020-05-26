using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Forgot : UserControl
    {
        string randomCode = "";
        string _fromMail, _toMail, _subjectMail, _bodyMail;

        string _key;
        public static string to;
        public Forgot()
        {
            InitializeComponent();
            try
            {
                using (MailMessage mailmessage = new MailMessage(_fromMail, _toMail))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    mailmessage.Subject = _subjectMail;
                    mailmessage.Body = _bodyMail;

                    smtpClient.Host = "smtp.mail.ru";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(_fromMail, _key);
                    smtpClient.Send(mailmessage);
                    System.Windows.Forms.MessageBox.Show("Ваше письмо отправлено!", "Информация!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Внимательно проверьте данные!", "Ошибка!!!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Forgot_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
