using System;
using System.Collections.Generic;
using DigitalBanking.Domain.Base;

namespace DigitalBanking.Domain.Entities
{
    public class Estado : Entity
    {
        public Estado()
        {
            Funcionario = new HashSet<Funcionario>();
        }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}
