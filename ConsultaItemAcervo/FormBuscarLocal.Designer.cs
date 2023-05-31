namespace ConsultaItemAcervo
{
    partial class FormBuscarLocal
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
            this.dtgDadosLocal = new System.Windows.Forms.DataGridView();
            this.colNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeLocal = new System.Windows.Forms.TextBox();
            this.lblNomeLocal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLocal)).BeginInit();
            this.SuspendLayout();
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
            this.colNomeLocal});
            this.dtgDadosLocal.Location = new System.Drawing.Point(17, 44);
            this.dtgDadosLocal.Name = "dtgDadosLocal";
            this.dtgDadosLocal.ReadOnly = true;
            this.dtgDadosLocal.RowHeadersWidth = 62;
            this.dtgDadosLocal.RowTemplate.Height = 28;
            this.dtgDadosLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosLocal.Size = new System.Drawing.Size(594, 271);
            this.dtgDadosLocal.TabIndex = 8;
            this.dtgDadosLocal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosLocal_CellDoubleClick);
            // 
            // colNomeLocal
            // 
            this.colNomeLocal.HeaderText = "Local";
            this.colNomeLocal.MinimumWidth = 8;
            this.colNomeLocal.Name = "colNomeLocal";
            this.colNomeLocal.ReadOnly = true;
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLocal.Location = new System.Drawing.Point(71, 12);
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(540, 26);
            this.txtNomeLocal.TabIndex = 7;
            this.txtNomeLocal.TextChanged += new System.EventHandler(this.txtNomeLocal_TextChanged);
            // 
            // lblNomeLocal
            // 
            this.lblNomeLocal.AutoSize = true;
            this.lblNomeLocal.Location = new System.Drawing.Point(13, 15);
            this.lblNomeLocal.Name = "lblNomeLocal";
            this.lblNomeLocal.Size = new System.Drawing.Size(51, 20);
            this.lblNomeLocal.TabIndex = 6;
            this.lblNomeLocal.Text = "Local:";
            // 
            // FormBuscarLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 325);
            this.Controls.Add(this.dtgDadosLocal);
            this.Controls.Add(this.txtNomeLocal);
            this.Controls.Add(this.lblNomeLocal);
            this.Name = "FormBuscarLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Local";
            this.Load += new System.EventHandler(this.FormBuscarLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDadosLocal;
        private System.Windows.Forms.TextBox txtNomeLocal;
        private System.Windows.Forms.Label lblNomeLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocal;
    }
}