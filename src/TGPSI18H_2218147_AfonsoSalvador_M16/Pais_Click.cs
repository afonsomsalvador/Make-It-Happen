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
    public partial class Pais_Click : UserControl
    {
        public string texto{
            get
            {
                return label1.Text;
            }
            set
            { 
                label1.Text = value;
            }
        }
        public Pais_Click()
        {
            InitializeComponent();
        }
        //public void SetTextForLabel(string myText)
        //{
        //  this.label1.Text = "Projectos de voluntariado";
        //}
        private void Pais_Click_Load(object sender, EventArgs e)
        {
            label1.Text = texto;
        }
    }
}
