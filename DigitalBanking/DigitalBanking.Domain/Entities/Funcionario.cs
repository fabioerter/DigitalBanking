using System;
using System.Collections.Generic;
using DigitalBanking.Domain.Base;

namespace DigitalBanking.Domain.Entities
{
    public partial class Funcionario : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal? Salario { get; set; }
        public int? FkEstado { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
