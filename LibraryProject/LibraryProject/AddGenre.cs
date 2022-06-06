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
    public partial class AddGenre : Form
    {
        public AddGenre()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtGenre = new DataTable();        

        public void tampilData()
        {
            dtGenre = new DataTable();
            sqlQuery = "select KODE_KATEGORI as 'ID Genre', NAMA_KATEGORI as 'Genre', NOMOR_RAK_KATEGORI 'Nomor Rak', DELETE_KATEGORI as 'Status' from KATEGORI_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtGenre);
            dgvGenre.DataSource = dtGenre;
            dgvGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;            
        }

        public void tambahData()
        {
            sqlQuery = "insert into KATEGORI_BUKU (KODE_KATEGORI, NAMA_KATEGORI, NOMOR_RAK_KATEGORI, DELETE_KATEGORI) values ('" + tbGenreID.Text + "', '" + tbGenreName.Text + "', '" + tbRackNum.Text + "', '"+tbStatus.Text+"')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data added successfully");
            Clear();
            tbGenreID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void editData()
        {
            sqlQuery = "update KATEGORI_BUKU set NAMA_KATEGORI = '" + tbGenreName.Text + "', NOMOR_RAK_KATEGORI = '" + tbRackNum.Text + "', DELETE_KATEGORI = '"+tbStatus.Text+"' where KODE_KATEGORI = '" + tbGenreID.Text + "'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data updated successfully");
            Clear();
            tbGenreID.Enabled = true;
            tbGenreID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void Clear()
        {
            tbGenreID.Text = "";
            tbGenreName.Text = "";
            tbRackNum.Text = "";
            tbStatus.Text = "";
        }       

        public void FocusOnEmptyTextBox()
        {
            if (tbGenreID.Text == "")
                tbGenreID.Focus();
            else if (tbGenreName.Text == "")
                tbGenreName.Focus();
            else if (tbRackNum.Text == "")
                tbRackNum.Focus();
            else if (tbStatus.Text == "")
                tbStatus.Focus();
        }

        private void AddGenre_Load(object sender, EventArgs e)
        {
            tampilData();            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {    
            if (tbGenreID.Text == "" || tbGenreName.Text == "" || tbRackNum.Text == "" || tbStatus.Text == "")
            {
                MessageBox.Show("Data is not complete");
                FocusOnEmptyTextBox();
            }
            else
            {
                tambahData();
            }

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbGenreID.Enabled = false;
            DataGridViewRow row = this.dgvGenre.Rows[e.RowIndex];
            tbGenreID.Text = row.Cells["ID Genre"].Value.ToString();
            tbGenreName.Text = row.Cells["Genre"].Value.ToString();
            tbRackNum.Text = row.Cells["Nomor Rak"].Value.ToString();
            tbStatus.Text = row.Cells["Status"].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (tbGenreName.Text == "" || tbRackNum.Text == "" || tbStatus.Text == "")
            {
                MessageBox.Show("Data is not complete");
                FocusOnEmptyTextBox();
            }
            else
            {
                editData();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tbGenreID.Enabled = true;
            tbGenreID.Focus();
            Clear();
        }
    }
}
