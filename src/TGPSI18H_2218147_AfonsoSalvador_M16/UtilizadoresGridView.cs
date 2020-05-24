using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class UtilizadoresGridView : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        public UtilizadoresGridView()
        {
            InitializeComponent();
           
            conn.Open();
            string query = "SELECT * FROM login";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
           

        }
        
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UtilizadoresGridView_Load(object sender, EventArgs e)
        {
            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //string s = "Select * from login";
            //MySqlDataReader reader = cmd.ExecuteReader();
            //dataGridView1.DataSource = reader;
            //MySqlDataAdapter dataadapter = new MySqlDataAdapter(s, conn);
            //DataSet ds = new DataSet();
            //conn.Open();
            //dataadapter.Fill(ds, "login");
            //conn.Close();
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "login";


            
            //dataGridView1.ColumnCount = 3;
            //dataGridView1.Columns[0].Name = "Product ID";
            //dataGridView1.Columns[1].Name = "Product Name";
            //dataGridView1.Columns[2].Name = "Product Price";

            //string[] row = new string[] { "1", "Product 1", "1000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "2", "Product 2", "2000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "3", "Product 3", "3000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "4", "Product 4", "4000" };
            //dataGridView1.Rows.Add(row);

            //dataGridView1.Rows[1].ReadOnly = true;
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
         
        }

        private void DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
   
        }
    }
}
