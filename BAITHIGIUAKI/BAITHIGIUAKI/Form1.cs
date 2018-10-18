using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITHIGIUAKI
{
	public partial class Form1 : Form
	{
		SqlConnection connection;
		public Form1()
		{
			connection = SQLSupport.getConnection();
			connection.Open();
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			DbDataReader reader = FormFunctions.show(connection);
			if(reader.HasRows)
			{
				while (reader.Read())
				{
					int n = dataGridView1.Rows.Add();
					dataGridView1.Rows[n].Cells[0].Value = n.ToString();
					int masanpham = reader.GetOrdinal("MaSanPham");
					dataGridView1.Rows[n].Cells[1].Value = reader.GetString(masanpham);
					int tenSanPham = reader.GetOrdinal("TenSanPham");
					dataGridView1.Rows[n].Cells[2].Value = reader.GetString(tenSanPham);
					int date = reader.GetOrdinal("NgayNhapHang");
					dataGridView1.Rows[n].Cells[3].Value = reader.GetDateTime(date).ToString();
					int nhaSanXuat = reader.GetOrdinal("NhaSanXuat");
					dataGridView1.Rows[n].Cells[4].Value = reader.GetString(nhaSanXuat);
					int tinhTrang = reader.GetOrdinal("TinhTrang");
					dataGridView1.Rows[n].Cells[5].Value = reader.GetBoolean(tinhTrang);
					int tenMatHang = reader.GetOrdinal("TenMatHang");
					dataGridView1.Rows[n].Cells[6].Value = reader.GetString(tenMatHang);
				}
			}
		}
	}
}
