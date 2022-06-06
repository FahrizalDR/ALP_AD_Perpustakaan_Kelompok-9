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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtBook = new DataTable();

        public void tampilData()
        {
            dtBook = new DataTable();
            sqlQuery = "select KODE_BUKU as 'ID Buku', KODE_KATEGORI as 'ID Genre', KODE_PENERBIT as 'ID Penerbit', KODE_PENULIS as 'ID Penulis', JUDUL_BUKU as 'Judul Buku', TAHUN_TERBIT_BUKU as 'Tahun Terbit', BAHASA_BUKU as 'Bahasa', EDISI_BUKU as 'Edisi', DELETE_BUKU as 'Status' from BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBook);
            dgvBook.DataSource = dtBook;
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadGenre()
        {
            DataTable dtGenre = new DataTable();
            sqlQuery = "select KODE_KATEGORI as 'Genre ID', NAMA_KATEGORI as 'Nama' from KATEGORI_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtGenre);
            cbGenre.DataSource = dtGenre;
            cbGenre.DisplayMember = "Nama";
            cbGenre.ValueMember = "Genre ID";
        }

        public void LoadAuthor()
        {
            DataTable dtAuthor = new DataTable();
            sqlQuery = "select KODE_PENULIS as 'Author ID', NAMA_PENULIS as 'Nama' from PENULIS_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtAuthor);
            cbAuthor.DataSource = dtAuthor;
            cbAuthor.DisplayMember = "Nama";
            cbAuthor.ValueMember = "Author ID";
        }

        public void LoadPublisher()
        {
            DataTable dtPublisher = new DataTable();
            sqlQuery = "select KODE_PENERBIT as 'Publisher ID', NAMA_PENERBIT as 'Nama' from PENERBIT_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPublisher);
            cbPublisher.DataSource = dtPublisher;
            cbPublisher.DisplayMember = "Nama";
            cbPublisher.ValueMember = "Publisher ID";
        }

        public void tambahData()
        {
            sqlQuery = "insert into BUKU (KODE_BUKU, KODE_KATEGORI, KODE_PENERBIT, KODE_PENULIS, JUDUL_BUKU, TAHUN_TERBIT_BUKU, BAHASA_BUKU, EDISI_BUKU, DELETE_BUKU) values ('" + tbBookID.Text + "', '" + cbGenre.SelectedValue + "', '" + cbPublisher.SelectedValue + "', '"+ cbAuthor.SelectedValue +"', '"+ tbTitle.Text +"', '"+ tbYear.Text +"', '"+tbLanguage.Text+"', '"+tbEdition.Text+"', '"+tbStatus.Text+"')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data added successfully");
            Clear();            
            tbBookID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void editData()
        {
            sqlQuery = "update BUKU set KODE_KATEGORI = '" + cbGenre.SelectedValue + "', KODE_PENERBIT = '" + cbPublisher.SelectedValue + "', KODE_PENULIS = '" + cbAuthor.SelectedValue + "', JUDUL_BUKU = '"+ tbTitle.Text +"', TAHUN_TERBIT_BUKU = '"+ tbYear.Text +"', BAHASA_BUKU = '"+ tbLanguage.Text +"', EDISI_BUKU = '"+ tbEdition.Text +"', DELETE_BUKU = '"+tbStatus.Text+"' where KODE_BUKU = '" + tbBookID.Text + "'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data updated successfully");
            Clear();
            tbBookID.Enabled = true;
            tbBookID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void Clear()
        {
            tbBookID.Text = "";
            tbTitle.Text = "";
            tbYear.Text = "";
            tbEdition.Text = "";
            tbLanguage.Text = "";
            tbStatus.Text = "";
        }
        public void FocusOnEmptyTextBox()
        {
            if (tbBookID.Text == "")
                tbBookID.Focus();
            else if (tbTitle.Text == "")
                tbTitle.Focus();
            else if (tbYear.Text == "")
                tbYear.Focus();
            else if (tbLanguage.Text == "")
                tbLanguage.Focus();
            else if (tbEdition.Text == "")
                tbEdition.Focus();
            else if (tbStatus.Text == "")
                tbStatus.Focus();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tbBookID.Text == "" || tbTitle.Text == "" || tbYear.Text == "" || tbLanguage.Text == "" || tbEdition.Text == "" || tbStatus.Text == "")
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

        private void AddBook_Load(object sender, EventArgs e)
        {
            tampilData();
            LoadGenre();
            LoadAuthor();
            LoadPublisher();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "" || tbYear.Text == "" || tbEdition.Text == "" || tbLanguage.Text == "" || tbStatus.Text == "")
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
            tbBookID.Enabled = true;
            tbBookID.Focus();
            Clear();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBookID.Enabled = false;
            DataGridViewRow row = this.dgvBook.Rows[e.RowIndex];
            tbBookID.Text = row.Cells["ID Buku"].Value.ToString();
            cbGenre.SelectedValue = row.Cells["ID Genre"].Value.ToString();
            cbPublisher.SelectedValue = row.Cells["ID Penerbit"].Value.ToString();
            cbAuthor.SelectedValue = row.Cells["ID Penulis"].Value.ToString();
            tbTitle.Text = row.Cells["Judul Buku"].Value.ToString();
            tbYear.Text = row.Cells["Tahun Terbit"].Value.ToString();
            tbLanguage.Text = row.Cells["Bahasa"].Value.ToString();
            tbEdition.Text = row.Cells["Edisi"].Value.ToString();
            tbStatus.Text = row.Cells["Status"].Value.ToString();
        }
    }
}
