using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITHIGIUAKI
{
	class FormFunctions
	{
		/// <summary>
		/// Tra ve gia tri (reader) de do du lieu len datagridview
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		public static DbDataReader show(SqlConnection connection)
		{
			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = @"Select SanPham1.MaSanPham, SanPham1.TenSanPham, SanPham1.NgayNhapHang, SanPham1.NhaSanXuat, SanPham1.TinhTrang, MatHang1.TenMatHang from SanPham1 inner join MatHang1 on SanPham1.MaMatHang = MatHang1.MaMatHang;";
			DbDataReader reader = command.ExecuteReader();
			return reader;
		}
	}
}
