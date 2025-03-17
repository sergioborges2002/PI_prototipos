using System.Collections.Generic;
using teste.Models;

namespace teste.Repositories
{
    public interface IProdutoRepository
    {
        object GetAllProdutos();
        IEnumerable<Produto> GetProdutosFavoritos();
    }
}
