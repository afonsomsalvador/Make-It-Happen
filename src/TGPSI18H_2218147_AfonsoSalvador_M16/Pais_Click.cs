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
            cmd = new MySqlCommand("SELECT c.nome categoriaNome, v.imagem imagemvol, v.nome nomev, p.nome pnome, p.imagem imagempais, o.nome OrganizacaoNome, v.Descricao , v.Idade, v.Lingua, v.Escolaridade, v.data, v.duracao, v.alojamento, v.alimentacao, v.transfers, v.seguro, v.acompanhamento, v.localidade , v.adicional FROM voluntariado v JOIN categorias c ON  v.Categorias_id_Categoria = c.id_Categoria JOIN pais p ON p.idPais = v.pais_idPais JOIN organizacao o ON o.idOrganizacao = v.Organizacao_idOrganizacao ORDER BY c.nome", conn);
            MySqlDataReader dt;
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Panels p = new Panels();
                p.Nome = dt["nomev"].ToString();
                p.Categoria = dt["categoriaNome"].ToString();
                p.Organizacao = dt["OrganizacaoNome"].ToString();
                p.image = $"{ConfigurationManager.AppSettings["filesBasePath"]}{ dt["imagemvol"]}";
                p.bandeira = $"{ConfigurationManager.AppSettings["filesBasePath"]}{ dt["imagempais"]}";
                p.Pais = dt["pnome"].ToString();
                p.ButtonClick += new EventHandler(p_ButtonClick);
                VOLUNTARIADO_CLICK vc = new VOLUNTARIADO_CLICK();
                
                


                flowLayoutPanel1.Controls.Add(p);
            }
            conn.Close();
        }
      
        private void p_ButtonClick(object sender, EventArgs e)
        {
            //voluntariadO_CLICK1.BringToFront();
        }
        public Pais_Click()
        {
            InitializeComponent();
            //voluntariadO_CLICK1.Hide();
            panels1.Hide();
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

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
