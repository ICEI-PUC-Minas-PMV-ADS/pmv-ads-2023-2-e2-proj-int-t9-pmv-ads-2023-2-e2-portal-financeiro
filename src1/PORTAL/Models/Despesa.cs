using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PORTAL.Models
{
    [Table("Despesas")]

    public class Despesa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a conta")]

        public string Conta { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o mês")]
      
        public string Mês { get; set; }





    }
}    