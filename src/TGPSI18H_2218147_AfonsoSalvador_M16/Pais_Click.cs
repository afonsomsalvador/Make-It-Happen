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
        public string _sql;
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
        public string sql
        {
            get
            {
                return _sql;
            }
            set
            {
                _sql = value;
            }
        }
        public void populateItems(int categoriaId = -1)
        {
            conn.Open();
            string sqlBase = /*sql*/@"SELECT 
                                        c.nome categoriaNome, 
                                        v.idVoluntariado idVoluntariado,
                                        v.imagem imagemvol, 
                                        v.nome nomev, 
                                        p.nome pnome, 
                                        p.imagem imagempais, 
                                        o.nome OrganizacaoNome, 
                                        v.Descricao , 
                                        v.Idade, 
                                        v.Lingua, 
                                        v.Escolaridade, 
                                        v.data, 
                                        v.duracao,
                                        v.alojamento,
                                        v.alimentacao, 
                                        v.transfers, 
                                        v.seguro, 
                                        v.acompanhamento, 
                                        v.localidade , 
                                        v.adicional 
                                    FROM 
                                        voluntariado v 
                                        JOIN categorias c ON  v.Categorias_id_Categoria = c.id_Categoria 
                                        JOIN pais p ON p.idPais = v.pais_idPais 
                                        JOIN organizacao o ON o.idOrganizacao = v.Organizacao_idOrganizacao";


            string sqlWhere = "";
            
            if (categoriaId == 1)
            {
                sqlWhere = $" WHERE c.id_Categoria = {categoriaId}";
            }
            cmd = new MySqlCommand($"{sqlBase} {sqlWhere} ORDER BY c.nome", conn);
            MySqlDataReader dt;
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Panels p = new Panels();
                p.ChavePesquisaID = dt["idVoluntariado"].GetHashCode();
                p.Nome = dt["nomev"].ToString();
                p.Categoria = dt["categoriaNome"].ToString();
                p.Organizacao = dt["OrganizacaoNome"].ToString();
                p.image = $"{ConfigurationManager.AppSettings["filesBasePath"]}{ dt["imagemvol"]}";
                p.bandeira = $"{ConfigurationManager.AppSettings["filesBasePath"]}{ dt["imagempais"]}";
                p.Pais = dt["pnome"].ToString();
                p.ButtonClick += p_ButtonClick;

                flowLayoutPanel1.Controls.Add(p);
            }
            conn.Close();
        }
        public void CarregarDados(int id)
        {
            conn.Open();
            cmd = new MySqlCommand(@"SELECT 
                                        c.nome categoriaNome,
                                        v.idVoluntariado idVoluntariado,
                                        v.imagem imagemvol,
                                        v.nome nomev,
                                        p.nome pnome,
                                        p.imagem imagempais,
                                        o.nome OrganizacaoNome,
                                        v.Descricao descricao,
                                        v.Idade idade,
                                        v.Lingua lingua,
                                        v.Escolaridade escola,
                                        v.data data,
                                        v.duracao duracao,
                                        v.alojamento alojamento,
                                        v.alimentacao alimentacao,
                                        v.transfers transfers,
                                        v.seguro seguro,
                                        v.acompanhamento acompanhamento,
                                        v.localidade localidade,
                                        v.adicional adicional
                                    FROM
                                        voluntariado v
                                        JOIN categorias c ON  v.Categorias_id_Categoria = c.id_Categoria
                                        JOIN pais p ON p.idPais = v.pais_idPais
                                        JOIN organizacao o ON o.idOrganizacao = v.Organizacao_idOrganizacao 
                                    WHERE 
                                        v.idVoluntariado = @idVol
                                         v.pais_idPais = 3
                                    ORDER BY c.nome", conn);
            MySqlDataReader dt;

            cmd.Parameters.AddWithValue("@idVol", id);
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Panels p = new Panels();
                p.ChavePesquisaID = dt["idVoluntariado"].GetHashCode();
                p.Nome = dt["nomev"].ToString();
                p.Categoria = dt["categoriaNome"].ToString();
                p.Organizacao = dt["OrganizacaoNome"].ToString();
                p.image = $"{ConfigurationManager.AppSettings["filesBasePath"]}{ dt["imagemvol"]}";
                p.bandeira = $"{ConfigurationManager.AppSettings["filesBasePath"]}{ dt["imagempais"]}";
                p.Pais = dt["pnome"].ToString();
                p.ButtonClick += p_ButtonClick;

                flowLayoutPanel1.Controls.Add(p);
            }
            conn.Close();
        }
        private void p_ButtonClick(object sender, EventArgs e)
        {
            voluntariadO_CLICK1.CarregarDados((sender as Panels).ChavePesquisaID); 
            voluntariadO_CLICK1.BringToFront();
            voluntariadO_CLICK1.Visible = true;
        }
        private void back(object sender, EventArgs e)
        {
            voluntariadO_CLICK1.SendToBack();
            voluntariadO_CLICK1.Visible = false;
        }
            public Pais_Click()
        {
            InitializeComponent();

            flowLayoutPanel1.Visible = true;
            pictureBox1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            voluntariadO_CLICK1.btn += back;

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

        private void VoluntariadO_CLICK1_Load(object sender, EventArgs e)
        {

        }
    }
}
