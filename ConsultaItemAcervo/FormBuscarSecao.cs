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
    public partial class FormBuscarSecao : Form
    {
        public string nomeSecao { get; private set; }

        public FormBuscarSecao()
        {
            InitializeComponent();
        }

        private void FormBuscarSecao_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void carregaTextBox()
        {
            nomeSecao = txtNomeSecao.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosSecao.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SecaoDAO dao = new SecaoDAO(connection);
                List<ConsultaItemModel> secoes = dao.GetSecoes();
                foreach (ConsultaItemModel secao in secoes)
                {
                    DataGridViewRow row = dtgDadosSecao.Rows[dtgDadosSecao.Rows.Add()];
                    row.Cells[colNomeSecao.Index].Value = secao.NomeSecao;
                }
            }
        }

        private void dtgDadosSecao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtNomeSecao.Text = dtgDadosSecao.Rows[e.RowIndex].Cells[colNomeSecao.Index].Value + "";
            }
            carregaTextBox();
        }

        private void txtNomeSecao_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeSecao.Text.Trim();

            foreach (DataGridViewRow row in dtgDadosSecao.Rows)
            {
                string nomeAutor = row.Cells[colNomeSecao.Index].Value.ToString().Trim();

                // Verifica se o nome do autor contém o filtro
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;

                // Define a visibilidade da linha com base no resultado do filtro
                row.Visible = exibir;
            }
        }
    }
}
