﻿
namespace LibraryProject
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.nudJumlahBuku = new System.Windows.Forms.NumericUpDown();
            this.dgvPengembalian = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.chckboxLibrarian = new System.Windows.Forms.ComboBox();
            this.dtpReturnReal = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnContract = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxNIM = new System.Windows.Forms.TextBox();
            this.txtboxReturnID = new System.Windows.Forms.TextBox();
            this.txtboxBorrowID = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxBooksID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.labelBookName2 = new System.Windows.Forms.Label();
            this.labelBookName1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxFine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengembalian)).BeginInit();
            this.SuspendLayout();
            // 
            // nudJumlahBuku
            // 
            this.nudJumlahBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudJumlahBuku.Location = new System.Drawing.Point(604, 250);
            this.nudJumlahBuku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudJumlahBuku.Name = "nudJumlahBuku";
            this.nudJumlahBuku.Size = new System.Drawing.Size(135, 31);
            this.nudJumlahBuku.TabIndex = 53;
            // 
            // dgvPengembalian
            // 
            this.dgvPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengembalian.Location = new System.Drawing.Point(209, 627);
            this.dgvPengembalian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPengembalian.Name = "dgvPengembalian";
            this.dgvPengembalian.RowHeadersWidth = 51;
            this.dgvPengembalian.RowTemplate.Height = 24;
            this.dgvPengembalian.Size = new System.Drawing.Size(998, 359);
            this.dgvPengembalian.TabIndex = 52;
            this.dgvPengembalian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPengembalian_CellClick);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(392, 552);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(174, 39);
            this.buttonReturn.TabIndex = 51;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(827, 552);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(174, 39);
            this.buttonCancel.TabIndex = 50;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // chckboxLibrarian
            // 
            this.chckboxLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckboxLibrarian.FormattingEnabled = true;
            this.chckboxLibrarian.Location = new System.Drawing.Point(604, 204);
            this.chckboxLibrarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckboxLibrarian.Name = "chckboxLibrarian";
            this.chckboxLibrarian.Size = new System.Drawing.Size(397, 33);
            this.chckboxLibrarian.TabIndex = 48;
            // 
            // dtpReturnReal
            // 
            this.dtpReturnReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnReal.Location = new System.Drawing.Point(604, 455);
            this.dtpReturnReal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpReturnReal.Name = "dtpReturnReal";
            this.dtpReturnReal.Size = new System.Drawing.Size(397, 31);
            this.dtpReturnReal.TabIndex = 47;
            this.dtpReturnReal.ValueChanged += new System.EventHandler(this.dtpReturnReal_ValueChanged);
            // 
            // dtpReturnContract
            // 
            this.dtpReturnContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnContract.Location = new System.Drawing.Point(604, 410);
            this.dtpReturnContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpReturnContract.Name = "dtpReturnContract";
            this.dtpReturnContract.Size = new System.Drawing.Size(397, 31);
            this.dtpReturnContract.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(584, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(584, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(584, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(584, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(584, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(584, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(584, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 25);
            this.label14.TabIndex = 39;
            this.label14.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(389, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Return Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(389, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Return Date Contract";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(389, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Number of Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(389, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Librarian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(389, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Return ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(389, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "NIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(389, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Borrow ID";
            // 
            // txtboxNIM
            // 
            this.txtboxNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNIM.Location = new System.Drawing.Point(604, 130);
            this.txtboxNIM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxNIM.Name = "txtboxNIM";
            this.txtboxNIM.Size = new System.Drawing.Size(397, 31);
            this.txtboxNIM.TabIndex = 31;
            this.txtboxNIM.TextChanged += new System.EventHandler(this.txtboxNIM_TextChanged);
            // 
            // txtboxReturnID
            // 
            this.txtboxReturnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxReturnID.Location = new System.Drawing.Point(604, 85);
            this.txtboxReturnID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxReturnID.Name = "txtboxReturnID";
            this.txtboxReturnID.Size = new System.Drawing.Size(397, 31);
            this.txtboxReturnID.TabIndex = 30;
            // 
            // txtboxBorrowID
            // 
            this.txtboxBorrowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBorrowID.Location = new System.Drawing.Point(604, 40);
            this.txtboxBorrowID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxBorrowID.Name = "txtboxBorrowID";
            this.txtboxBorrowID.Size = new System.Drawing.Size(397, 31);
            this.txtboxBorrowID.TabIndex = 29;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(606, 172);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(29, 20);
            this.labelNama.TabIndex = 54;
            this.labelNama.Text = "[...]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(388, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Books ID";
            // 
            // textBoxBooksID
            // 
            this.textBoxBooksID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBooksID.Location = new System.Drawing.Point(604, 291);
            this.textBoxBooksID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBooksID.Name = "textBoxBooksID";
            this.textBoxBooksID.Size = new System.Drawing.Size(397, 31);
            this.textBoxBooksID.TabIndex = 31;
            this.textBoxBooksID.TextChanged += new System.EventHandler(this.txtboxNIM_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(584, 292);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = ":";
            // 
            // labelBookName2
            // 
            this.labelBookName2.AutoSize = true;
            this.labelBookName2.Location = new System.Drawing.Point(605, 371);
            this.labelBookName2.Name = "labelBookName2";
            this.labelBookName2.Size = new System.Drawing.Size(46, 20);
            this.labelBookName2.TabIndex = 55;
            this.labelBookName2.Text = "2. [...]";
            // 
            // labelBookName1
            // 
            this.labelBookName1.AutoSize = true;
            this.labelBookName1.Location = new System.Drawing.Point(605, 340);
            this.labelBookName1.Name = "labelBookName1";
            this.labelBookName1.Size = new System.Drawing.Size(46, 20);
            this.labelBookName1.TabIndex = 56;
            this.labelBookName1.Text = "1. [...]";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(610, 552);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(174, 39);
            this.buttonClear.TabIndex = 51;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1014, 130);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 32);
            this.buttonSearch.TabIndex = 57;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(389, 507);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 20);
            this.label17.TabIndex = 38;
            this.label17.Text = "Fine";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(584, 502);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 25);
            this.label18.TabIndex = 45;
            this.label18.Text = ":";
            // 
            // textBoxFine
            // 
            this.textBoxFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFine.Location = new System.Drawing.Point(604, 501);
            this.textBoxFine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFine.Name = "textBoxFine";
            this.textBoxFine.Size = new System.Drawing.Size(397, 31);
            this.textBoxFine.TabIndex = 31;
            this.textBoxFine.TextChanged += new System.EventHandler(this.txtboxNIM_TextChanged);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1420, 1003);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelBookName2);
            this.Controls.Add(this.labelBookName1);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.nudJumlahBuku);
            this.Controls.Add(this.dgvPengembalian);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.chckboxLibrarian);
            this.Controls.Add(this.dtpReturnReal);
            this.Controls.Add(this.dtpReturnContract);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFine);
            this.Controls.Add(this.textBoxBooksID);
            this.Controls.Add(this.txtboxNIM);
            this.Controls.Add(this.txtboxReturnID);
            this.Controls.Add(this.txtboxBorrowID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReturnBook";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBook_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengembalian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudJumlahBuku;
        private System.Windows.Forms.DataGridView dgvPengembalian;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox chckboxLibrarian;
        private System.Windows.Forms.DateTimePicker dtpReturnReal;
        private System.Windows.Forms.DateTimePicker dtpReturnContract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxNIM;
        private System.Windows.Forms.TextBox txtboxReturnID;
        private System.Windows.Forms.TextBox txtboxBorrowID;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxBooksID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelBookName2;
        private System.Windows.Forms.Label labelBookName1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxFine;
    }
}