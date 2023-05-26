using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaItemAcervo
{
    public partial class FormConsultaItem : Form
    {
        public FormConsultaItem()
        {
            InitializeComponent();
        }

        private void FormConsultaItem_Load(object sender, EventArgs e)
        {
            limparForm();
            btnLimpar.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nomeItem = txtNomeItemAcervo.Text.Trim();
            string nomeAutor = txtNomeAutor.Text.Trim();
            string nomeLocal = txtNomeLocal.Text.Trim();
            string secao = txtNomeSecao.Text.Trim();
            string tipoItem = cbxTipoItem.Text.Trim();
            string stauts = cbxStatus.Text.Trim();

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nome, tipoItem, nomeEditora, nomeLocal, nomeAutor, nomeColecao, secao, statusItem");
                sql.AppendLine("FROM mvtBibItemAcervo");
                sql.AppendLine("WHERE 1 = 1");

                if (!string.IsNullOrEmpty(nomeItem))
                {
                    sql.AppendLine($"AND nome LIKE '%{nomeItem}%'");
                }
                if (!string.IsNullOrEmpty(nomeAutor))
                {
                    sql.AppendLine($"AND nomeAutor LIKE '%{nomeAutor}%'");
                }
                if (!string.IsNullOrEmpty(nomeLocal))
                {
                    sql.AppendLine($"AND nomeLocal LIKE '%{nomeLocal}%'");
                }
                if (!string.IsNullOrEmpty(secao))
                {
                    sql.AppendLine($"AND secao = '{secao}'");
                }
                if (!string.IsNullOrEmpty(tipoItem))
                {
                    sql.AppendLine($"AND tipoItem = '{tipoItem}'");
                }
                if (!string.IsNullOrEmpty(stauts))
                {
                    sql.AppendLine($"AND stautsItem = '{stauts}'");
                }

                dtgDadosConsultaItem.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                using (SqlCommand command = new SqlCommand(sql.ToString(), connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DataGridViewRow row = dtgDadosConsultaItem.Rows[dtgDadosConsultaItem.Rows.Add()];
                        row.Cells[colCodItem.Index].Value = reader["codItem"].ToString();
                        row.Cells[colNomeItem.Index].Value = reader["nome"].ToString();
                        row.Cells[colTipoItem.Index].Value = reader["tipoItem"].ToString();
                        row.Cells[colNomeEditora.Index].Value = reader["nomeEditora"].ToString();
                        row.Cells[colNomeLocal.Index].Value = reader["nomeLocal"].ToString();
                        row.Cells[colNomeAutor.Index].Value = reader["nomeAutor"].ToString();
                        row.Cells[colNomeColecao.Index].Value = reader["nomeColecao"].ToString();
                        row.Cells[colNomeSecao.Index].Value = reader["secao"].ToString();
                        row.Cells[colStatusItem.Index].Value = reader["statusItem"].ToString();

                    }
                } 
            }
        }

        /*private void InitializeTable()
        {
            dtgDadosConsultaItem.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ConsultaDAO dao = new ConsultaDAO(connection);
                List<ConsultaItemModel> consultaItens = dao.GetItens();
                foreach (ConsultaItemModel consultaItem in consultaItens)
                {
                    DataGridViewRow row = dtgDadosConsultaItem.Rows[dtgDadosConsultaItem.Rows.Add()];
                    row.Cells[colCodItem.Index].Value = consultaItem.CodItem;
                    row.Cells[colNomeItem.Index].Value = consultaItem.NomeItem;
                    row.Cells[colTipoItem.Index].Value = consultaItem.TipoItem;
                    row.Cells[colNomeLocal.Index].Value = consultaItem.NomeLocal;
                    row.Cells[colNomeAutor.Index].Value = consultaItem.NomeAutor;
                    row.Cells[colNomeColecao.Index].Value = consultaItem.NomeColecao;
                    row.Cells[colNomeSecao.Index].Value = consultaItem.NomeSecao;
                    row.Cells[colStatusItem.Index].Value = consultaItem.StatusItem;
                    row.Cells[colNomeEditora.Index].Value = consultaItem.NomeEditora;
                }
            }
        }*/

        private void dtgDadosConsultaItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodItemAcervo.Text = dtgDadosConsultaItem.Rows[e.RowIndex].Cells[colCodItem.Index].Value + "";
                txtNomeItemAcervo.Text = dtgDadosConsultaItem.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
                cbxTipoItem.Text = dtgDadosConsultaItem.Rows[e.RowIndex].Cells[colTipoItem.Index].Value + "";
                txtNomeLocal.Text = dtgDadosConsultaItem.Rows[e.RowIndex].Cells[colNomeLocal.Index].Value + "";
                txtNomeAutor.Text = dtgDadosConsultaItem.Rows[e.RowIndex].Cells[colNomeAutor.Index].Value + "";
                txtNomeColecao.Text = dtgDadosConsultaItem.Rows[e.RowIndex].Cells[colNomeColecao.Index].Value + "";
                txtNomeSecao.Text = dtgDadosConsultaItem.Rows[e.RowIndex].Cells[colNomeSecao.Index].Value + "";
                cbxStatus.Text = dtgDadosConsultaItem.Rows[e.RowIndex].Cells[colStatusItem.Index].Value + "";
            }
        }

        private void txtNomeItemAcervo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeItemAcervo.Text))
            {
                btnLimpar.Enabled = false;
            } else
            {
                btnLimpar.Enabled = true;
            }       
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparForm();
        }

        public void limparForm()
        {
            txtCodItemAcervo.Text = String.Empty;
            cbxStatus.Text = String.Empty;
            txtNomeItemAcervo.Text = String.Empty;
            cbxTipoItem.Text = String.Empty;
            txtNomeLocal.Text = String.Empty;
            txtNomeAutor.Text = String.Empty;
            txtNomeColecao.Text = String.Empty;
            txtNomeSecao.Text = String.Empty;
        }

        private void btnBuscarSecao_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            CarregaFormBuscaAutores();
        }

        private void btnBuscarLocal_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarColecao_Click(object sender, EventArgs e)
        {

        }

        public void CarregaFormBuscaAutores()
        {
            FormBuscarAutor formBuscaAutor = new FormBuscarAutor();
            formBuscaAutor.ShowDialog();
            txtNomeAutor.Text = formBuscaAutor.nomeAutor;

        }
    }
}
