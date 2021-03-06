﻿using Patronum.Negocio;
using Patronum.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patronum.Grafico
{
    public partial class ManterPatrimonio : Form
    {
        public Patrimonio PatrimonioSelecionado { get; set; }

        Patrimonio patrimonio = new Patrimonio();

        public ManterPatrimonio()
        {
            InitializeComponent();
        }

        private void ManterPatrimonio_Load(object sender, EventArgs e)
        {
            ckbExterno_CheckedChanged();
            CarregarComboBoxes();
        }

        private void CarregarComboBoxes()
        {
            {
                cbSetores.DisplayMember = "DescricaoSetor";
                cbSetores.ValueMember = "Id";
                cbSetores.DataSource = Program.Gerenciador.TodosOsSetores();

                cbGestores.DisplayMember = "DescricaoGestor";
                cbGestores.ValueMember = "Id";
                cbGestores.DataSource = Program.Gerenciador.TodosOsSetores();

                cbFornecedores.DisplayMember = "DescricaoFornecedor";
                cbFornecedores.ValueMember = "Id";
                cbFornecedores.DataSource = Program.Gerenciador.TodosOsFornecedores();

                cbEmpresa.DisplayMember = "DescricaoEmpresa";
                cbEmpresa.ValueMember = "Id";
                cbEmpresa.DataSource = Program.Gerenciador.TodosOsClientes();

                cbSetorEmpresa.DisplayMember = "DescricaoSetorEmpresa";
                cbSetorEmpresa.ValueMember = "Id";
                cbSetorEmpresa.DataSource = Program.Gerenciador.TodosOsClientes();

                cbResp.DisplayMember = "DescricaoResp";
                cbResp.ValueMember = "Id";
                cbResp.DataSource = Program.Gerenciador.TodosOsClientes();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Patrimonio patrimonio = new Patrimonio();

            if (Int64.TryParse(tbId.Text, out long value))
            {
                patrimonio.Id = value;
            }
            else
            {
                patrimonio.Id = -1;
            }

            patrimonio.Nome = tbNome.Text;
            patrimonio.NomeCliente = cbEmpresa.Text;
            if (ckbExterno.CheckState == CheckState.Checked)
            {
                patrimonio.SetorCliente = cbSetorEmpresa.Text;
                patrimonio.RespCliente = cbResp.Text;
                patrimonio.Setor = "N/A";
                patrimonio.Gestor = "N/A";
            }
            else if (ckbExterno.CheckState == CheckState.Unchecked)
            {
                patrimonio.Setor = cbSetores.Text;
                patrimonio.Gestor = cbGestores.Text;
                patrimonio.SetorCliente = "N/A";
                patrimonio.RespCliente = "N/A";
            }
            patrimonio.Nfe = tbNfe.Text;
            patrimonio.Fornecedor = cbFornecedores.Text;
            patrimonio.ServiceTag = tbServiceTag.Text;
            patrimonio.DataAquisi = Convert.ToDateTime(dtpDataAquisi.Text);
            patrimonio.PrazoGarant = Convert.ToDateTime(dtpPrazoGarant.Text);
            patrimonio.Obs = tbObs.Text;
            patrimonio.Ativo = ckbAtivo.Checked;

            Validacao validacao;
            if (PatrimonioSelecionado == null)
            {
                validacao = Program.Gerenciador.CadastrarPatrimonio(patrimonio);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarPatrimonio(patrimonio);
            }

            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;

                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Patrimônio salvo com sucesso!");

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterPatrimonio_Shown(object sender, EventArgs e)
        {
            if(PatrimonioSelecionado != null)
            {
                this.tbId.Text = PatrimonioSelecionado.Id.ToString();
                this.tbNome.Text = PatrimonioSelecionado.Nome;
                if (ckbExterno.CheckState == CheckState.Checked)
                {
                    this.cbSetorEmpresa.Text = PatrimonioSelecionado.SetorCliente;
                    this.cbResp.Text = PatrimonioSelecionado.RespCliente;
                    this.cbSetores.Text = "N/A";
                    this.cbGestores.Text = "N/A";
                }
                else if (ckbExterno.CheckState == CheckState.Unchecked)
                {
                    this.cbSetores.Text = PatrimonioSelecionado.Setor;
                    this.cbGestores.Text = PatrimonioSelecionado.Gestor;
                    this.cbSetorEmpresa.Text = "N/A";
                    this.cbResp.Text = "N/A";
                }
                this.cbEmpresa.Text = PatrimonioSelecionado.NomeCliente;
                this.cbFornecedores.Text = PatrimonioSelecionado.Fornecedor;
                this.tbNfe.Text = PatrimonioSelecionado.Nfe;
                this.tbServiceTag.Text = PatrimonioSelecionado.ServiceTag;
                this.dtpDataAquisi.Text = PatrimonioSelecionado.DataAquisi.ToShortDateString();
                this.dtpPrazoGarant.Text = PatrimonioSelecionado.PrazoGarant.ToShortDateString();
                this.tbObs.Text = PatrimonioSelecionado.Obs;
                this.ckbAtivo.Checked = PatrimonioSelecionado.Ativo;
                this.ckbExterno.Checked = PatrimonioSelecionado.Externo;
            }
        }

        private void ckbExterno_CheckedChanged(object sender, EventArgs e)
        {
            ckbExterno_CheckedChanged();
        }

        private void ckbExterno_CheckedChanged()
        {
            if (ckbExterno.CheckState == CheckState.Checked)
            {
                cbSetorEmpresa.Enabled = true;
                cbResp.Enabled = true;
                cbSetores.Enabled = false;
                cbGestores.Enabled = false;
            }
            else if (ckbExterno.CheckState == CheckState.Unchecked)
            {
                cbSetorEmpresa.Enabled = false;
                cbResp.Enabled = false;
                cbSetores.Enabled = true;
                cbGestores.Enabled = true;
            }
        }
    }
}
