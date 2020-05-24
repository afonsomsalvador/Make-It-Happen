using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Pais_Click : UserControl
    {
        
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        MySqlCommand cmd = new MySqlCommand();
        DataSet dataset = new DataSet();
        
        public string texto
        {
            get
           {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        private void populateItems()
        {
            conn.Open();
            //MySqlDataAdapter da = new MySqlDataAdapter("SELECT nome, descricao, imagem FROM voluntariado WHERE nome LIKE '%" + textBox1 + "%' ORDER BY nome", conn);
            cmd = new MySqlCommand("SELECT nome, descricao, imagem FROM voluntariado");
            //DataTable dt = new DataTable();
            MySqlDataReader dt;
            //da.Fill(dt);
            dt = cmd.ExecuteReader();
            while (dt.Read())
            //for (int i = 0; i < dt.Rows.Count; i++)
            {

                Panels[] panel = new Panels[4];
                panel[4] = new Panels();
                string a = dt["nome"].ToString();
                panel[4].Nome = a.ToString();
                //panel[dt.Rows.Count].Descricao = dt.GetString(1);
                //panel[i].image = "";

                flowLayoutPanel1.Controls.Add(panel[4]);


                //if (flowLayoutPanel1.Controls.Count > 0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                //{

            }
            conn.Close();

            }
            public Pais_Click()
        {
            InitializeComponent();
        }
        private void Pais_Click_Load(object sender, EventArgs e)
        {
            label1.Text = texto;
            populateItems();
            VerticalScroll.Enabled = true;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
