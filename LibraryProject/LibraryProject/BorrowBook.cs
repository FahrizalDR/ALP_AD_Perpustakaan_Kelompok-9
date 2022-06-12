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

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPeminjaman = new DataTable();
        DataTable dtHitung = new DataTable();
        int hitungRows;
        DataTable dtNama = new DataTable();
        DataTable dtBuku = new DataTable();

        public void tampilData()
        {
            dtPeminjaman = new DataTable();
            sqlQuery = "select pb.KODE_PINJAM as 'Borrow ID', pb.KODE_KEMBALI as 'Return ID', pb.NIM_MAHASISWA as 'NIM', pb.KODE_PETUGAS as 'Librarian ID', pb.JUMLAH_BUKU as 'Number of Books', dp.KODE_BUKU as 'Books ID', pb.TANGGAL_PINJAM as 'Borrow Date', pb.TGL_KEMBALI_KONTRAK as 'Return Date Contract' from PEMINJAMAN_BUKU pb, DETAIL_PINJAM dp where pb.KODE_PINJAM = dp.KODE_PINJAM order by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPeminjaman);
            dgvPeminjaman.DataSource = dtPeminjaman;
            dgvPeminjaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void tambahData()
        {
            sqlQuery = "insert into PEMINJAMAN_BUKU (KODE_PINJAM, NIM_MAHASISWA, KODE_KEMBALI, KODE_PETUGAS, JUMLAH_BUKU, TANGGAL_PINJAM, TGL_KEMBALI_KONTRAK, DELETE_PINJAM) values ('" + tbBorrowID.Text + "', '" + tbNIM.Text + "', '" + tbReturnID.Text + "', '" + cbLibrarian.SelectedValue + "','" + nudJumlahBuku.Value + "', '" + dtpBorrow.Value.ToString("yyyy-MM-dd") + "', '" + dtpReturn.Value.ToString("yyyy-MM-dd") + "', '0')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            tampilData();
        }

        public void tambahDataBuku()
        {
            sqlQuery = "insert into DETAIL_PINJAM (KODE_PINJAM, KODE_BUKU) values ('" + tbBorrowID.Text + "', '" + textBoxBooksID.Text + "')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            tampilData();
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
            cbLibrarian.SelectedValue = "";
            nudJumlahBuku.Value = 0;
            textBoxBooksID.Text = "";
            labelBookName1.Text = "1. [...]";
            labelBookName2.Text = "2. [...]";
            dtpBorrow.Value = DateTime.Now;
            dtpReturn.Value = DateTime.Now.AddDays(7);
        }
        public void Hitung()
        {
            dtHitung = new DataTable();
            sqlQuery = "select * from PEMINJAMAN_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHitung);
            hitungRows = dtHitung.Rows.Count + 1;
            if (dtHitung.Rows.Count < 9)
            {
                tbBorrowID.Text = "KP00" + hitungRows.ToString();
                tbReturnID.Text = "PD00" + hitungRows.ToString();
            }
            else if (dtHitung.Rows.Count < 99)
            {
                tbBorrowID.Text = "KP0" + hitungRows.ToString();
                tbReturnID.Text = "PD0" + hitungRows.ToString();
            }
            else if (dtHitung.Rows.Count < 999)
            {
                tbBorrowID.Text = "KP" + hitungRows.ToString();
                tbReturnID.Text = "PD" + hitungRows.ToString();
            }
            else
            {
                MessageBox.Show("Data Penuh");
            }
        }

        public void FocusInEmptyTextBox()
        {
            if (tbBorrowID.Text == "")
                tbBorrowID.Focus();
            else if (tbReturnID.Text == "")
                tbReturnID.Focus();
            else if (tbNIM.Text == "")
                tbNIM.Focus();
            else if (nudJumlahBuku.Value.ToString() == "0")
                nudJumlahBuku.Focus();
            else if (textBoxBooksID.Text == "")
                textBoxBooksID.Focus();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Clear();
            tampilData();
            Librarian();
            tbBorrowID.Enabled = false;
            tbReturnID.Enabled = false;
            dtpReturn.Enabled = false;
            nudJumlahBuku.Maximum = 2;
            Hitung();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tbBorrowID.Text == "" || tbReturnID.Text == "" || tbNIM.Text == "" || nudJumlahBuku.Value.ToString() == "0" || textBoxBooksID.Text == "")
            {
                MessageBox.Show("Data is not complete");
                FocusInEmptyTextBox();
            }
            else
            {
                tambahData();
                tambahDataBuku();
                MessageBox.Show("Data added successfully");
                Clear();
                tbNIM.Focus();
                Hitung(); 
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBorrowID.Enabled = false;
            DataGridViewRow row = this.dgvPeminjaman.Rows[e.RowIndex];
            tbBorrowID.Text = row.Cells["Borrow ID"].Value.ToString();
            tbReturnID.Text = row.Cells["Return ID"].Value.ToString();
            tbNIM.Text = row.Cells["NIM"].Value.ToString();
            cbLibrarian.SelectedValue = row.Cells["Librarian ID"].Value.ToString();
            nudJumlahBuku.Value = Convert.ToDecimal(row.Cells["Number of Books"].Value);
            textBoxBooksID.Text = row.Cells["Books ID"].Value.ToString();
            dtpBorrow.Value = Convert.ToDateTime(row.Cells["Borrow Date"].Value.ToString());
            dtpReturn.Value = Convert.ToDateTime(row.Cells["Return Date Contract"].Value.ToString());

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
            Hitung();
        }

        private void dtpBorrow_ValueChanged(object sender, EventArgs e)
        {
            dtpReturn.Value = dtpBorrow.Value.AddDays(7);
        }

        private void tbNIM_TextChanged(object sender, EventArgs e)
        {
            dtNama = new DataTable();
            sqlQuery = "select NIM_MAHASISWA as 'NIM', NAMA_MAHASISWA as 'Nama Mahasiswa' from MAHASISWA";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNama);
            for (int i = 0; i < dtNama.Rows.Count; i++)
            {
                if (tbNIM.Text == dtNama.Rows[i]["NIM"].ToString())
                {
                    labelNama.Text = dtNama.Rows[i]["Nama Mahasiswa"].ToString();
                    break;
                }
                else
                {
                    labelNama.Text = "[...]";
                }
            }

        }

        private void textBoxBooksID_TextChanged(object sender, EventArgs e)
        {
            dtBuku = new DataTable();
            sqlQuery = "select dp.KODE_BUKU as 'Kode Buku', b.JUDUL_BUKU as 'Judul Buku' from DETAIL_PINJAM dp, BUKU b where dp.KODE_BUKU = b.KODE_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBuku);
            string[] words = textBoxBooksID.Text.Split(' ');
            for (int i = 0; i < dtBuku.Rows.Count; i++)
            {
                if (words[0] == dtBuku.Rows[i]["Kode Buku"].ToString())
                {
                    labelBookName1.Text = "1. " + dtBuku.Rows[i]["Judul Buku"].ToString();
                    break;
                }
                else
                {
                    labelBookName1.Text = "1. [...]";
                }
            }
            if (words.Count() == 2)
            {
                for (int i = 0; i < dtBuku.Rows.Count; i++)
                {
                    if (words[1] == dtBuku.Rows[i]["Kode Buku"].ToString())
                    {
                        labelBookName2.Text = "2. " + dtBuku.Rows[i]["Judul Buku"].ToString();
                        break;
                    }
                    else
                    {
                        labelBookName2.Text = "2. [...]";
                    }
                }
            }
            
        }
    }
}
