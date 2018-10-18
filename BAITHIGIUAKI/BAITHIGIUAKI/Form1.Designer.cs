namespace BAITHIGIUAKI
{
	partial class Form1
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSort = new System.Windows.Forms.Button();
			this.cbxSort = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.radiobtn2 = new System.Windows.Forms.RadioButton();
			this.radiobtn1 = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.cbxNhaSanXuat = new System.Windows.Forms.ComboBox();
			this.cbxMatHang = new System.Windows.Forms.ComboBox();
			this.txtTenSanPham = new System.Windows.Forms.TextBox();
			this.txtMaSanPham = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maSanPham,
            this.name,
            this.dateNhapHang,
            this.nhaSanXuat,
            this.tinhTrang,
            this.maMatHang});
			this.dataGridView1.Location = new System.Drawing.Point(82, 194);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1078, 250);
			this.dataGridView1.TabIndex = 14;
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(67, 467);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 15;
			this.btnShow.Text = "SHOW";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(198, 467);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(311, 467);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 17;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(417, 467);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(515, 467);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 19;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(622, 468);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(100, 22);
			this.txtSearch.TabIndex = 20;
			// 
			// btnSort
			// 
			this.btnSort.Location = new System.Drawing.Point(757, 468);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(75, 23);
			this.btnSort.TabIndex = 21;
			this.btnSort.Text = "SORT";
			this.btnSort.UseVisualStyleBackColor = true;
			// 
			// cbxSort
			// 
			this.cbxSort.FormattingEnabled = true;
			this.cbxSort.Location = new System.Drawing.Point(871, 468);
			this.cbxSort.Name = "cbxSort";
			this.cbxSort.Size = new System.Drawing.Size(121, 24);
			this.cbxSort.TabIndex = 22;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.radiobtn2);
			this.groupBox1.Controls.Add(this.radiobtn1);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cbxNhaSanXuat);
			this.groupBox1.Controls.Add(this.cbxMatHang);
			this.groupBox1.Controls.Add(this.txtTenSanPham);
			this.groupBox1.Controls.Add(this.txtMaSanPham);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(46, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1114, 162);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thong tin";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(141, 110);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 27;
			// 
			// radiobtn2
			// 
			this.radiobtn2.AutoSize = true;
			this.radiobtn2.Location = new System.Drawing.Point(768, 134);
			this.radiobtn2.Name = "radiobtn2";
			this.radiobtn2.Size = new System.Drawing.Size(89, 21);
			this.radiobtn2.TabIndex = 26;
			this.radiobtn2.TabStop = true;
			this.radiobtn2.Text = "Het Hang";
			this.radiobtn2.UseVisualStyleBackColor = true;
			// 
			// radiobtn1
			// 
			this.radiobtn1.AutoSize = true;
			this.radiobtn1.Location = new System.Drawing.Point(633, 134);
			this.radiobtn1.Name = "radiobtn1";
			this.radiobtn1.Size = new System.Drawing.Size(92, 21);
			this.radiobtn1.TabIndex = 25;
			this.radiobtn1.TabStop = true;
			this.radiobtn1.Text = "Con Hang";
			this.radiobtn1.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(537, 134);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 17);
			this.label7.TabIndex = 24;
			this.label7.Text = "Tinh Trang";
			// 
			// cbxNhaSanXuat
			// 
			this.cbxNhaSanXuat.FormattingEnabled = true;
			this.cbxNhaSanXuat.Location = new System.Drawing.Point(633, 82);
			this.cbxNhaSanXuat.Name = "cbxNhaSanXuat";
			this.cbxNhaSanXuat.Size = new System.Drawing.Size(121, 24);
			this.cbxNhaSanXuat.TabIndex = 23;
			// 
			// cbxMatHang
			// 
			this.cbxMatHang.FormattingEnabled = true;
			this.cbxMatHang.Location = new System.Drawing.Point(633, 34);
			this.cbxMatHang.Name = "cbxMatHang";
			this.cbxMatHang.Size = new System.Drawing.Size(121, 24);
			this.cbxMatHang.TabIndex = 22;
			// 
			// txtTenSanPham
			// 
			this.txtTenSanPham.Location = new System.Drawing.Point(141, 82);
			this.txtTenSanPham.Name = "txtTenSanPham";
			this.txtTenSanPham.Size = new System.Drawing.Size(100, 22);
			this.txtTenSanPham.TabIndex = 21;
			// 
			// txtMaSanPham
			// 
			this.txtMaSanPham.Location = new System.Drawing.Point(141, 41);
			this.txtMaSanPham.Name = "txtMaSanPham";
			this.txtMaSanPham.Size = new System.Drawing.Size(100, 22);
			this.txtMaSanPham.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(537, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 17);
			this.label6.TabIndex = 19;
			this.label6.Text = "Nha san xuat";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(537, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 17);
			this.label5.TabIndex = 18;
			this.label5.Text = "Mat Hang";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 17);
			this.label4.TabIndex = 17;
			this.label4.Text = "Ngay Nhap";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 17);
			this.label3.TabIndex = 16;
			this.label3.Text = "Ten San Pham";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "MaSanPham";
			// 
			// id
			// 
			this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.id.HeaderText = "STT";
			this.id.Name = "id";
			// 
			// maSanPham
			// 
			this.maSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.maSanPham.HeaderText = "Ma San Pham";
			this.maSanPham.Name = "maSanPham";
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.HeaderText = "Ten San Pham";
			this.name.Name = "name";
			// 
			// dateNhapHang
			// 
			this.dateNhapHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dateNhapHang.HeaderText = "Ngay Nhap Hang";
			this.dateNhapHang.Name = "dateNhapHang";
			// 
			// nhaSanXuat
			// 
			this.nhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nhaSanXuat.HeaderText = "Nha San Xuat";
			this.nhaSanXuat.Name = "nhaSanXuat";
			// 
			// tinhTrang
			// 
			this.tinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tinhTrang.HeaderText = "Tinh Trang";
			this.tinhTrang.Name = "tinhTrang";
			// 
			// maMatHang
			// 
			this.maMatHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.maMatHang.HeaderText = "Ten Mat Hang";
			this.maMatHang.Name = "maMatHang";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1187, 591);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbxSort);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnShow);
			this.Name = "Form1";
			this.Text = "Mainform";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.ComboBox cbxSort;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.RadioButton radiobtn2;
		private System.Windows.Forms.RadioButton radiobtn1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxNhaSanXuat;
		private System.Windows.Forms.ComboBox cbxMatHang;
		private System.Windows.Forms.TextBox txtTenSanPham;
		private System.Windows.Forms.TextBox txtMaSanPham;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateNhapHang;
		private System.Windows.Forms.DataGridViewTextBoxColumn nhaSanXuat;
		private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
		private System.Windows.Forms.DataGridViewTextBoxColumn maMatHang;
	}
}

