﻿namespace ConsultaItemAcervo
{
    partial class FormConsultaItem
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaItem));
            this.lblCodItem = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSecao = new System.Windows.Forms.Label();
            this.lblColecao = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.lblNomeItem = new System.Windows.Forms.Label();
            this.txtCodItemAcervo = new System.Windows.Forms.TextBox();
            this.txtNomeSecao = new System.Windows.Forms.TextBox();
            this.txtNomeColecao = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.txtNomeItemAcervo = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxTipoItem = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpxDadosConsultaItem = new System.Windows.Forms.GroupBox();
            this.btnBuscarSecao = new System.Windows.Forms.Button();
            this.btnBuscarLocal = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgDadosConsultaItem = new System.Windows.Forms.DataGridView();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeColecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpxDadosConsultaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosConsultaItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodItem
            // 
            this.lblCodItem.AutoSize = true;
            this.lblCodItem.Location = new System.Drawing.Point(6, 34);
            this.lblCodItem.Name = "lblCodItem";
            this.lblCodItem.Size = new System.Drawing.Size(63, 20);
            this.lblCodItem.TabIndex = 0;
            this.lblCodItem.Text = "Código:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // lblSecao
            // 
            this.lblSecao.AutoSize = true;
            this.lblSecao.Location = new System.Drawing.Point(6, 77);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(59, 20);
            this.lblSecao.TabIndex = 2;
            this.lblSecao.Text = "Seção:";
            // 
            // lblColecao
            // 
            this.lblColecao.AutoSize = true;
            this.lblColecao.Location = new System.Drawing.Point(325, 165);
            this.lblColecao.Name = "lblColecao";
            this.lblColecao.Size = new System.Drawing.Size(71, 20);
            this.lblColecao.TabIndex = 3;
            this.lblColecao.Text = "Coleção:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(325, 77);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(52, 20);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(325, 119);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(51, 20);
            this.lblLocal.TabIndex = 5;
            this.lblLocal.Text = "Local:";
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(6, 119);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(79, 20);
            this.lblTipoItem.TabIndex = 6;
            this.lblTipoItem.Text = "Tipo Item:";
            // 
            // lblNomeItem
            // 
            this.lblNomeItem.AutoSize = true;
            this.lblNomeItem.Location = new System.Drawing.Point(325, 34);
            this.lblNomeItem.Name = "lblNomeItem";
            this.lblNomeItem.Size = new System.Drawing.Size(113, 20);
            this.lblNomeItem.TabIndex = 7;
            this.lblNomeItem.Text = "Nome do Item:";
            // 
            // txtCodItemAcervo
            // 
            this.txtCodItemAcervo.Enabled = false;
            this.txtCodItemAcervo.Location = new System.Drawing.Point(91, 31);
            this.txtCodItemAcervo.MaxLength = 5;
            this.txtCodItemAcervo.Name = "txtCodItemAcervo";
            this.txtCodItemAcervo.Size = new System.Drawing.Size(228, 26);
            this.txtCodItemAcervo.TabIndex = 0;
            // 
            // txtNomeSecao
            // 
            this.txtNomeSecao.Location = new System.Drawing.Point(91, 74);
            this.txtNomeSecao.MaxLength = 50;
            this.txtNomeSecao.Name = "txtNomeSecao";
            this.txtNomeSecao.Size = new System.Drawing.Size(164, 26);
            this.txtNomeSecao.TabIndex = 2;
            this.txtNomeSecao.TextChanged += new System.EventHandler(this.txtNomeSecao_TextChanged);
            // 
            // txtNomeColecao
            // 
            this.txtNomeColecao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeColecao.Location = new System.Drawing.Point(444, 162);
            this.txtNomeColecao.MaxLength = 50;
            this.txtNomeColecao.Name = "txtNomeColecao";
            this.txtNomeColecao.Size = new System.Drawing.Size(451, 26);
            this.txtNomeColecao.TabIndex = 10;
            this.txtNomeColecao.TextChanged += new System.EventHandler(this.txtNomeColecao_TextChanged);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAutor.Location = new System.Drawing.Point(444, 77);
            this.txtNomeAutor.MaxLength = 50;
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(387, 26);
            this.txtNomeAutor.TabIndex = 4;
            this.txtNomeAutor.TextChanged += new System.EventHandler(this.txtNomeAutor_TextChanged);
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLocal.Location = new System.Drawing.Point(444, 116);
            this.txtNomeLocal.MaxLength = 50;
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(387, 26);
            this.txtNomeLocal.TabIndex = 7;
            this.txtNomeLocal.TextChanged += new System.EventHandler(this.txtNomeLocal_TextChanged);
            // 
            // txtNomeItemAcervo
            // 
            this.txtNomeItemAcervo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeItemAcervo.Location = new System.Drawing.Point(444, 31);
            this.txtNomeItemAcervo.MaxLength = 50;
            this.txtNomeItemAcervo.Name = "txtNomeItemAcervo";
            this.txtNomeItemAcervo.Size = new System.Drawing.Size(451, 26);
            this.txtNomeItemAcervo.TabIndex = 1;
            this.txtNomeItemAcervo.TextChanged += new System.EventHandler(this.txtNomeItemAcervo_TextChanged);
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Emprestado",
            "Disponível"});
            this.cbxStatus.Location = new System.Drawing.Point(91, 162);
            this.cbxStatus.MaxLength = 50;
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(228, 28);
            this.cbxStatus.TabIndex = 9;
            this.cbxStatus.TextChanged += new System.EventHandler(this.cbxStatus_TextChanged);
            // 
            // cbxTipoItem
            // 
            this.cbxTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoItem.FormattingEnabled = true;
            this.cbxTipoItem.ItemHeight = 20;
            this.cbxTipoItem.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
            this.cbxTipoItem.Location = new System.Drawing.Point(91, 116);
            this.cbxTipoItem.MaxLength = 50;
            this.cbxTipoItem.Name = "cbxTipoItem";
            this.cbxTipoItem.Size = new System.Drawing.Size(228, 28);
            this.cbxTipoItem.TabIndex = 6;
            this.cbxTipoItem.TextChanged += new System.EventHandler(this.cbxTipoItem_TextChanged);
            // 
            // gpxDadosConsultaItem
            // 
            this.gpxDadosConsultaItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxDadosConsultaItem.Controls.Add(this.btnBuscarSecao);
            this.gpxDadosConsultaItem.Controls.Add(this.btnBuscarLocal);
            this.gpxDadosConsultaItem.Controls.Add(this.btnBuscarAutor);
            this.gpxDadosConsultaItem.Controls.Add(this.lblCodItem);
            this.gpxDadosConsultaItem.Controls.Add(this.txtNomeSecao);
            this.gpxDadosConsultaItem.Controls.Add(this.lblSecao);
            this.gpxDadosConsultaItem.Controls.Add(this.txtNomeColecao);
            this.gpxDadosConsultaItem.Controls.Add(this.cbxStatus);
            this.gpxDadosConsultaItem.Controls.Add(this.lblColecao);
            this.gpxDadosConsultaItem.Controls.Add(this.cbxTipoItem);
            this.gpxDadosConsultaItem.Controls.Add(this.txtNomeLocal);
            this.gpxDadosConsultaItem.Controls.Add(this.txtCodItemAcervo);
            this.gpxDadosConsultaItem.Controls.Add(this.lblStatus);
            this.gpxDadosConsultaItem.Controls.Add(this.txtNomeAutor);
            this.gpxDadosConsultaItem.Controls.Add(this.lblLocal);
            this.gpxDadosConsultaItem.Controls.Add(this.lblNomeItem);
            this.gpxDadosConsultaItem.Controls.Add(this.txtNomeItemAcervo);
            this.gpxDadosConsultaItem.Controls.Add(this.lblTipoItem);
            this.gpxDadosConsultaItem.Controls.Add(this.lblAutor);
            this.gpxDadosConsultaItem.Location = new System.Drawing.Point(12, 12);
            this.gpxDadosConsultaItem.Name = "gpxDadosConsultaItem";
            this.gpxDadosConsultaItem.Size = new System.Drawing.Size(903, 208);
            this.gpxDadosConsultaItem.TabIndex = 16;
            this.gpxDadosConsultaItem.TabStop = false;
            this.gpxDadosConsultaItem.Text = "Consulta Item";
            // 
            // btnBuscarSecao
            // 
            this.btnBuscarSecao.FlatAppearance.BorderSize = 0;
            this.btnBuscarSecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSecao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarSecao.Image = global::ConsultaItemAcervo.Properties.Resources.lupa__1_;
            this.btnBuscarSecao.Location = new System.Drawing.Point(261, 74);
            this.btnBuscarSecao.Name = "btnBuscarSecao";
            this.btnBuscarSecao.Size = new System.Drawing.Size(58, 26);
            this.btnBuscarSecao.TabIndex = 3;
            this.btnBuscarSecao.UseVisualStyleBackColor = true;
            this.btnBuscarSecao.Click += new System.EventHandler(this.btnBuscarSecao_Click);
            // 
            // btnBuscarLocal
            // 
            this.btnBuscarLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarLocal.FlatAppearance.BorderSize = 0;
            this.btnBuscarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLocal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarLocal.Image = global::ConsultaItemAcervo.Properties.Resources.lupa__1_;
            this.btnBuscarLocal.Location = new System.Drawing.Point(837, 116);
            this.btnBuscarLocal.Name = "btnBuscarLocal";
            this.btnBuscarLocal.Size = new System.Drawing.Size(58, 26);
            this.btnBuscarLocal.TabIndex = 8;
            this.btnBuscarLocal.UseVisualStyleBackColor = true;
            this.btnBuscarLocal.Click += new System.EventHandler(this.btnBuscarLocal_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarAutor.FlatAppearance.BorderSize = 0;
            this.btnBuscarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarAutor.Image = global::ConsultaItemAcervo.Properties.Resources.lupa__1_;
            this.btnBuscarAutor.Location = new System.Drawing.Point(837, 77);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(58, 26);
            this.btnBuscarAutor.TabIndex = 5;
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(799, 228);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 34);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtgDadosConsultaItem
            // 
            this.dtgDadosConsultaItem.AllowUserToAddRows = false;
            this.dtgDadosConsultaItem.AllowUserToDeleteRows = false;
            this.dtgDadosConsultaItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosConsultaItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosConsultaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosConsultaItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeItem,
            this.colCodItem,
            this.colNomeAutor,
            this.colNomeEditora,
            this.colNomeLocal,
            this.colNomeColecao,
            this.colTipoItem,
            this.colNomeSecao,
            this.colStatusItem});
            this.dtgDadosConsultaItem.Location = new System.Drawing.Point(12, 270);
            this.dtgDadosConsultaItem.Name = "dtgDadosConsultaItem";
            this.dtgDadosConsultaItem.ReadOnly = true;
            this.dtgDadosConsultaItem.RowHeadersWidth = 62;
            this.dtgDadosConsultaItem.RowTemplate.Height = 28;
            this.dtgDadosConsultaItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosConsultaItem.Size = new System.Drawing.Size(903, 370);
            this.dtgDadosConsultaItem.TabIndex = 14;
            this.dtgDadosConsultaItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosConsultaItem_CellDoubleClick);
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Item";
            this.colNomeItem.MinimumWidth = 8;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colCodItem
            // 
            this.colCodItem.HeaderText = "Código";
            this.colCodItem.MinimumWidth = 8;
            this.colCodItem.Name = "colCodItem";
            this.colCodItem.ReadOnly = true;
            this.colCodItem.Visible = false;
            // 
            // colNomeAutor
            // 
            this.colNomeAutor.HeaderText = "Autor";
            this.colNomeAutor.MinimumWidth = 8;
            this.colNomeAutor.Name = "colNomeAutor";
            this.colNomeAutor.ReadOnly = true;
            // 
            // colNomeEditora
            // 
            this.colNomeEditora.HeaderText = "Editora";
            this.colNomeEditora.MinimumWidth = 8;
            this.colNomeEditora.Name = "colNomeEditora";
            this.colNomeEditora.ReadOnly = true;
            // 
            // colNomeLocal
            // 
            this.colNomeLocal.HeaderText = "Local";
            this.colNomeLocal.MinimumWidth = 8;
            this.colNomeLocal.Name = "colNomeLocal";
            this.colNomeLocal.ReadOnly = true;
            // 
            // colNomeColecao
            // 
            this.colNomeColecao.HeaderText = "Coleção";
            this.colNomeColecao.MinimumWidth = 8;
            this.colNomeColecao.Name = "colNomeColecao";
            this.colNomeColecao.ReadOnly = true;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo Item";
            this.colTipoItem.MinimumWidth = 8;
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            // 
            // colNomeSecao
            // 
            this.colNomeSecao.HeaderText = "Seção";
            this.colNomeSecao.MinimumWidth = 8;
            this.colNomeSecao.Name = "colNomeSecao";
            this.colNomeSecao.ReadOnly = true;
            // 
            // colStatusItem
            // 
            this.colStatusItem.HeaderText = "Status";
            this.colStatusItem.MinimumWidth = 8;
            this.colStatusItem.Name = "colStatusItem";
            this.colStatusItem.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(675, 228);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 34);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormConsultaItem
            // 
            this.AcceptButton = this.btnConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 652);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtgDadosConsultaItem);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gpxDadosConsultaItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Itens";
            this.Load += new System.EventHandler(this.FormConsultaItem_Load);
            this.gpxDadosConsultaItem.ResumeLayout(false);
            this.gpxDadosConsultaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosConsultaItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.Label lblColecao;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.Label lblNomeItem;
        private System.Windows.Forms.TextBox txtCodItemAcervo;
        private System.Windows.Forms.TextBox txtNomeSecao;
        private System.Windows.Forms.TextBox txtNomeColecao;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtNomeLocal;
        private System.Windows.Forms.TextBox txtNomeItemAcervo;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxTipoItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpxDadosConsultaItem;
        private System.Windows.Forms.Button btnConsultar;
        public System.Windows.Forms.DataGridView dtgDadosConsultaItem;
        public System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        public System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
        public System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutor;
        public System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditora;
        public System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocal;
        public System.Windows.Forms.DataGridViewTextBoxColumn colNomeColecao;
        public System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        public System.Windows.Forms.DataGridViewTextBoxColumn colNomeSecao;
        public System.Windows.Forms.DataGridViewTextBoxColumn colStatusItem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnBuscarSecao;
        private System.Windows.Forms.Button btnBuscarLocal;
    }
}

