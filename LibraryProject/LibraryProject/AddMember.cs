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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_09_PERPUSTAKAAN");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtMember = new DataTable();

        public void tampilData()
        {
            dtMember = new DataTable();
            sqlQuery = "select NIM_MAHASISWA as 'NIM', NAMA_MAHASISWA as 'Nama', JENIS_KELAMIN_MAHASISWA as 'Jenis Kelamin', TELEPON_MAHASISWA as 'Telepon', ALAMAT_MAHASISWA as 'Alamat', EMAIL_MAHASISWA as 'Email', DELETE_MAHASISWA as 'Status' from MAHASISWA";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMember);
            dgvMember.DataSource = dtMember;
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void tambahData()
        {
            string Gender = "";
            if (rbMale.Checked == true)
                Gender = "M";
            else
                Gender = "F";

            sqlQuery = "insert into MAHASISWA (NIM_MAHASISWA, NAMA_MAHASISWA, JENIS_KELAMIN_MAHASISWA, TELEPON_MAHASISWA, ALAMAT_MAHASISWA, EMAIL_MAHASISWA, DELETE_MAHASISWA) values ('" + tbNIM.Text + "', '" + tbMemberName.Text + "', '"+ Gender +"', '" + tbMemberPhone.Text + "', '" + tbMemberAddress.Text + "', '"+ tbMemberEmail.Text +"', '"+tbStatus.Text+"')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data added successfully");
            Clear();
            tbNIM.Focus();
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
            sqlQuery = "update MAHASISWA set NAMA_MAHASISWA = '" + tbMemberName.Text + "', JENIS_KELAMIN_MAHASISWA = '" + Gender + "', TELEPON_MAHASISWA = '" + tbMemberPhone.Text + "', ALAMAT_MAHASISWA = '"+ tbMemberAddress.Text +"', EMAIL_MAHASISWA = '"+ tbMemberEmail.Text +"', DELETE_MAHASISWA = '"+tbStatus.Text+"' where NIM_MAHASISWA = '" + tbNIM.Text + "'";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data updated successfully");
            Clear();
            tbNIM.Enabled = true;
            tbNIM.Focus();
            tampilData();
            sqlConnect.Close();
        }

        public void Clear()
        {
            tbNIM.Text = "";
            tbMemberName.Text = "";
            tbMemberPhone.Text = "";
            tbMemberAddress.Text = "";
            tbMemberEmail.Text = "";
            tbStatus.Text = "";
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        public void FocusOnEmptyTextBox()
        {
            if (tbNIM.Text == "")
                tbNIM.Focus();
            else if (tbMemberName.Text == "")
                tbMemberName.Focus();
            else if (tbMemberPhone.Text == "")
                tbMemberPhone.Focus();
            else if (tbMemberAddress.Text == "")
                tbMemberAddress.Focus();
            else if (tbMemberEmail.Text == "")
                tbMemberEmail.Focus();
            else if (tbStatus.Text == "")
                tbStatus.Focus();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tbNIM.Text == "" || tbMemberName.Text == "" || tbMemberPhone.Text == "" || tbMemberAddress.Text == "" || tbMemberEmail.Text == "" || tbStatus.Text == "")
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
            if (tbMemberName.Text == "" || tbMemberPhone.Text == "" || tbMemberAddress.Text == "" || tbMemberEmail.Text == "" || tbStatus.Text == "")
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
            tbNIM.Enabled = true;
            tbNIM.Focus();
            Clear();
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNIM.Enabled = false;
            DataGridViewRow row = this.dgvMember.Rows[e.RowIndex];
            tbNIM.Text = row.Cells["NIM"].Value.ToString();
            tbMemberName.Text = row.Cells["Nama"].Value.ToString();
            tbMemberPhone.Text = row.Cells["Telepon"].Value.ToString();
            tbMemberAddress.Text = row.Cells["Alamat"].Value.ToString();
            tbMemberEmail.Text = row.Cells["Email"].Value.ToString();
            tbStatus.Text = row.Cells["Status"].Value.ToString();
        }
    }
}
