using teste.Models;

namespace teste.ViewModel
{
    public class ProdutoCategoriaViewModel
    { public List<Produto> Produtos { get; set; }
        public List<Categoria> Categoria { get; set; }
        public int? CategoriaIdSelecionada { get; set; }
    }
}
