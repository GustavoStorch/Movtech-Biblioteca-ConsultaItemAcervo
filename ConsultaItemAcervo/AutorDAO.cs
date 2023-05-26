using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaItemAcervo
{
	public class AutorDAO
    {
		private SqlConnection Connection { get; }

		public AutorDAO(SqlConnection connection)
		{
			Connection = connection;
		}

		public List<ConsultaItemModel> GetAutores()
		{
			List<ConsultaItemModel> autores = new List<ConsultaItemModel>();
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine("SELECT nomeAutor FROM mvtBibAutor ORDER BY codAutor");
				command.CommandText = sql.ToString();
				using (SqlDataReader dr = command.ExecuteReader())
				{
					while (dr.Read())
					{
						autores.Add(PopulateDrAutor(dr));
					}
				}
			}
			return autores;
		}

		public ConsultaItemModel PopulateDrAutor(SqlDataReader dr)
		{
			string nomeAutor = "";

			if (DBNull.Value != dr["nomeAutor"])
			{
				nomeAutor = dr["nomeAutor"] + "";
			}

			return new ConsultaItemModel()
			{
				NomeAutor = nomeAutor
			};
		}
	}
}
