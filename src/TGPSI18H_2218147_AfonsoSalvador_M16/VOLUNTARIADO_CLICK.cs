using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class VOLUNTARIADO_CLICK : UserControl
    {
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
    }
}
    

