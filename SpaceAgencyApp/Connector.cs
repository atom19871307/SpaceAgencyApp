using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace SpaceAgencyApp
{
	public static class Connector
	{
		private static string connString = @"Data Source=DESKTOP-C87488I\SQLEXPRESS;Initial Catalog=SpaceAgencyDB;Integrated Security=True";
		public static DataTable Load(string query)
		{
			DataTable dt = new DataTable();
			using (SqlConnection conn = new SqlConnection(connString))
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(query, conn);
				da.Fill(dt);
			}
			return dt;
		}
	}
}
