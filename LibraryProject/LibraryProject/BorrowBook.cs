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
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPeminjaman = new DataTable();

        public void tampilData()
        {
            sqlQuery = "select * from PEMINJAMAN_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPeminjaman);
            dgvPeminjaman.DataSource = dtPeminjaman;
            dgvPeminjaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void tambahData()
        {
            //sqlQuery = "insert into PEMINJAMAN_BUKU (KODE_PINJAM, NIM_MAHASISWA, KODE_KEMBALI, KODE_PETUGAS, DELETE_PINJAM) values ('" + tbBorrowID.Text + "', '" + tbNIM.Text + "', '" + tbReturnID.Text + "', '" + cbLibrarian.SelectedValue + "', '0')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data added successfully");
            Clear();
            tbBorrowID.Focus();
            sqlConnect.Close();
        }

        public void Librarian()
        {
            DataTable dtLibrarian = new DataTable();
            sqlQuery = "select KODE_PETUGAS as 'Librarian ID', NAMA_PETUGAS as 'Nama' from PETUGAS_PERPUSTAKAAN";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLibrarian);
            cbLibrarian.DataSource = dtLibrarian;
            cbLibrarian.DisplayMember = "Nama";
            cbLibrarian.ValueMember = "Librarian ID";
        }
        public void Clear()
        {
            tbBorrowID.Text = "";
            tbReturnID.Text = "";
            tbNIM.Text = "";          
        }

        public void FocusInEmptyTextBox()
        {
            if (tbBorrowID.Text == "")
                tbBorrowID.Focus();
            else if (tbReturnID.Text == "")
                tbReturnID.Focus();
            else if (tbNIM.Text == "")
                tbNIM.Focus();            
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            tampilData();
            Librarian();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tbBorrowID.Text == "" || tbReturnID.Text == "" || tbNIM.Text == "")
            {
                MessageBox.Show("Data is not complete");
                FocusInEmptyTextBox();
            }
            else
            {
                tambahData();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
