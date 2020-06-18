using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public delegate void MyEventHandler();

    [System.ComponentModel.DefaultEvent("ButtonClicked")]
    public partial class Panels : UserControl
    {


        public event EventHandler ButtonClick;


        public Panels()
        {
            InitializeComponent();
        }



        public int ChavePesquisaID
        { get
                ;
            set
                ;
        }

        private string _nome;
        private string _Categoria;
        private string _Pais;
        private string _Organizacao;
        private string _image;
        private string _bandeira;
        
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                label2.Text = value;
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
                label4.Text = value;
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
                label3.Text = value;
            }
        }
       
        public string Pais
        {
            get
            {
                return _Pais;
            }
            set
            {
                _Pais = value;
                label1.Text = value;
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
        public string bandeira
        {
            get
            {
                return _bandeira;
            }
            set
            {
                if (File.Exists(value))
                    pictureBox2.Image = System.Drawing.Image.FromFile(value);
                _bandeira = value;
            }
        }
     

    private void Panel_Load(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, new EventArgs());

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panels_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
