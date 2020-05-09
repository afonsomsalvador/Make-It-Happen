using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Categoria : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador;");
        public Categoria()
        {
            InitializeComponent();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = ("INSERT INTO experiencia(idExperiencia) VALUES(@param1)"); 


            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
            
                    conn.Open();
                    cmd.Parameters.Add("@param1", MySqlDbType.VarChar, 20).Value = textBox1.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
        
            }
        }
    }
}
