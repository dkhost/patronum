﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patronum.Negocio
{
    public class Validacao
    {
        public Dictionary<String, String> Mensagens { get; set; }
        public Boolean Valido
        {
            get
            {
                return this.Mensagens.Count == 0;
            }
        }

        public Validacao()
        {
            this.Mensagens = new Dictionary<String, String>();
        }
    }
}
