using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaEstiloWeb.Models;

    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Por favor, informe a Categoria")]

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]

        public Categoria Categoria { get; set; }
        [Required(ErrorMessage = "Por favor, informe o Nome")]
        [StringLength(200, ErrorMessage = "O nome deve possuir no máximo 200 carácteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(1000, ErrorMessage = "O nome deve possuir no máximo 1000 carácteres")]
        public string Descricao { get; set; }

        [Range(0, int.MaxValue)]
        [Display(Name = "Quantidade em Estoque")]
        [Required(ErrorMessage = "Por favor, informe a quantidade do estoque")]
        public int QtdeEstoque { get; set; }

        [Range(0, double.MaxValue)]
        [Display(Name = "Valor de Custo")]
        [Column(TypeName = "numeric(10,2)")]
        [Required(ErrorMessage = "Por favor, informe o valor de custo")]
        public decimal ValorCusto { get; set; }

        [Range(0, double.MaxValue)]
        [Display(Name = "Valor de Venda")]
        [Column(TypeName = "numeric(10,2)")]
        [Required(ErrorMessage = "Por favor, informe o valor de venda")]
        public decimal ValorVenda { get; set; }

        public bool Destaque { get; set; } = false;

        public List<ProdutoFoto> Fotos { get; set; }

    } 