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

        List<Panels> pnl = new List<Panels>();

        void add()
        {
            string sql = "INSERT INTO voluntariado(nome, descricao) VALUES(@param1, @param2)";
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
            Panels p = new Panels();
            p.Name = "panel" + pnl.Count;
            p.Size = new System.Drawing.Size(1048, 288);
            p.Location = new Point(55, 36);
            PictureBox pb = new PictureBox();
            pb.Name = "picturebox" + pnl.Count;
            pb.Size = new System.Drawing.Size(325, 40);
            pb.Location = new Point(469, 226);
            Button btn = new Button();
            btn.Name = "button" + pnl.Count;
            btn.Size = new System.Drawing.Size(325, 40);
            btn.Location = new Point(469, 226);
            Label lbl = new Label();
            lbl.Name = "label" + pnl.Count;
            lbl.Size = new System.Drawing.Size(325, 40);
            lbl.Location = new Point(469, 226);
            lbl.Text = textBox1.Text;
            TextBox txtbox = new TextBox();
            txtbox.Name = "textbox" + pnl.Count;
            txtbox.Size = new System.Drawing.Size(325, 40);
            txtbox.Location = new Point(469, 226);
            txtbox.Text = textBox2.Text;
            p.Controls.Add(pb);
            p.Controls.Add(btn);
            p.Controls.Add(lbl);
            p.Controls.Add(txtbox);
            pnl.Add(p);
        }
        public addvoluntariado()
        {
            InitializeComponent();
        }

        private void Addvoluntariado_Load(object sender, EventArgs e)
        {

        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            add();
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

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
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

    }
}

