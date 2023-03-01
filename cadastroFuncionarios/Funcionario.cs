using System;
using System.ComponentModel.DataAnnotations;

namespace cadastroFuncionarios
{
    public class Funcionario
    {
        public int Id { get; set; }

        public int CargoId { get; set; }

        [StringLength(250)]
        public string Nome { get; set; } = string.Empty;

        [StringLength(11)]
        public string CPF { get; set; } = string.Empty;
        

        public DateTime DataAdmissao { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool UtilizaVT { get; set; } = false;

        //public Cargo cargoFuncionario { get; set; } = null;
    }
}
