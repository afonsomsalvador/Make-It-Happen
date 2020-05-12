using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class addvoluntariado : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456;database=psi18_afonsosalvador");

        List<Panel> pnl = new List<Panel>();
        public addvoluntariado()
        {
            InitializeComponent();
        }

        private void Addvoluntariado_Load(object sender, EventArgs e)
        {

        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO voluntariado(descricao, nome) VALUES(@param1, @param2)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@param1", textBox1.Text);
                cmd.Parameters.AddWithValue("@param2", textBox2.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            string sql1 = "INSERT INTO detalhes(data, duracao, alojamento, alimentacao, transfers, seguro, acompanhamento, adicional) VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@param1", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@param2", textBox3.Text);
                cmd.Parameters.AddWithValue("@param3", textBox4.Text);
                cmd.Parameters.AddWithValue("@param4", textBox6.Text);
                cmd.Parameters.AddWithValue("@param5", textBox7.Text);
                cmd.Parameters.AddWithValue("@param6", textBox8.Text);
                cmd.Parameters.AddWithValue("@param7", textBox9.Text);
                cmd.Parameters.AddWithValue("@param8", textBox10.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            string sql2 = "INSERT INTO requisitos(Idade, Lingua, Escolaridade) VALUES(@param1, @param2, @param3)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@param1", textBox12.Text);
                cmd.Parameters.AddWithValue("@param2", textBox13.Text);
                cmd.Parameters.AddWithValue("@param3", textBox14.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            string sql3 = "INSERT INTO experiencia(tipo_experiencia) VALUES(@param1)";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@param1", textBox11.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            //int x = 0;
            //int y = 0;
            //int delta = 10;
            //for (int i = 0; i < .Count; i++)
            //{

            //    Panel p = new Panel();
            //    p.Name = "panel" + i;
            //    pnl.Add(p);

            //    // Create picture box
            //    var picture = new PictureBox();
            //    picture.Location = new Point(x, y);
            //    picture.Size = new Size(picture.Image.Width, picture.Image.Height);
            //    int dx = picture.Width + delta;
            //    // Create name label
            //    var labelName = new Label();
            //    labelName.AutoSize = true;
            //    labelName.Location = new Point(x + dx, y);
            //    labelName.Font = new Font(labelName.Font, FontStyle.Bold);
            //    // Create mail label
            //    var labelMail = new Label();
            //    labelMail.AutoSize = true;
            //    labelMail.Location = new Point(x + dx, y + labelName.Height);
            //    // Create phone label
            //    var labelPhone = new Label();
            //    labelPhone.AutoSize = true;
            //    labelPhone.Location = new Point(x + dx, y + labelName.Height + labelMail.Height);
            //    //// Add controls
            //    //panel.Controls.Add(picture);
            //    //panel.Controls.Add(labelName);
            //    //panel.Controls.Add(labelMail);
            //    //panel.Controls.Add(labelPhone);
            //    // Iterate
            //    int dy1 = labelName.Height + labelMail.Height + labelPhone.Height;
            //    int dy2 = picture.Height;
            //    y += Math.Max(dy1, dy2) + delta;
            //}
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
