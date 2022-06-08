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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPengembalian = new DataTable();

        public void tampilData()
        {
            sqlQuery = "SELECT * from PENGEMBALIAN_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPengembalian);
            dgvPengembalian.DataSource = dtPengembalian;
            dgvPengembalian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void tambahData()
        {
            sqlQuery = "insert into PENGEMBALIAN_BUKU (KODE_PINJAM, KODE_DENDA, TANGGAL_KEMBALI_REAL, KODE_KEMBALI, KODE_PETUGAS, TOTAL_DENDA, KETERANGAN, DELETE_KEMBALI) values ('" + txtboxBorrowID.Text + "', '" + txtboxNIM.Text + "', '" + txtboxReturnID.Text + "', '" + chckboxLibrarian.SelectedValue + "', '0')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            Clear();
            txtboxBorrowID.Focus();
            sqlConnect.Close();
        }

        public void Librarian()
        {
            DataTable dtLibrarian = new DataTable();
            sqlQuery = "select KODE_PETUGAS as 'Librarian ID', NAMA_PETUGAS as 'Nama' from PETUGAS_PERPUSTAKAAN";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLibrarian);
            chckboxLibrarian.DataSource = dtLibrarian;
            chckboxLibrarian.DisplayMember = "Nama";
            chckboxLibrarian.ValueMember = "Librarian ID";
        }
        public void Clear()
        {
            txtboxBorrowID.Text = "";
            txtboxReturnID.Text = "";
            txtboxNIM.Text = "";
        }

        public void FocusInEmptyTextBox()
        {
            if (txtboxBorrowID.Text == "")
                txtboxBorrowID.Focus();
            else if (txtboxReturnID.Text == "")
                txtboxReturnID.Focus();
            else if (txtboxNIM.Text == "")
                txtboxNIM.Focus();
        }

        private void ReturnBook_Load_1(object sender, EventArgs e)
        {
            tampilData();
            Librarian();
        }

        private void buttonReturn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Return Book successfully");
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}