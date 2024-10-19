using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMate_PlanoAlimentar.Models
{
    [Table("PlanoAlimentar")]
    public class Dieta
    {
        [Key]   
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public char Sexo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public float Altura { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public float Peso { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Alergia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Restricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string CondSaude { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string UsoMedicamento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Objetivo { get; set; }
    }
}
