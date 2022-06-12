
namespace LibraryProject
{
    partial class BorrowBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBorrowID = new System.Windows.Forms.TextBox();
            this.tbReturnID = new System.Windows.Forms.TextBox();
            this.tbNIM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.cbLibrarian = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dgvPeminjaman = new System.Windows.Forms.DataGridView();
            this.nudJumlahBuku = new System.Windows.Forms.NumericUpDown();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelNama = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxBooksID = new System.Windows.Forms.TextBox();
            this.labelBookName1 = new System.Windows.Forms.Label();
            this.labelBookName2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBorrowID
            // 
            this.tbBorrowID.BackColor = System.Drawing.Color.Bisque;
            this.tbBorrowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBorrowID.Location = new System.Drawing.Point(263, 78);
            this.tbBorrowID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBorrowID.Name = "tbBorrowID";
            this.tbBorrowID.Size = new System.Drawing.Size(397, 31);
            this.tbBorrowID.TabIndex = 0;
            // 
            // tbReturnID
            // 
            this.tbReturnID.BackColor = System.Drawing.Color.Bisque;
            this.tbReturnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReturnID.Location = new System.Drawing.Point(263, 123);
            this.tbReturnID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReturnID.Name = "tbReturnID";
            this.tbReturnID.Size = new System.Drawing.Size(397, 31);
            this.tbReturnID.TabIndex = 1;
            // 
            // tbNIM
            // 
            this.tbNIM.BackColor = System.Drawing.Color.Bisque;
            this.tbNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNIM.Location = new System.Drawing.Point(263, 168);
            this.tbNIM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNIM.Name = "tbNIM";
            this.tbNIM.Size = new System.Drawing.Size(397, 31);
            this.tbNIM.TabIndex = 2;
            this.tbNIM.TextChanged += new System.EventHandler(this.tbNIM_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Borrow ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Librarian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Return ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Return Date Contract";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Borrow Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Number of Books";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(243, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(243, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(243, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(243, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(243, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = ":";
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.CalendarMonthBackground = System.Drawing.Color.Bisque;
            this.dtpBorrow.CustomFormat = "";
            this.dtpBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorrow.Location = new System.Drawing.Point(263, 447);
            this.dtpBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(397, 31);
            this.dtpBorrow.TabIndex = 21;
            this.dtpBorrow.ValueChanged += new System.EventHandler(this.dtpBorrow_ValueChanged);
            // 
            // dtpReturn
            // 
            this.dtpReturn.CalendarMonthBackground = System.Drawing.Color.Bisque;
            this.dtpReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturn.Location = new System.Drawing.Point(263, 492);
            this.dtpReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(397, 31);
            this.dtpReturn.TabIndex = 22;
            this.dtpReturn.Value = new System.DateTime(2022, 6, 17, 0, 0, 0, 0);
            // 
            // cbLibrarian
            // 
            this.cbLibrarian.BackColor = System.Drawing.Color.Bisque;
            this.cbLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLibrarian.FormattingEnabled = true;
            this.cbLibrarian.Location = new System.Drawing.Point(263, 251);
            this.cbLibrarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLibrarian.Name = "cbLibrarian";
            this.cbLibrarian.Size = new System.Drawing.Size(397, 33);
            this.cbLibrarian.TabIndex = 23;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Chocolate;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(84, 555);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(177, 39);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Chocolate;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(485, 555);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(175, 39);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dgvPeminjaman
            // 
            this.dgvPeminjaman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeminjaman.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeminjaman.Location = new System.Drawing.Point(695, 75);
            this.dgvPeminjaman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPeminjaman.Name = "dgvPeminjaman";
            this.dgvPeminjaman.RowHeadersWidth = 51;
            this.dgvPeminjaman.RowTemplate.Height = 24;
            this.dgvPeminjaman.Size = new System.Drawing.Size(530, 359);
            this.dgvPeminjaman.TabIndex = 27;
            this.dgvPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjaman_CellClick);
            // 
            // nudJumlahBuku
            // 
            this.nudJumlahBuku.BackColor = System.Drawing.Color.Bisque;
            this.nudJumlahBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudJumlahBuku.Location = new System.Drawing.Point(263, 297);
            this.nudJumlahBuku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudJumlahBuku.Name = "nudJumlahBuku";
            this.nudJumlahBuku.Size = new System.Drawing.Size(135, 31);
            this.nudJumlahBuku.TabIndex = 28;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Chocolate;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(287, 555);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(172, 39);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(262, 216);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(34, 20);
            this.labelNama.TabIndex = 30;
            this.labelNama.Text = "[...]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(62, 344);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Books ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(243, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = ":";
            // 
            // textBoxBooksID
            // 
            this.textBoxBooksID.BackColor = System.Drawing.Color.Bisque;
            this.textBoxBooksID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBooksID.Location = new System.Drawing.Point(263, 338);
            this.textBoxBooksID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBooksID.Name = "textBoxBooksID";
            this.textBoxBooksID.Size = new System.Drawing.Size(397, 31);
            this.textBoxBooksID.TabIndex = 2;
            this.textBoxBooksID.TextChanged += new System.EventHandler(this.textBoxBooksID_TextChanged);
            // 
            // labelBookName1
            // 
            this.labelBookName1.AutoSize = true;
            this.labelBookName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName1.Location = new System.Drawing.Point(262, 383);
            this.labelBookName1.Name = "labelBookName1";
            this.labelBookName1.Size = new System.Drawing.Size(54, 20);
            this.labelBookName1.TabIndex = 32;
            this.labelBookName1.Text = "1. [...]";
            // 
            // labelBookName2
            // 
            this.labelBookName2.AutoSize = true;
            this.labelBookName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName2.Location = new System.Drawing.Point(262, 414);
            this.labelBookName2.Name = "labelBookName2";
            this.labelBookName2.Size = new System.Drawing.Size(54, 20);
            this.labelBookName2.TabIndex = 32;
            this.labelBookName2.Text = "2. [...]";
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1420, 976);
            this.Controls.Add(this.labelBookName2);
            this.Controls.Add(this.labelBookName1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.nudJumlahBuku);
            this.Controls.Add(this.dgvPeminjaman);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.cbLibrarian);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.dtpBorrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBooksID);
            this.Controls.Add(this.tbNIM);
            this.Controls.Add(this.tbReturnID);
            this.Controls.Add(this.tbBorrowID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BorrowBook";
            this.Text = "Borrow Book";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBorrowID;
        private System.Windows.Forms.TextBox tbReturnID;
        private System.Windows.Forms.TextBox tbNIM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.ComboBox cbLibrarian;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dgvPeminjaman;
        private System.Windows.Forms.NumericUpDown nudJumlahBuku;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxBooksID;
        private System.Windows.Forms.Label labelBookName1;
        private System.Windows.Forms.Label labelBookName2;
    }
}