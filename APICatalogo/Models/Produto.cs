using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(30)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(60)]
        public string? Descricao { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Preco { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Desconto { get; set; }
        public DateTime? DataCadastro { get; set; }  

        
    }
}
