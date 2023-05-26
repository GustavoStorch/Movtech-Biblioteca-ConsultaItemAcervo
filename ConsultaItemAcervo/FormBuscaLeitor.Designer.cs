namespace ReservaItemAcervo
{
    partial class FormBuscaLeitor
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
            this.dtgDadosLeitor = new System.Windows.Forms.DataGridView();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.lblNomeLeitor = new System.Windows.Forms.Label();
            this.colCodLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLeitor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDadosLeitor
            // 
            this.dtgDadosLeitor.AllowUserToAddRows = false;
            this.dtgDadosLeitor.AllowUserToDeleteRows = false;
            this.dtgDadosLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosLeitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodLeitor,
            this.colNomeLeitor});
            this.dtgDadosLeitor.Location = new System.Drawing.Point(19, 44);
            this.dtgDadosLeitor.MultiSelect = false;
            this.dtgDadosLeitor.Name = "dtgDadosLeitor";
            this.dtgDadosLeitor.ReadOnly = true;
            this.dtgDadosLeitor.RowHeadersWidth = 62;
            this.dtgDadosLeitor.RowTemplate.Height = 28;
            this.dtgDadosLeitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosLeitor.Size = new System.Drawing.Size(771, 318);
            this.dtgDadosLeitor.TabIndex = 7;
            this.dtgDadosLeitor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosLeitor_CellDoubleClick);
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLeitor.Location = new System.Drawing.Point(76, 12);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(714, 26);
            this.txtNomeLeitor.TabIndex = 6;
            this.txtNomeLeitor.TextChanged += new System.EventHandler(this.txtNomeLeitor_TextChanged);
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Location = new System.Drawing.Point(12, 15);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(55, 20);
            this.lblNomeLeitor.TabIndex = 8;
            this.lblNomeLeitor.Text = "Nome:";
            // 
            // colCodLeitor
            // 
            this.colCodLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCodLeitor.FillWeight = 30F;
            this.colCodLeitor.HeaderText = "Código";
            this.colCodLeitor.MinimumWidth = 8;
            this.colCodLeitor.Name = "colCodLeitor";
            this.colCodLeitor.ReadOnly = true;
            // 
            // colNomeLeitor
            // 
            this.colNomeLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeLeitor.HeaderText = "Leitor";
            this.colNomeLeitor.MinimumWidth = 8;
            this.colNomeLeitor.Name = "colNomeLeitor";
            this.colNomeLeitor.ReadOnly = true;
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodLeitor.Enabled = false;
            this.txtCodLeitor.Location = new System.Drawing.Point(3, 339);
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.ReadOnly = true;
            this.txtCodLeitor.Size = new System.Drawing.Size(10, 19);
            this.txtCodLeitor.TabIndex = 9;
            this.txtCodLeitor.Visible = false;
            // 
            // FormBuscaLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 370);
            this.Controls.Add(this.txtCodLeitor);
            this.Controls.Add(this.dtgDadosLeitor);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.lblNomeLeitor);
            this.Name = "FormBuscaLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscaLeitor";
            this.Load += new System.EventHandler(this.FormBuscaLeitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLeitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDadosLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.Label lblNomeLeitor;
        private System.Windows.Forms.TextBox txtCodLeitor;
    }
}