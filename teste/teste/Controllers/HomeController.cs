using Microsoft.AspNetCore.Mvc;
using teste.Context;
using teste.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace teste.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return View(produtos);
        }
        public async Task<IActionResult> Produto(int id)
        {
            var produto = await _context.Produtos.Include(p => p.Categoria).FirstOrDefaultAsync(p => p.ProdutoId == id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }
    }
}
