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
        DataTable dtNama = new DataTable();
        DataTable dtBuku = new DataTable();
        DataTable dtCariPengembalian = new DataTable();
        DataTable dtDenda = new DataTable();
        string kodeDenda;

        public void tampilData()
        {
            dtPengembalian = new DataTable();
            sqlQuery = "select pb.KODE_PINJAM as 'Borrow ID', pb.KODE_KEMBALI as 'Return ID', m.NIM_MAHASISWA as 'NIM', m.NAMA_MAHASISWA as 'Name', pb.JUMLAH_BUKU as 'Number of Books', dp.KODE_BUKU as 'Books ID', pb.TGL_KEMBALI_KONTRAK as 'Return Date Contract' from PEMINJAMAN_BUKU pb, MAHASISWA m, DETAIL_PINJAM dp where dp.KODE_PINJAM not in (SELECT KODE_PINJAM FROM PENGEMBALIAN_BUKU) and m.NIM_MAHASISWA = pb.NIM_MAHASISWA and dp.KODE_PINJAM = pb.KODE_PINJAM;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPengembalian);
            dgvPengembalian.DataSource = dtPengembalian;
            dgvPengembalian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void tambahData()
        {
            sqlQuery = "insert into PENGEMBALIAN_BUKU (KODE_KEMBALI, KODE_PINJAM, KODE_DENDA, KODE_PETUGAS, TANGGAL_KEMBALI_REAL, TOTAL_DENDA, KETERANGAN, DELETE_KEMBALI) values ('" + txtboxBorrowID.Text + "', '" + txtboxReturnID.Text + "', '"+ kodeDenda +"', '" + chckboxLibrarian.SelectedValue.ToString() + "','"+ dtpReturnReal.Value.ToString("yyyy-MM-dd") +"', '"+ totalDenda.ToString() +"','"+ textBoxDescription.Text +"', '0')";
            MessageBox.Show(sqlQuery);
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show(sqlQuery);
            Clear();
            txtboxNIM.Focus();
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
        public void TampilBuku()
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
        public void Clear()
        {
            txtboxBorrowID.Text = "";
            txtboxReturnID.Text = "";
            txtboxNIM.Text = "";
            labelNama.Text = "[...]";
            chckboxLibrarian.Text = "";
            nudJumlahBuku.Value = 0;
            textBoxBooksID.Text = "";
            labelBookName1.Text = "1. [...]";
            labelBookName2.Text = "2. [...]";
            dtpReturnContract.Value = DateTime.Now;
            dtpReturnReal.Value = DateTime.Now;
            textBoxFine.Text = "";
            textBoxDescription.Text = "";
        }
        public void SearchData()
        {
            dtCariPengembalian = new DataTable();
            sqlQuery = "select pb.KODE_PINJAM as 'Borrow ID', pb.KODE_KEMBALI as 'Return ID', m.NIM_MAHASISWA as 'NIM', m.NAMA_MAHASISWA as 'Name', pb.JUMLAH_BUKU as 'Number of Books', dp.KODE_BUKU as 'Books ID', pb.TGL_KEMBALI_KONTRAK as 'Return Date Contract' from PEMINJAMAN_BUKU pb, MAHASISWA m, DETAIL_PINJAM dp where dp.KODE_PINJAM not in (SELECT KODE_PINJAM FROM PENGEMBALIAN_BUKU) and m.NIM_MAHASISWA = pb.NIM_MAHASISWA and dp.KODE_PINJAM = pb.KODE_PINJAM and pb.NIM_MAHASISWA = '"+ txtboxNIM.Text +"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCariPengembalian);
            if (dtCariPengembalian.Rows.Count > 0)
            {
                txtboxBorrowID.Text = dtCariPengembalian.Rows[0]["Borrow ID"].ToString();
                txtboxReturnID.Text = dtCariPengembalian.Rows[0]["Return ID"].ToString();
                nudJumlahBuku.Text = dtCariPengembalian.Rows[0]["Number of Books"].ToString();
                textBoxBooksID.Text = dtCariPengembalian.Rows[0]["Books ID"].ToString();
                dtpReturnContract.Value = Convert.ToDateTime(dtCariPengembalian.Rows[0]["Return Date Contract"].ToString());
                MessageBox.Show("Data Found");
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
           
        }

        public void FocusInEmptyTextBox()
        {
            if (txtboxBorrowID.Text == "")
                txtboxBorrowID.Focus();
            else if (txtboxReturnID.Text == "")
                txtboxReturnID.Focus();
            else if (txtboxNIM.Text == "")
                txtboxNIM.Focus();
            else if (textBoxBooksID.Text == "")
                textBoxBooksID.Focus();
        }

        private void ReturnBook_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tampilData();
            Librarian();
            txtboxBorrowID.Enabled = false;
            txtboxReturnID.Enabled = false;
            nudJumlahBuku.Enabled = false;
            textBoxBooksID.Enabled = false;
            dtpReturnContract.Enabled = false;
            textBoxFine.Enabled = false;
        }

        private void buttonReturn_Click_1(object sender, EventArgs e)
        {
            if (txtboxBorrowID.Text == "" || txtboxReturnID.Text == "" || txtboxNIM.Text == "" || textBoxBooksID.Text == "" || textBoxFine.Text =="")
            {
                MessageBox.Show("Data is not complete");
                FocusInEmptyTextBox();
            }
            else
            {
                tambahData();
                MessageBox.Show("Return Book successfully");
                Clear();
            }
            
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxNIM_TextChanged(object sender, EventArgs e)
        {
            dtNama = new DataTable();
            sqlQuery = "select NIM_MAHASISWA as 'NIM', NAMA_MAHASISWA as 'Nama Mahasiswa' from MAHASISWA";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNama);
            for (int i = 0; i < dtNama.Rows.Count; i++)
            {
                if (txtboxNIM.Text == dtNama.Rows[i]["NIM"].ToString())
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

        private void dgvPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPengembalian.Rows[e.RowIndex];
            txtboxBorrowID.Text = row.Cells["Borrow ID"].Value.ToString();
            txtboxReturnID.Text = row.Cells["Return ID"].Value.ToString();
            txtboxNIM.Text = row.Cells["NIM"].Value.ToString();
            nudJumlahBuku.Value = Convert.ToDecimal(row.Cells["Number of Books"].Value);
            textBoxBooksID.Text = row.Cells["Books ID"].Value.ToString();
            dtpReturnContract.Value = Convert.ToDateTime(row.Cells["Return Date Contract"].Value.ToString());
            TampilBuku();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchData();
            TampilBuku();
        }
        int hitungKeterlambatan = 0, totalDenda = 0;
       
        private void buttonCheckFine_Click(object sender, EventArgs e)
        {
            hitungKeterlambatan = (dtpReturnReal.Value - dtpReturnContract.Value).Days;
            dtDenda = new DataTable();
            sqlQuery = "select BATAS_MAX_TELAT as 'Late Deadline', KODE_DENDA as 'Fine ID', BIAYA_DENDA as 'Late Fine Fees' from DENDA";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDenda);
            for (int i = dtDenda.Rows.Count - 1; i >= 0; i--)
            {
                if (hitungKeterlambatan >= Convert.ToInt32(dtDenda.Rows[i]["Late Deadline"]))
                {
                    hitungKeterlambatan = hitungKeterlambatan - Convert.ToInt32(dtDenda.Rows[i]["Late Deadline"]);
                    kodeDenda = dtDenda.Rows[i]["Fine ID"].ToString();
                    totalDenda = Convert.ToInt32(dtDenda.Rows[i]["Late Fine Fees"]);
                    textBoxFine.Text = totalDenda.ToString();
                    break;
                }
                else
                {
                    textBoxFine.Text = "0";
                }
            }
            
        }
    }
}