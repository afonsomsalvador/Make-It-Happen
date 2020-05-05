using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class Social : Form
    {
        public Social()
        {
            InitializeComponent();
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            button4.ForeColor = Color.Wheat;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            button3.ForeColor = Color.Wheat;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.ForeColor = Color.Wheat;
            button4.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            button2.ForeColor = Color.Wheat;
            button1.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button3.ForeColor = Color.White;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            button4.ForeColor = Color.Wheat;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
        }

        private void Btnuploadimage_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    bunifuImageButton1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro !!","Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

     
    }
}
