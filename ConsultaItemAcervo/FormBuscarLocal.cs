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
    public partial class FormBuscarLocal : Form
    {
        public string nomeLocal { get; private set; }

        public FormBuscarLocal()
        {
            InitializeComponent();
        }

        private void FormBuscarLocal_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void carregaTextBox()
        {
            nomeLocal = txtNomeLocal.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosLocal.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LocalDAO dao = new LocalDAO(connection);
                List<ConsultaItemModel> locais = dao.GetLocais();
                foreach (ConsultaItemModel local in locais)
                {
                    DataGridViewRow row = dtgDadosLocal.Rows[dtgDadosLocal.Rows.Add()];
                    row.Cells[colNomeLocal.Index].Value = local.NomeLocal;
                }
            }
        }

        private void dtgDadosLocal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtNomeLocal.Text = dtgDadosLocal.Rows[e.RowIndex].Cells[colNomeLocal.Index].Value + "";
            }
            carregaTextBox();
        }

        private void txtNomeLocal_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeLocal.Text.Trim();

            foreach (DataGridViewRow row in dtgDadosLocal.Rows)
            {
                string nomeAutor = row.Cells[colNomeLocal.Index].Value.ToString().Trim();

                // Verifica se o nome do autor contém o filtro
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;

                // Define a visibilidade da linha com base no resultado do filtro
                row.Visible = exibir;
            }
        }
    }
}
