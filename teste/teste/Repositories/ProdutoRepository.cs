using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using teste.Context;
using teste.Models;
using teste.Repositories;

namespace teste.Repositories
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(ILogger<HomeController> logger, IProdutoRepository produtoRepository)
        {
            _logger = logger;
            _produtoRepository = produtoRepository;
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public object GetAllProdutos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetProdutosFavoritos()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Produto>> GetProdutosFavoritosAsync()
        {
            try
            {
                return await _context.Produtos.Where(p => p.IsFavorito).ToListAsync();
            }
            catch (Exception ex)
            {
                // Log the exception (assumes a logger is available)
                // _logger.LogError(ex, "An error occurred while getting favorite products.");
                throw;
            }
        }
    }
}
