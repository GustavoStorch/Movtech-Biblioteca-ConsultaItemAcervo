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
            InitializeTable2(dtgDadosConsultaItem);
        }

        public void InitializeTable2(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ConsultaDAO dao = new ConsultaDAO(connection);
                List<ConsultaItemModel> emprestimos = dao.BuscarEmprestimos(new ConsultaItemModel()
                {
                    NomeItem = txtNomeItemAcervo.Text,
                    NomeAutor = txtNomeAutor.Text,
                    NomeLocal = txtNomeLocal.Text,
                    NomeSecao = txtNomeSecao.Text,
                    TipoItem = cbxTipoItem.Text,
                    StatusItem = cbxStatus.Text
                });

                foreach (ConsultaItemModel emprestimo in emprestimos)
                {
                    DataGridViewRow row = dataGridView.Rows[dataGridView.Rows.Add()];
                    row.Cells[colCodItem.Index].Value = emprestimo.CodItem;
                    row.Cells[colNomeItem.Index].Value = emprestimo.NomeItem;
                    row.Cells[colTipoItem.Index].Value = emprestimo.TipoItem;
                    row.Cells[colNomeEditora.Index].Value = emprestimo.NomeEditora;
                    row.Cells[colNomeLocal.Index].Value = emprestimo.NomeLocal;
                    row.Cells[colNomeAutor.Index].Value = emprestimo.NomeAutor;
                    row.Cells[colNomeColecao.Index].Value = emprestimo.NomeColecao;
                    row.Cells[colNomeSecao.Index].Value = emprestimo.NomeSecao;
                    row.Cells[colStatusItem.Index].Value = emprestimo.StatusItem;
                }
            }
        }

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparForm();
        }

        public void limparForm()
        {
            txtCodItemAcervo.Text = String.Empty;
            cbxStatus.SelectedIndex = -1;
            txtNomeItemAcervo.Text = String.Empty;
            cbxTipoItem.SelectedIndex = -1;
            txtNomeLocal.Text = String.Empty;
            txtNomeAutor.Text = String.Empty;
            txtNomeColecao.Text = String.Empty;
            txtNomeSecao.Text = String.Empty;
            dtgDadosConsultaItem.Rows.Clear();
        }

        private void btnBuscarSecao_Click(object sender, EventArgs e)
        {
            CarregaFormBuscaSecoes();
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            CarregaFormBuscaAutores();
        }

        private void btnBuscarLocal_Click(object sender, EventArgs e)
        {
            CarregaFormBuscaLocais();
        }

        public void CarregaFormBuscaAutores()
        {
            FormBuscarAutor formBuscaAutor = new FormBuscarAutor();
            formBuscaAutor.ShowDialog();
            txtNomeAutor.Text = formBuscaAutor.nomeAutor;

        }

        public void CarregaFormBuscaLocais()
        {
            FormBuscarLocal formBuscaLocal = new FormBuscarLocal();
            formBuscaLocal.ShowDialog();
            txtNomeLocal.Text = formBuscaLocal.nomeLocal;

        }

        public void CarregaFormBuscaSecoes()
        {
            FormBuscarSecao formBuscaSecao = new FormBuscarSecao();
            formBuscaSecao.ShowDialog();

            txtNomeSecao.Text = formBuscaSecao.nomeSecao;

        }

        private void txtNomeItemAcervo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeItemAcervo.Text))
            {
                btnLimpar.Enabled = false;
            }
            else
            {
                btnLimpar.Enabled = true;
            }
        }
        private void txtNomeSecao_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeSecao.Text))
            {
                btnLimpar.Enabled = false;
            }
            else
            {
                btnLimpar.Enabled = true;
            }
        }

        private void txtNomeAutor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeAutor.Text))
            {
                btnLimpar.Enabled = false;
            }
            else
            {
                btnLimpar.Enabled = true;
            }
        }

        private void cbxTipoItem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxTipoItem.Text))
            {
                btnLimpar.Enabled = false;
            }
            else
            {
                btnLimpar.Enabled = true;
            }
        }

        private void txtNomeLocal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeLocal.Text))
            {
                btnLimpar.Enabled = false;
            }
            else
            {
                btnLimpar.Enabled = true;
            }
        }

        private void cbxStatus_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxStatus.Text))
            {
                btnLimpar.Enabled = false;
            }
            else
            {
                btnLimpar.Enabled = true;
            }
        }

        private void txtNomeColecao_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeColecao.Text))
            {
                btnLimpar.Enabled = false;
            }
            else
            {
                btnLimpar.Enabled = true;
            }
        }
    }
}
