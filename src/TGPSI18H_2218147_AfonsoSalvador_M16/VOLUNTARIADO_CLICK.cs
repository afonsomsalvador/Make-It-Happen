using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class VOLUNTARIADO_CLICK : UserControl
    {

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        MySqlCommand cmd = new MySqlCommand();

        public VOLUNTARIADO_CLICK()
        {
            InitializeComponent();


        }
        private string _nome;
        private string _Categoria;
        private string _Organizacao;
        private string _image;
        public string _Descricao;
        public string _Idade;
        public string _Lingua;
        public string _Escolaridade;
        public string _Data;
        public string _Duracao;
        public string _Alojamento;
        public string _Alimentacao;
        public string _Transfers;
        public string _Seguro;
        public string _Acompanhamento;
        public string _Localidade;
        public string _Adicional;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                label1.Text = value;
            }
        }
        public string Categoria
        {
            get
            {
                return _Categoria;
            }
            set
            {
                _Categoria = value;
                label18.Text = value;
            }
        }
        public string Organizacao
        {
            get
            {
                return _Organizacao;
            }
            set
            {
                _Organizacao = value;
                label2.Text = value;
            }
        }
        public string image
        {
            get
            {
                return _image;
            }
            set
            {
                if (File.Exists(value))
                    pictureBox1.Image = System.Drawing.Image.FromFile(value);

                _image = value;
            }
        }
        public string Descricao
        {
            get
            {
                return _Descricao;
            }
            set
            {
                _Descricao = value;
                groupBox1.Text = value;
            }
        }
        public string Idade
        {
            get
            {
                return _Idade;
            }
            set
            {
                _Idade = value;
                label14.Text = value;
            }
        }
        public string Lingua
        {
            get
            {
                return _Lingua;
            }
            set
            {
                _Lingua = value;
                label12.Text = value;
            }
        }
        public string Escolaridade
        {
            get
            {
                return _Escolaridade;
            }
            set
            {
                _Escolaridade = value;
                label13.Text = value;
            }
        }
        public string Data
        {
            get
            {
                return _Data;
            }
            set
            {
                _Data = value;
                label8.Text = value;
            }
        }
        public string Duracao
        {
            get
            {
                return _Duracao;
            }
            set
            {
                _Duracao = value;
                label5.Text = value;
            }
        }
        public string Alojamento
        {
            get
            {
                return _Alojamento;
            }
            set
            {
                _Alojamento = value;
                label4.Text = value;
            }
        }
        public string Alimentacao
        {
            get
            {
                return _Alimentacao;
            }
            set
            {
                _Alimentacao = value;
                label6.Text = value;
            }
        }
        public string Transfers
        {
            get
            {
                return _Transfers;
            }
            set
            {
                _Transfers = value;
                label7.Text = value;
            }
        }
        public string Seguro
        {
            get
            {
                return _Seguro;
            }
            set
            {
                _Seguro = value;
                label10.Text = value;
            }
        }
        public string Acompanhamento
        {
            get
            {
                return _Acompanhamento;
            }
            set
            {
                _Acompanhamento = value;
                label17.Text = value;
            }
        }
        public string Localidade
        {
            get
            {
                return _Localidade;
            }
            set
            {
                _Localidade = value;
                label3.Text = value;
            }
        }
        public string Adicional
        {
            get
            {
                return _Adicional;
            }
            set
            {
                _Adicional = value;
                label11.Text = value;
            }
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
                                        JOIN organizacao o ON o.idOrganizacao = v.Organizacao_idOrganizacao ORDER BY c.nome", conn);
            MySqlDataReader dt;
            dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                VOLUNTARIADO_CLICK vc = new VOLUNTARIADO_CLICK();
                label1.Text = dt["nomev"].ToString();
                label18.Text = dt["categoriaNome"].ToString();
                label2.Text = dt["OrganizacaoNome"].ToString();
                pictureBox1.Image = Image.FromFile($"{ConfigurationManager.AppSettings["filesBasePath"]}{ dt["imagemvol"]}");
                groupBox1.Text = dt["descricao"].ToString();
                label14.Text = dt["idade"].ToString();
                label12.Text = dt["lingua"].ToString();
                label13.Text = dt["escola"].ToString();
                label8.Text = dt["data"].ToString();
                label5.Text = dt["duracao"].ToString();
                label4.Text = dt["alojamento"].ToString();
                label6.Text = dt["alimentacao"].ToString();
                label7.Text = dt["transfers"].ToString();
                label10.Text = dt["seguro"].ToString();
                label17.Text = dt["acompanhamento"].ToString();
                label3.Text = dt["localidade"].ToString();
                label11.Text = dt["adicional"].ToString();
            }
            conn.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.DisplayRectangle, Color.FromArgb(0, 192, 192), ButtonBorderStyle.Dashed);

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void VOLUNTARIADO_CLICK_Load(object sender, EventArgs e)
        {

        }
    }
}
    

