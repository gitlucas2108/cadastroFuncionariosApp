using System.ComponentModel.DataAnnotations;

namespace cadastroFuncionarios
{
    public class Cargo
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Nome { get; set; } = string.Empty;        

        public DateTime DataCadastro { get; set; } 

        public DateTime DataAlteracao { get; set; } 

        public DateTime DataExclusao { get; set; } 

    }
}
