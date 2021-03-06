﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patronum.Negocio.Models
{
    [Table(name: "Patrimonios")]
    public class Patrimonio
    {
        public long Id { get; set; }
        public String Nome { get; set; }
        public String Setor { get; set; }
        public String Gestor { get; set; }
        public String Fornecedor { get; set; }
        public DateTime DataAquisi { get; set; }
        public DateTime PrazoGarant { get; set; }
        public String Nfe { get; set; }
        public String ServiceTag { get; set; }
        public String Obs { get; set; }
        public bool Ativo { get; set; }
        public String RespCliente { get; set; }
        public String NomeCliente { get; set; }
        public String SetorCliente { get; set; }
        public bool Externo { get; set; }

    }
}
