namespace teste.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; } = new(); // Relacionamento com a entidade Produto
    }
}