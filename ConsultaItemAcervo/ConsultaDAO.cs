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

        public void Consultar(ConsultaItemModel consultaItem)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codItem, nome, tipoItem, nomeLocal, nomeAutor, nomeColecao, secao, statusItem FROM mvtBibItemAcervo WHERE codItem = @codItem");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codItem", consultaItem.CodItem));

                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public bool VerificaCampos(ConsultaItemModel consultaItem)
        {
            if (string.IsNullOrEmpty(consultaItem.NomeItem) || string.IsNullOrWhiteSpace(consultaItem.NomeItem))
            {
                MessageBox.Show("Informe o campo do Nome do item");
                return false;
            }
            return true;

        }

        public List<ConsultaItemModel> GetItens2(ConsultaItemModel consultaItem)
        {
            List<ConsultaItemModel> itens = new List<ConsultaItemModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nome, tipoItem, nomeEditora, nomeLocal, nomeAutor, nomeColecao, secao, statusItem FROM mvtBibItemAcervo WHERE nomeAutor = @nomeAutor" +
                    " AND nome = '%@nome%' ORDER BY codItem");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@nomeAutor", consultaItem.NomeAutor));
                command.Parameters.Add(new SqlParameter("@nome", consultaItem.NomeItem));
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        itens.Add(PopulateDrItem(dr));
                    }
                }
            }
            return itens;
        }

        public List<ConsultaItemModel> GetItens()
        {
            List<ConsultaItemModel> itens = new List<ConsultaItemModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nome, tipoItem, nomeEditora, nomeLocal, nomeAutor, nomeColecao, secao, statusItem FROM mvtBibItemAcervo ORDER BY codItem");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        itens.Add(PopulateDrItem(dr));
                    }
                }
            }
            return itens;
        }

        public ConsultaItemModel PopulateDrItem(SqlDataReader dr)
        {
            string codItem = "";
            string nome = "";
            string tipoItem = "";
            string nomeLocal = "";
            string nomeAutor = "";
            string nomeColecao = "";
            string secao = "";
            string statusItem = "";
            string nomeEditora = "";

            if (DBNull.Value != dr["codItem"])
            {
                codItem = dr["codItem"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nome = dr["nome"] + "";
            }
            if (DBNull.Value != dr["tipoItem"])
            {
                tipoItem = dr["tipoItem"] + "";
            }
            if (DBNull.Value != dr["nomeLocal"])
            {
                nomeLocal = dr["nomeLocal"] + "";
            }
            if (DBNull.Value != dr["nomeAutor"])
            {
                nomeAutor = dr["nomeAutor"] + "";
            }
            if (DBNull.Value != dr["nomeColecao"])
            {
                nomeColecao = dr["nomeColecao"] + "";
            }
            if (DBNull.Value != dr["secao"])
            {
                secao = dr["secao"] + "";
            }
            if (DBNull.Value != dr["statusItem"])
            {
                statusItem = dr["statusItem"] + "";
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                nomeEditora = dr["nomeEditora"] + "";
            }

            return new ConsultaItemModel()
            {
                CodItem = codItem,
                NomeItem = nome,
                TipoItem = tipoItem,
                NomeLocal = nomeLocal,
                NomeAutor = nomeAutor,
                NomeColecao = nomeColecao,
                NomeSecao = secao,
                StatusItem = statusItem,
                NomeEditora = nomeEditora
            };
        }
    }
}
