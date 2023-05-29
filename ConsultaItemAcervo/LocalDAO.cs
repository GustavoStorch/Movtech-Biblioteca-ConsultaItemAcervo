using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaItemAcervo
{
    public class LocalDAO
    {
        private SqlConnection Connection { get; }

        public LocalDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<ConsultaItemModel> GetLocais()
        {
            List<ConsultaItemModel> locais = new List<ConsultaItemModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT descricaoLocal FROM mvtBibLocal ORDER BY codLocal");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        locais.Add(PopulateDrLocal(dr));
                    }
                }
            }
            return locais;
        }

        public ConsultaItemModel PopulateDrLocal(SqlDataReader dr)
        {
            string descricaoLocal = "";

            if (DBNull.Value != dr["descricaoLocal"])
            {
                descricaoLocal = dr["descricaoLocal"] + "";
            }

            return new ConsultaItemModel()
            {
                NomeLocal = descricaoLocal
            };
        }
    }
}
