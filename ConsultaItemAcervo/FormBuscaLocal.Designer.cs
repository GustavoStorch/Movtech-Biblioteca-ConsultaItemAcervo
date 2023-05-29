namespace CadastroItemDoAcervo
{
    partial class FormBuscaLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeLocal = new System.Windows.Forms.Label();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.dtgDadosLocal = new System.Windows.Forms.DataGridView();
            this.colCodLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeLocal
            // 
            this.lblNomeLocal.AutoSize = true;
            this.lblNomeLocal.Location = new System.Drawing.Point(13, 17);
            this.lblNomeLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeLocal.Name = "lblNomeLocal";
            this.lblNomeLocal.Size = new System.Drawing.Size(51, 20);
            this.lblNomeLocal.TabIndex = 1;
            this.lblNomeLocal.Text = "Local:";
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLocal.Location = new System.Drawing.Point(72, 14);
            this.txtNomeLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeLocal.MaxLength = 50;
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(708, 26);
            this.txtNomeLocal.TabIndex = 3;
            this.txtNomeLocal.TextChanged += new System.EventHandler(this.txtNomeLocal_TextChanged);
            // 
            // dtgDadosLocal
            // 
            this.dtgDadosLocal.AllowUserToAddRows = false;
            this.dtgDadosLocal.AllowUserToDeleteRows = false;
            this.dtgDadosLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodLocal,
            this.colNomeLocal});
            this.dtgDadosLocal.Location = new System.Drawing.Point(17, 50);
            this.dtgDadosLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgDadosLocal.MultiSelect = false;
            this.dtgDadosLocal.Name = "dtgDadosLocal";
            this.dtgDadosLocal.ReadOnly = true;
            this.dtgDadosLocal.RowHeadersWidth = 62;
            this.dtgDadosLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosLocal.Size = new System.Drawing.Size(763, 298);
            this.dtgDadosLocal.TabIndex = 6;
            this.dtgDadosLocal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosLocal_CellDoubleClick);
            // 
            // colCodLocal
            // 
            this.colCodLocal.FillWeight = 30F;
            this.colCodLocal.HeaderText = "Código";
            this.colCodLocal.MinimumWidth = 8;
            this.colCodLocal.Name = "colCodLocal";
            this.colCodLocal.ReadOnly = true;
            // 
            // colNomeLocal
            // 
            this.colNomeLocal.HeaderText = "Nome Local";
            this.colNomeLocal.MinimumWidth = 8;
            this.colNomeLocal.Name = "colNomeLocal";
            this.colNomeLocal.ReadOnly = true;
            // 
            // FormBuscaLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 362);
            this.Controls.Add(this.dtgDadosLocal);
            this.Controls.Add(this.txtNomeLocal);
            this.Controls.Add(this.lblNomeLocal);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBuscaLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscaLocal";
            this.Load += new System.EventHandler(this.FormBuscaLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeLocal;
        private System.Windows.Forms.TextBox txtNomeLocal;
        private System.Windows.Forms.DataGridView dtgDadosLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocal;
    }
}