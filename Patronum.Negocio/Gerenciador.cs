﻿using Patronum.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patronum.Negocio.Persistencia;

namespace Patronum.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();

        public Validacao RemoverPatrimonio(Patrimonio patrimonio)
        {
            Validacao validacao = new Validacao();
            banco.Patrimonios.Remove(patrimonio);
            banco.SaveChanges();
            return validacao;
        }

        public Validacao RemoverSetor(Setor setor)
        {
            Validacao validacao = new Validacao();
            banco.Setores.Remove(setor);
            banco.SaveChanges();
            return validacao;
        }

        public Validacao AlterarSetor(Setor setorAlterado)
        {
            Validacao validacao = new Validacao();
            Setor setorBanco = BuscaSetorPorId(setorAlterado.SetorId);
            setorBanco.NomeSetor = setorAlterado.NomeSetor;
            setorBanco.NomeGestor = setorAlterado.NomeGestor;
            this.banco.SaveChanges();
            return validacao;
        }

        public Validacao AlterarPatrimonio(Patrimonio patrimonioAlterado)
        {
            Validacao validacao = new Validacao();
            Patrimonio patrimonioBanco = BuscaPatrimonioPorId(patrimonioAlterado.Id);
            patrimonioBanco.Nome = patrimonioAlterado.Nome;
            patrimonioBanco.Fornecedor = patrimonioAlterado.Fornecedor;
            patrimonioBanco.DataAquisi = Convert.ToDateTime(patrimonioAlterado.DataAquisi);
            patrimonioBanco.PrazoGarant = Convert.ToDateTime(patrimonioAlterado.PrazoGarant);
            patrimonioBanco.Nfe = patrimonioAlterado.Nfe;
            patrimonioBanco.ServiceTag = patrimonioAlterado.ServiceTag;
            patrimonioBanco.Obs = patrimonioAlterado.Obs;
            patrimonioBanco.Ativo = patrimonioAlterado.Ativo;
            this.banco.SaveChanges();
            return validacao;
        }

        public Validacao CadastrarSetor(Setor setorAdicionado)
        {
            Validacao validacao = new Validacao();
            if (this.banco.Setores.Where(c => c.NomeSetor == setorAdicionado.NomeSetor).Any())
            {
                validacao.Mensagens.Add("Nome do Setor", "Já existe um Setor com esse Nome");
            }
            if(this.banco.Setores.Where(c => c.NomeGestor == setorAdicionado.NomeGestor).Any())
            {
                validacao.Mensagens.Add("Nome do Gestor", "Já existe um Gestor com esse Nome");
            }
            if (validacao.Valido)
            {
                this.banco.Setores.Add(setorAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Validacao CadastrarPatrimonio(Patrimonio patrimonioAdicionado)
        {
            Validacao validacao = new Validacao();
            if (this.banco.Patrimonios.Where(c => c.ServiceTag == patrimonioAdicionado.ServiceTag).Any())
            {
                validacao.Mensagens.Add("ServiceTag", "Já existe um patrimônio com essa ServiceTag");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.Fornecedor))
            {
                validacao.Mensagens.Add("Fornecedor", "O campo Fornecedor não pode ser nulo");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.Nfe))
            {
                validacao.Mensagens.Add("Nfe", "O campo Nfe não pode ser nulo");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.ServiceTag))
            {
                validacao.Mensagens.Add("ServiceTag", "O campo ServiceTag não pode ser nulo");
            }
            if (validacao.Valido)
            {
                this.banco.Patrimonios.Add(patrimonioAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Patrimonio BuscaPatrimonioPorId(long id)
        {
            return this.banco.Patrimonios.Where(c => c.Id == id).FirstOrDefault();
        }

        public Setor BuscaSetorPorId(long id)
        {
            return this.banco.Setores.Where(c => c.SetorId == id).FirstOrDefault();
        }

         public List<Patrimonio> TodosOsPatrimonios()
        {
            return this.banco.Patrimonios.ToList();
        }

        public List<Setor> TodosOsSetores()
        {
            return this.banco.Setores.ToList();
        }
    }
}
