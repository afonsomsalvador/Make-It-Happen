using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Categoria : UserControl
    {
        public event EventHandler ButtonClick1;

        public event EventHandler ButtonClick2;

        public event EventHandler ButtonClick3;

        public Categoria()
        {
            InitializeComponent();
            pais_Click1.Hide();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            label1.Text = "Vida Marinha";
            label2.Text = "Ensino";
            label3.Text = "Vida Terrestre";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.FromArgb(0, 192, 192), ButtonBorderStyle.Dashed);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (this.ButtonClick1 != null)
                this.ButtonClick1(this, new EventArgs());
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.FromArgb(0, 192, 192), ButtonBorderStyle.Dashed);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick2 != null)
                this.ButtonClick2(this, new EventArgs());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick3 != null)
                this.ButtonClick3(this, new EventArgs());
        }

        private void Pais_Click1_Load(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.FromArgb(0, 192, 192), ButtonBorderStyle.Dashed);
        }

        private void Pais_Click1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
