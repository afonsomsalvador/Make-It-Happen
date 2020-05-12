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
        public addvoluntariado()
        {
            InitializeComponent();
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Addvoluntariado_Load(object sender, EventArgs e)
        {

        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void Label14_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@param5", textBox8.Text);
                cmd.Parameters.AddWithValue("@param6", textBox9.Text);
                cmd.Parameters.AddWithValue("@param7", textBox10.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
