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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaPatrimonios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.tbFiltroPatrimonios = new System.Windows.Forms.TextBox();
            this.btFiltro = new System.Windows.Forms.Button();
            this.dgPatrimonios = new System.Windows.Forms.DataGridView();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetorEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAquisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrazoGarant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatrimonios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 12);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Cadastrar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(921, 13);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 1;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(93, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(59, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Detalhes";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // tbFiltroPatrimonios
            // 
            this.tbFiltroPatrimonios.Location = new System.Drawing.Point(358, 11);
            this.tbFiltroPatrimonios.Name = "tbFiltroPatrimonios";
            this.tbFiltroPatrimonios.Size = new System.Drawing.Size(100, 20);
            this.tbFiltroPatrimonios.TabIndex = 8;
            // 
            // btFiltro
            // 
            this.btFiltro.Location = new System.Drawing.Point(464, 9);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(42, 23);
            this.btFiltro.TabIndex = 10;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // dgPatrimonios
            // 
            this.dgPatrimonios.AllowUserToAddRows = false;
            this.dgPatrimonios.AllowUserToDeleteRows = false;
            this.dgPatrimonios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPatrimonios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgPatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatrimonios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ativo,
            this.Empresa,
            this.Nome,
            this.Setor,
            this.Gestor,
            this.SetorEmpresa,
            this.Responsavel,
            this.Fornecedor,
            this.Nfe,
            this.ServiceTag,
            this.DataAquisi,
            this.PrazoGarant,
            this.Obs});
            this.dgPatrimonios.Location = new System.Drawing.Point(12, 42);
            this.dgPatrimonios.MultiSelect = false;
            this.dgPatrimonios.Name = "dgPatrimonios";
            this.dgPatrimonios.ReadOnly = true;
            this.dgPatrimonios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPatrimonios.Size = new System.Drawing.Size(984, 675);
            this.dgPatrimonios.TabIndex = 9;
            // 
            // btRecarregar
            // 
            this.btRecarregar.Location = new System.Drawing.Point(512, 9);
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Size = new System.Drawing.Size(70, 23);
            this.btRecarregar.TabIndex = 11;
            this.btRecarregar.Text = "Recarregar";
            this.btRecarregar.UseVisualStyleBackColor = true;
            this.btRecarregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Format = "0000";
            dataGridViewCellStyle1.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.FillWeight = 45F;
            this.Id.HeaderText = "Código";
            this.Id.MinimumWidth = 34;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 65;
            // 
            // Ativo
            // 
            this.Ativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.FalseValue = "Não";
            this.Ativo.FillWeight = 35F;
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.TrueValue = "Sim";
            this.Ativo.Width = 37;
            // 
            // Empresa
            // 
            this.Empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empresa.DataPropertyName = "NomeCliente";
            this.Empresa.FillWeight = 82.78088F;
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 51.99107F;
            this.Nome.HeaderText = "Patrimônio";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Setor
            // 
            this.Setor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Setor.DataPropertyName = "Setor";
            this.Setor.FillWeight = 51.99107F;
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            this.Setor.ReadOnly = true;
            // 
            // Gestor
            // 
            this.Gestor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gestor.DataPropertyName = "Gestor";
            this.Gestor.FillWeight = 51.99107F;
            this.Gestor.HeaderText = "Gestor";
            this.Gestor.Name = "Gestor";
            this.Gestor.ReadOnly = true;
            // 
            // SetorEmpresa
            // 
            this.SetorEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SetorEmpresa.DataPropertyName = "SetorCliente";
            this.SetorEmpresa.FillWeight = 82.78088F;
            this.SetorEmpresa.HeaderText = "Setor Empresa";
            this.SetorEmpresa.Name = "SetorEmpresa";
            this.SetorEmpresa.ReadOnly = true;
            // 
            // Responsavel
            // 
            this.Responsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Responsavel.DataPropertyName = "RespCliente";
            this.Responsavel.FillWeight = 82.78088F;
            this.Responsavel.HeaderText = "Responsavel";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.FillWeight = 82.78088F;
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            // 
            // Nfe
            // 
            this.Nfe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nfe.DataPropertyName = "Nfe";
            this.Nfe.FillWeight = 51.99107F;
            this.Nfe.HeaderText = "Nfe";
            this.Nfe.Name = "Nfe";
            this.Nfe.ReadOnly = true;
            // 
            // ServiceTag
            // 
            this.ServiceTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceTag.DataPropertyName = "ServiceTag";
            this.ServiceTag.FillWeight = 82.78088F;
            this.ServiceTag.HeaderText = "ServiceTag";
            this.ServiceTag.Name = "ServiceTag";
            this.ServiceTag.ReadOnly = true;
            // 
            // DataAquisi
            // 
            this.DataAquisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataAquisi.DataPropertyName = "DataAquisi";
            this.DataAquisi.FillWeight = 51.99107F;
            this.DataAquisi.HeaderText = "Aquisição";
            this.DataAquisi.Name = "DataAquisi";
            this.DataAquisi.ReadOnly = true;
            // 
            // PrazoGarant
            // 
            this.PrazoGarant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrazoGarant.DataPropertyName = "PrazoGarant";
            this.PrazoGarant.FillWeight = 51.99107F;
            this.PrazoGarant.HeaderText = "Garantia";
            this.PrazoGarant.Name = "PrazoGarant";
            this.PrazoGarant.ReadOnly = true;
            // 
            // Obs
            // 
            this.Obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Obs.DataPropertyName = "Obs";
            this.Obs.FillWeight = 82.78088F;
            this.Obs.HeaderText = "Observações";
            this.Obs.Name = "Obs";
            this.Obs.ReadOnly = true;
            this.Obs.Width = 95;
            // 
            // TelaListaPatrimonios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btRecarregar);
            this.Controls.Add(this.dgPatrimonios);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFiltroPatrimonios);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TelaListaPatrimonios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Patrimônios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaListaPatrimonios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatrimonios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox tbFiltroPatrimonios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.DataGridView dgPatrimonios;
        private System.Windows.Forms.Button btRecarregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gestor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetorEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAquisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrazoGarant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
    }
}