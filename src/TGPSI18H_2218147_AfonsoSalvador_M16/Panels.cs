using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Panels : UserControl
    {
        public Panels()
        {
            InitializeComponent();
        }

        private string _nome;
        private string _descricao;
        private Image _image;
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
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                _descricao = value;
                richTextBox1.Text = value;
            }
        }
        public Image image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                pictureBox1.Image = value;
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
    }
}
