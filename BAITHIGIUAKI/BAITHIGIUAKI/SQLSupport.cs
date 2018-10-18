using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITHIGIUAKI
{
	class SQLSupport
	{
		private static string connectionString = @"Data Source=DESKTOP-KORVILM\MSSQLSERER1;Initial Catalog=QUAN LY SIEU THI;Integrated Security=True";

		/// <summary>
		/// Khoi tao Connection
		/// </summary>
		/// <returns></returns>
		public static SqlConnection getConnection()
		{
			SqlConnection connection = new SqlConnection(connectionString);
			return connection;//tao doi tuong ket noi
		}

		/// <summary>
		/// khoi tao command
		/// </summary>
		/// <param name="connection">connect den database</param>
		/// <param name="sql">cau lenh truy van du lieu</param>
		/// <returns></returns>
		public static SqlCommand getCommand(SqlConnection connection, String sql)
		{
			SqlCommand command = new SqlCommand();//lay cau lenh
			command.Connection = connection;
			command.CommandText = sql;
			return command;
		}

		/// <summary>
		/// Lay gia tri tra ve sau khi excute command
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		public static DbDataReader getResult(SqlCommand command)
		{
			DbDataReader reader = command.ExecuteReader();//lay gia tri tu database
			return reader;
		}
	}
}
