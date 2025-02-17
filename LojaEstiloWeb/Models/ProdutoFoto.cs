using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaEstiloWeb.Models
{
    [Table("Foto")]
    public class ProdutoFoto
    {
        [Key]
       public int Id { get; set; }

       [Display(Name = "Produto")]
       [Required(ErrorMessage = "Por favor, informe o Produto")] 
       public int ProdutoId { get; set; }
        [ForeignKey("ProdutoId")]
       public Produto Produto { get; set; }

       [Required(ErrorMessage = "Por favor, informe a Foto")]
       [StringLength(200)]
       public string Foto { get; set; }

       [Display(Name = "Descrição")]
       [StringLength(100, ErrorMessage = "A Descrição deve possuir no máximo 100 carácteres")]
       public string Descricao { get; set; }
    }
}