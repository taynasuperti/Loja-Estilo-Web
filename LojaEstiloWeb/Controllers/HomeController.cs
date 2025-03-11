using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LojaEstiloWeb.Models;
using LojaEstiloWeb.Data;
using Microsoft.EntityFrameworkCore;
using LojaEstiloWeb.ViewModels;

namespace LojaEstiloWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        ViewData["Carrinho"] = 0;
        List<Produto> produtos = _db.Produtos
            .Where(p => p.Destaque)
            .Include(p => p.Fotos)
            .ToList();
        return View(produtos);
    }

    public IActionResult Produto(int id)
    {
        ViewData["Carrinho"] = 0;
        // Pesquisa do Produto Clicado
        Produto produto = _db.Produtos
            .Where(p => p.Id == id)
            .Include(p => p.Fotos)
            .Include(p => p.Categoria)
            .SingleOrDefault();
        // Lista de produtos da mesma categoria
        List<Produto> produtos = _db.Produtos
            .Where(p => p.Id != id && p.CategoriaId == produto.CategoriaId)
            .Include(p => p.Fotos)
            .Take(4).ToList();

        // Agrupar o Produto e os Semelhantes no ProdutoVM
        ProdutoVM produtoVM = new()
        {
            Produto = produto,
            Semelhantes = produtos
        };

        return View(produtoVM); 
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
