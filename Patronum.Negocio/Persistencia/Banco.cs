﻿using Patronum.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Patronum.Negocio.Persistencia
{
    public class Banco : DbContext
    {
        public virtual DbSet<Patrimonio> Patrimonios { get; set; }
        public virtual DbSet<Setor> Setores { get; set; }
        public virtual DbSet<Fornecedor> Fornecedores { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
    }
}
