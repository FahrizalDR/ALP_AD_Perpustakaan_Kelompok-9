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
    public partial class AddPublisher : Form
    {
        public AddPublisher()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtPublisher = new DataTable();

        public void tampilData()
        {
            dtPublisher = new DataTable();
            sqlQuery = "select KODE_PENERBIT as 'ID Penerbit', NAMA_PENERBIT as 'Nama Penerbit', TELEPON_PENERBIT as 'Telepon', ALAMAT_PENERBIT as 'Alamat', KOTA_PENERBIT as 'Kota', DELETE_PENERBIT as 'Status'  from PENERBIT_BUKU";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPublisher);
            dgvPublisher.DataSource = dtPublisher;
            dgvPublisher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void tambahData()
        {
            sqlQuery = "insert into PENERBIT_BUKU (KODE_PENERBIT, NAMA_PENERBIT, TELEPON_PENERBIT, ALAMAT_PENERBIT, KOTA_PENERBIT, DELETE_PENERBIT) values ('" + tbPublisherID.Text + "', '" + tbPublisherName.Text + "', '" + tbPublisherPhone.Text + "', '" + tbPublisherAddress.Text + "', '"+ tbPublisherCity.Text +"', '"+tbStatus.Text+"')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data added successfully");
            Clear();
            tbPublisherID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void editData()
        {
            sqlQuery = "update PENERBIT_BUKU set NAMA_PENERBIT = '" + tbPublisherName.Text + "', TELEPON_PENERBIT = '" + tbPublisherPhone.Text + "', ALAMAT_PENERBIT = '" + tbPublisherAddress.Text + "', KOTA_PENERBIT = '" + tbPublisherCity.Text + "', DELETE_PENERBIT = '"+tbStatus.Text +"' where KODE_PENERBIT = '" + tbPublisherID.Text + "'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data updated successfully");
            Clear();
            tbPublisherID.Enabled = true;
            tbPublisherID.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void Clear()
        {
            tbPublisherID.Text = "";
            tbPublisherName.Text = "";
            tbPublisherPhone.Text = "";
            tbPublisherAddress.Text = "";
            tbPublisherCity.Text = "";
            tbStatus.Text = "";
        }

        public void FocusOnEmptyTextBox()
        {
            if (tbPublisherID.Text == "")
                tbPublisherID.Focus();
            else if (tbPublisherName.Text == "")
                tbPublisherName.Focus();
            else if (tbPublisherPhone.Text == "")
                tbPublisherPhone.Focus();
            else if (tbPublisherAddress.Text == "")
                tbPublisherAddress.Focus();
            else if (tbPublisherCity.Text == "")
                tbPublisherCity.Focus();
            else if (tbStatus.Text == "")
                tbStatus.Focus();
        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tbPublisherID.Text == "" || tbPublisherName.Text == "" || tbPublisherPhone.Text == "" || tbPublisherAddress.Text == "" || tbPublisherCity.Text == "" || tbStatus.Text == "")
            {
                MessageBox.Show("Data is not complete");
                FocusOnEmptyTextBox();
            }
            else
            {
                tambahData();
            }
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPublisherID.Enabled = false;
            DataGridViewRow row = this.dgvPublisher.Rows[e.RowIndex];
            tbPublisherID.Text = row.Cells["ID Penerbit"].Value.ToString();
            tbPublisherName.Text = row.Cells["Nama Penerbit"].Value.ToString();
            tbPublisherPhone.Text = row.Cells["Telepon"].Value.ToString();
            tbPublisherAddress.Text = row.Cells["Alamat"].Value.ToString();
            tbPublisherCity.Text = row.Cells["Kota"].Value.ToString();
            tbStatus.Text = row.Cells["Status"].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (tbPublisherName.Text == "" || tbPublisherPhone.Text == "" || tbPublisherAddress.Text == "" || tbPublisherCity.Text == "" || tbStatus.Text == "")
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
            tbPublisherID.Enabled = true;
            tbPublisherID.Focus();
            Clear();
        }
    }
}
