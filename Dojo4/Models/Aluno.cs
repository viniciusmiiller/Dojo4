﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dojo4.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public Faixa Faixa{ get; set; }
        public byte FaixaId { get; set; }
        public TipoDeAssociacao TipoDeAssociacao { get; set; }
        public string Nome { get; set; }
        public string Cpf{ get; set; }

    }
}