﻿namespace Patronum.Grafico
{
    partial class TelaListaPatrimonios
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
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.dgPatrimonios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAquisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrazoGarant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatrimonios)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 12);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(93, 12);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 1;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(174, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // dgPatrimonios
            // 
            this.dgPatrimonios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatrimonios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Setor,
            this.Gestor,
            this.Fornecedor,
            this.DataAquisi,
            this.PrazoGarant,
            this.Nfe,
            this.ServiceTag});
            this.dgPatrimonios.Location = new System.Drawing.Point(12, 41);
            this.dgPatrimonios.Name = "dgPatrimonios";
            this.dgPatrimonios.Size = new System.Drawing.Size(953, 405);
            this.dgPatrimonios.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Patrimônio";
            this.Nome.Name = "Nome";
            // 
            // Setor
            // 
            this.Setor.DataPropertyName = "Setor";
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            // 
            // Gestor
            // 
            this.Gestor.DataPropertyName = "Gestor";
            this.Gestor.HeaderText = "Gestor";
            this.Gestor.Name = "Gestor";
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // DataAquisi
            // 
            this.DataAquisi.DataPropertyName = "DataAquisi";
            this.DataAquisi.HeaderText = "Data de Aquisição";
            this.DataAquisi.Name = "DataAquisi";
            // 
            // PrazoGarant
            // 
            this.PrazoGarant.DataPropertyName = "PrazoGarant";
            this.PrazoGarant.HeaderText = "Prazo de Garantia";
            this.PrazoGarant.Name = "PrazoGarant";
            // 
            // Nfe
            // 
            this.Nfe.DataPropertyName = "Nfe";
            this.Nfe.HeaderText = "Nota Fiscal";
            this.Nfe.Name = "Nfe";
            // 
            // ServiceTag
            // 
            this.ServiceTag.DataPropertyName = "ServiceTag";
            this.ServiceTag.HeaderText = "ServiceTag";
            this.ServiceTag.Name = "ServiceTag";
            // 
            // TelaListaPatrimonios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 458);
            this.Controls.Add(this.dgPatrimonios);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Name = "TelaListaPatrimonios";
            this.Text = "TelaListaPatrimonios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaListaPatrimonios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatrimonios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DataGridView dgPatrimonios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gestor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAquisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrazoGarant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTag;
    }
}