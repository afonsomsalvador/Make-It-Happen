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
    public partial class VOLUNTARIADO_CLICK : UserControl
    {
        public VOLUNTARIADO_CLICK()
        {
            InitializeComponent();

        
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.DisplayRectangle, Color.FromArgb(0, 192, 192), ButtonBorderStyle.Dashed);
       
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VOLUNTARIADO_CLICK_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = 548;
            pictureBox1.Height =  377;
        }
    }
}
