using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaItemAcervo
{
    public class ConsultaDAO
    {
        private SqlConnection Connection { get; }

        public ConsultaDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<ConsultaItemModel> BuscarEmprestimos(ConsultaItemModel consulta)
        {
            List<ConsultaItemModel> buscas = new List<ConsultaItemModel>();

            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nome, tipoItem, nomeEditora, nomeLocal, nomeAutor, nomeColecao, secao, statusItem");
                sql.AppendLine("FROM mvtBibItemAcervo");
                sql.AppendLine("WHERE 1 = 1");
                if (!string.IsNullOrEmpty(consulta.NomeItem))
                {
                    sql.AppendLine($"AND nome LIKE '%{consulta.NomeItem}%'");
                }
                if (!string.IsNullOrEmpty(consulta.NomeAutor))
                {
                    sql.AppendLine($"AND nomeAutor LIKE '%{consulta.NomeAutor}%'");
                }
                if (!string.IsNullOrEmpty(consulta.NomeLocal))
                {
                    sql.AppendLine($"AND nomeLocal LIKE '%{consulta.NomeLocal}%'");
                }
                if (!string.IsNullOrEmpty(consulta.NomeSecao))
                {
                    sql.AppendLine($"AND secao = '{consulta.NomeSecao}'");
                }
                if (!string.IsNullOrEmpty(consulta.TipoItem))
                {
                    sql.AppendLine($"AND tipoItem = '{consulta.TipoItem}'");
                }
                if (!string.IsNullOrEmpty(consulta.StatusItem))
                {
                    sql.AppendLine($"AND statusItem = '{consulta.StatusItem}'");
                }

                command.CommandText = sql.ToString();

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        buscas.Add(PopulateDrBusca(dr));
                    }
                }
            }

            return buscas;
        }

        private ConsultaItemModel PopulateDrBusca(SqlDataReader dr)
        {
            ConsultaItemModel model = new ConsultaItemModel();

            if (DBNull.Value != dr["codItem"])
            {
                model.CodItem = dr["codItem"].ToString();
            }
            if (DBNull.Value != dr["nome"])
            {
                model.NomeItem = dr["nome"].ToString();
            }
            if (DBNull.Value != dr["tipoItem"])
            {
                model.TipoItem = dr["tipoItem"].ToString();
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                model.NomeEditora = dr["nomeEditora"].ToString();
            }
            if (DBNull.Value != dr["nomeLocal"])
            {
                model.NomeLocal = dr["nomeLocal"].ToString();
            }
            if (DBNull.Value != dr["nomeAutor"])
            {
                model.NomeAutor = dr["nomeAutor"].ToString();
            }
            if (DBNull.Value != dr["nomeColecao"])
            {
                model.NomeColecao = dr["nomeColecao"].ToString();
            }
            if (DBNull.Value != dr["secao"])
            {
                model.NomeSecao = dr["secao"].ToString();
            }
            if (DBNull.Value != dr["statusItem"])
            {
                model.StatusItem = dr["statusItem"].ToString();
            }

            return model;
        }
    }
}
