using System;
using System.Collections.Generic;
using System.Text;
using DigitalBanking.Domain.Entities;

namespace DigitalBanking.Application.Dtos
{
    public class FuncionarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal? Salario { get; set; }
        public int? FkEstado { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
