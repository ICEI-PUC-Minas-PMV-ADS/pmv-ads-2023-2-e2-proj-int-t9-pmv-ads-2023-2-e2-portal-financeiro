using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portal_financeiro2023.Models
{
    [Table("Despesas")]
    public class Despesa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public String Conta { get; set; }

        [Required(ErrorMessage = "Obrigatório informar quem você está devendo!")]

        public String Instituição { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição da despesa!")]
        [Display(Name = "Descrição da despesa")]
        public string descrição { get; set; }

        public ICollection<Divida> Dividas { get; set; }

          
    }
}
