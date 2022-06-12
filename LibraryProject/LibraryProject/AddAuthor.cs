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
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtAuthor = new DataTable();
        public void tampilData()
        {
            dtAuthor = new DataTable();
            sqlQuery = "select KODE_PENULIS as 'ID Penulis', NAMA_PENULIS as 'Nama Penulis', TELEPON_PENULIS as 'Telepon', ALAMAT_PENULIS as 'Alamat', DELETE_PENULIS as 'Status' from PENULIS_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtAuthor);
            dgvAuthor.DataSource = dtAuthor;
            dgvAuthor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void tambahData()
        {
            sqlQuery = "insert into PENULIS_BUKU (KODE_PENULIS, NAMA_PENULIS, TELEPON_PENULIS, ALAMAT_PENULIS, DELETE_PENULIS) values ('" + tbAuthorID.Text + "', '" + tbName.Text + "', '" + tbPhone.Text + "', '"+ tbAddress.Text +"', '"+tbStatus.Text+"')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data added successfully");
            Clear();
            tbAuthorID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void editData()
        {
            sqlQuery = "update PENULIS_BUKU set NAMA_PENULIS = '" + tbName.Text + "', TELEPON_PENULIS = '" + tbPhone.Text + "', ALAMAT_PENULIS = '" + tbAddress.Text + "', DELETE_PENULIS = '"+tbStatus.Text+"' where KODE_PENULIS = '" + tbAuthorID.Text + "'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data updated successfully");
            Clear();
            tbAuthorID.Enabled = true;
            tbAuthorID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void Clear()
        {
            tbAuthorID.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
            tbStatus.Text = "";
        }        

        public void FocusOnEmptyTextBox()
        {
            if (tbAuthorID.Text == "")
                tbAuthorID.Focus();
            else if (tbName.Text == "")
                tbName.Focus();
            else if (tbPhone.Text == "")
                tbPhone.Focus();
            else if (tbAddress.Text == "")
                tbAddress.Focus();
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {
            tampilData();
            tbPhone.MaxLength = 13;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tbAuthorID.Text == "" || tbName.Text == "" || tbPhone.Text == "" || tbAddress.Text == "" || tbStatus.Text == "")
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbAddress.Text == "" || tbStatus.Text == "")
            {
                MessageBox.Show("Data is not complete");
                FocusOnEmptyTextBox();
            }
            else
            {
                editData();
            }
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbAuthorID.Enabled = false;
            DataGridViewRow row = this.dgvAuthor.Rows[e.RowIndex];
            tbAuthorID.Text = row.Cells["ID Penulis"].Value.ToString();
            tbName.Text = row.Cells["Nama Penulis"].Value.ToString();
            tbPhone.Text = row.Cells["Telepon"].Value.ToString();
            tbAddress.Text = row.Cells["Alamat"].Value.ToString();
            tbStatus.Text = row.Cells["Status"].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tbAuthorID.Enabled = true;
            tbAuthorID.Focus();
            Clear();
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
