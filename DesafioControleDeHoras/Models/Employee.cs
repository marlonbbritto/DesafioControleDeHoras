
using System.ComponentModel.DataAnnotations;

namespace DesafioControleDeHoras.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome do colaborador é obrigatório")]
        [MaxLength(100,ErrorMessage ="O nome tem de ter no máximo 100 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage ="a data de nascimento é obrigatória")]
        public string BornDate { get; set; }
    }
}
