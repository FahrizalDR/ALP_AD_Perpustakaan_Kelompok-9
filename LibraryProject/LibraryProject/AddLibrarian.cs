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
    public partial class AddLibrarian : Form
    {
        public AddLibrarian()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtLibrarian = new DataTable();

        public void tampilData()
        {
            dtLibrarian = new DataTable();
            sqlQuery = "select KODE_PETUGAS as 'Librarian ID', NAMA_PETUGAS as 'Nama', JENIS_KELAMIN_PETUGAS as 'Jenis Kelamin', EMAIL_PETUGAS as 'Email', TELEPON_PETUGAS as 'Telepon', ALAMAT_PETUGAS as 'Alamat', DELETE_PETUGAS as 'Status' from PETUGAS_PERPUSTAKAAN";
            MessageBox.Show(sqlQuery);
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLibrarian);
            dgvLibrarian.DataSource = dtLibrarian;
            dgvLibrarian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void tambahData()
        {
            string Gender = "";
            if (rbMale.Checked == true)
                Gender = "M";
            else
                Gender = "F";

            sqlQuery = "insert into PETUGAS_PERPUSTAKAAN (KODE_PETUGAS, NAMA_PETUGAS, JENIS_KELAMIN_PETUGAS, EMAIL_PETUGAS, TELEPON_PETUGAS, ALAMAT_PETUGAS, DELETE_PETUGAS) values ('" + tbLibrarianID.Text + "', '" + tbLibrarianName.Text + "', '" + Gender + "', '" + tbLibrarianEmail.Text + "', '" + tbLibrarianPhone.Text + "', '" + tbLibrarianAddress.Text + "', + '" + tbStatus.Text + "')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data added successfully");
            Clear();
            tbLibrarianID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void editData()
        {
            string Gender = "";
            if (rbMale.Checked == true)
                Gender = "M";
            else
                Gender = "F";
            sqlQuery = "update PETUGAS_PERPUSTAKAAN set NAMA_PETUGAS = '" + tbLibrarianName.Text + "', JENIS_KELAMIN_PETUGAS = '" + Gender + "', TELEPON_PETUGAS = '" + tbLibrarianPhone.Text + "', ALAMAT_PETUGAS = '" + tbLibrarianAddress.Text + "', EMAIL_PETUGAS = '" + tbLibrarianEmail.Text + "', DELETE_PETUGAS = '" + tbStatus.Text + "' where KODE_PETUGAS = '" + tbLibrarianID.Text + "'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data updated successfully");
            Clear();
            tbLibrarianID.Enabled = true;
            tbLibrarianID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void Clear()
        {
            tbLibrarianID.Text = "";
            tbLibrarianName.Text = "";
            tbLibrarianPhone.Text = "";
            tbLibrarianAddress.Text = "";
            tbLibrarianEmail.Text = "";
            tbStatus.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        public void FocusOnEmptyTextBox()
        {
            if (tbLibrarianID.Text == "")
                tbLibrarianID.Focus();
            else if (tbLibrarianName.Text == "")
                tbLibrarianName.Focus();
            else if (tbLibrarianPhone.Text == "")
                tbLibrarianPhone.Focus();
            else if (tbLibrarianAddress.Text == "")
                tbLibrarianAddress.Focus();
            else if (tbLibrarianEmail.Text == "")
                tbLibrarianEmail.Focus();
            else if (tbStatus.Text == "")
                tbStatus.Focus();
        }

        private void AddLibrarian_Load(object sender, EventArgs e)
        {
            tampilData();
            tbLibrarianPhone.MaxLength = 13;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tbLibrarianID.Text == "" || tbLibrarianName.Text == "" || tbLibrarianPhone.Text == "" || tbLibrarianAddress.Text == "" || tbLibrarianEmail.Text == "" || tbStatus.Text == "")
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
            if (tbLibrarianName.Text == "" || tbLibrarianPhone.Text == "" || tbLibrarianAddress.Text == "" || tbLibrarianEmail.Text == "" || tbStatus.Text == "")
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
            tbLibrarianID.Enabled = true;
            tbLibrarianID.Focus();
            Clear();
        }

        private void dgvLibrarian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbLibrarianID.Enabled = false;
            DataGridViewRow row = this.dgvLibrarian.Rows[e.RowIndex];
            tbLibrarianID.Text = row.Cells["Librarian ID"].Value.ToString();
            tbLibrarianName.Text = row.Cells["Nama"].Value.ToString();
            tbLibrarianPhone.Text = row.Cells["Telepon"].Value.ToString();
            tbLibrarianAddress.Text = row.Cells["Alamat"].Value.ToString();
            tbLibrarianEmail.Text = row.Cells["Email"].Value.ToString();
            tbStatus.Text = row.Cells["Status"].Value.ToString();
        }

        private void tbMemberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddLibrarian_Load_1(object sender, EventArgs e)
        {
            tampilData();
        }
    }
}
