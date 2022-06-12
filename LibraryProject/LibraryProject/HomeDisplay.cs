using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryProject
{
    public partial class HomeDisplay : Form
    {
        public HomeDisplay()
        {
            InitializeComponent();
        }
        
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtBuku = new DataTable();        

        private void HomeDisplay_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            sqlQuery = "select JUDUL_BUKU from BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBuku);
            dgvPlayer.DataSource = dtBuku;
            dgvPlayer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            DataView dataView = dtBuku.DefaultView;
            dataView.RowFilter = string.Format("JUDUL_BUKU like '" + textBoxSearch.Text + "%'");
            dgvPlayer.DataSource = dataView.ToTable();
        }        
    }
}
