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
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456;database=psi18_afonsosalvador");
        public Categoria()
        {
            InitializeComponent();
           
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            label1.Text = "Vida Marinha";

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.FromArgb(0, 192, 192), ButtonBorderStyle.Dashed);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
