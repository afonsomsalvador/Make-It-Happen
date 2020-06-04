using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Pais_Click : UserControl
    {
        
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        MySqlCommand cmd = new MySqlCommand();
        
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
        public void populateItems()
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT nome, imagem, Categorias_id_Categoria, Organizacao_idOrganizacao, Pais_idPais FROM voluntariado where nome like '"+ textBox1.Text +"%' order by nome", conn);
            MySqlDataReader dt;
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Panels p = new Panels();
                p.Nome = dt["nome"].ToString();
                p.Categoria = dt["Categorias_id_Categoria"].ToString();
                p.Organizacao = dt["Organizacao_idOrganizacao"].ToString();
                p.image = $"{ConfigurationManager.AppSettings["filesBasePath"]}{ dt["imagem"]}";
                p.Pais = dt["Pais_idPais"].ToString();
                //p.ButtonClick += new EventHandler(p_ButtonClick);
                


                flowLayoutPanel1.Controls.Add(p);
            }
            conn.Close();
        }
        private void p_ButtonClick(object sender, EventArgs e)
        {
            voluntariadO_CLICK1.BringToFront();
        }
        public Pais_Click()
        {
            InitializeComponent();
            voluntariadO_CLICK1.Hide();
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
