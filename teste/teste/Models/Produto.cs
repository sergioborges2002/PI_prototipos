using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace teste.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        public int CategoriaId { get; set; } // Chave estrangeira
        public Categoria Categoria { get; set; } // Navegação para a categoria
        public bool IsFavorito { get; set; }
        public string ImagemUrl { get; set; } // Link de imagem
    }

}
