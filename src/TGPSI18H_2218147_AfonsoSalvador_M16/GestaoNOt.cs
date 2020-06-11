using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class GestaoNews : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=psi18_afonsosalvador");
        int bookId = 0;
        //string sql = $@"DELETE FROM Book
        //                      WHERE BookID = {bookId};";
        public GestaoNews()
        {
            InitializeComponent();
            conn.Open();
            string query = "SELECT * FROM noticias";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (MySqlCommand mySqlCmd = new MySqlCommand(/*sql, conn*/))
            {
                conn.Open();
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_BookID", bookId);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Noticia Eliminada");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
