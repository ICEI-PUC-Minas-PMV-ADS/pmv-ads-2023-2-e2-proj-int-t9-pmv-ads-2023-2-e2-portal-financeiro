using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Portal_financeiro2023.Models
{
    [Table("Dividas")]
    public class Divida
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]

        public String Conta { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor!")]

        public Decimal Valor { get; set; }

        [Display(Name = "Data de vencimento")]
        [Required(ErrorMessage = "Obrigatório informar a data de vencimento!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a previsão de pagamento!")]

        [Display(Name = "Quando pretende pagar a dívida?")]
        public DateTime Pagamento { get; set; }

        [Display(Name = "Já está em negociação?")]
        public Negociação EmNegociação { get; set; }


        [Display(Name = "Despesa?")]
        [Required(ErrorMessage = "Obrigatório informar a Despesa!")]
        public int DespesaId{ get; set; }
        
        [ForeignKey("DespesaId")]
        
        public Despesa Despesa { get; set; }




        public enum Negociação
        {
            Sim,
            Não
        }
    }
}



