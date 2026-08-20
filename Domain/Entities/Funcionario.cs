using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Funcionario
    {
        
        
            public int Id { get; set; }

            [Required]
            public string Nome { get; set; } = string.Empty;

            [Required]
            public string Cargo { get; set; } = string.Empty;

            [Range(0.01, double.MaxValue)]
            public decimal Salario { get; set; }

            [Required]
            public string Departamento { get; set; } = string.Empty;

            public bool Ativo { get; set; }
        
    }
}
