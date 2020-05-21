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
            string sql = ("SELECT nome, descricao, imagem from voluntariado where nome like '%" + textBox1 + "%' order by nome");
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                          MySqlDataReader dr;

                dr = cmd.ExecuteReader();
                dr.Read();

                        Panels[] panel = new Panels[dr.FieldCount];
                        panel[dr.FieldCount] = new Panels();
                        panel[dr.FieldCount].Nome = dr.GetString(0);
                        panel[dr.FieldCount].Descricao = dr.GetString(1);
                //panel[i].image = "";

                flowLayoutPanel1.Controls.Add(panel[dr.FieldCount]);

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
