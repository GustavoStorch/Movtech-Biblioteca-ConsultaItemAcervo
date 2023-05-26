using CadastroItemDoAcervo;
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

namespace ReservaItemAcervo
{
    public partial class FormBuscaLeitor : Form
    {
        public string codLeitor { get; private set; }

        public FormBuscaLeitor()
        {
            InitializeComponent();
        }

        private void FormBuscaLeitor_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void carregaTextBox()
        {
            codLeitor = txtCodLeitor.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosLeitor.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LeitorDAO dao = new LeitorDAO(connection);
                List<LeitorModel> leitores = dao.GetLeitores();
                foreach (LeitorModel leitor in leitores)
                {
                    DataGridViewRow row = dtgDadosLeitor.Rows[dtgDadosLeitor.Rows.Add()];
                    row.Cells[colCodLeitor.Index].Value = leitor.CodLeitor;
                    row.Cells[colNomeLeitor.Index].Value = leitor.NomeLeitor;
                }
            }
        }

        private void dtgDadosLeitor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtNomeLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colNomeLeitor.Index].Value + "";
                txtCodLeitor.Text = dtgDadosLeitor.Rows[e.RowIndex].Cells[colCodLeitor.Index].Value + "";
            }
            carregaTextBox();
        }

        private void txtNomeLeitor_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeLeitor.Text.Trim();

            foreach (DataGridViewRow row in dtgDadosLeitor.Rows)
            {
                string nomeAutor = row.Cells[colNomeLeitor.Index].Value.ToString().Trim();

                // Verifica se o nome do autor contém o filtro
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;

                // Define a visibilidade da linha com base no resultado do filtro
                row.Visible = exibir;
            }
        }
    }
}
