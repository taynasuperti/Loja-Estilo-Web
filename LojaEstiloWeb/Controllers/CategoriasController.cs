using System.Threading.Tasks;
using LojaEstiloWeb.Data;
using LojaEstiloWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;


namespace LojaEstiloWeb.Controllers;
public class CategoriasController : Controller
{
    private readonly ILogger<CategoriasController> _logger;
    private readonly AppDbContext _db;
    private readonly IWebHostEnvironment _host;

    public CategoriasController
        (ILogger<CategoriasController> logger,
        AppDbContext db,
        IWebHostEnvironment host
        )

    {
        _logger = logger;
        _db = db;
        _host = host;
    }

    public IActionResult Index()
    {
        List<Categoria> categorias = _db.Categorias.ToList();
        return View(categorias);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]

    public async Task<IActionResult> Create(Categoria categoria, IFormFile Arquivo)
    {
        if (ModelState.IsValid)
        {
            _db.Categorias.Add(categoria);
            await _db.SaveChangesAsync();

            // Salvar a foto no servidor
            if (Arquivo != null)
            {
                string nomeArquivo = categoria.Id + Path.GetExtension(Arquivo.FileName);
                string caminho = Path.Combine(_host.WebRootPath, "img\\categorias");
                string novoArquivo = Path.Combine(caminho, nomeArquivo);
                using (FileStream stream = new FileStream(novoArquivo, FileMode.Create))
                {
                    await Arquivo.CopyToAsync(stream);
                }

                categoria.Foto = "\\img\\categorias\\" + nomeArquivo;
                await _db.SaveChangesAsync();
            }

            TempData["Success"] = "Categoria cadastra com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        return View(categoria);
    }

    [HttpGet]
    public async Task<IActionResult> Details(int? id) 
    {
        if (id == null)
            return NotFound();
        var categoria = await _db.Categorias.FirstOrDefaultAsync(c => c.Id == id);
        if (categoria == null)
            return NotFound();
        return View(categoria);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int? id) 
    {
        if (id == null)
            return NotFound();
        var categoria = await _db.Categorias.FirstOrDefaultAsync(c => c.Id == id);
        if (categoria == null)
            return NotFound();
        return View(categoria);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Categoria categoria, IFormFile Arquivo)
    {
        if (id != categoria.Id)
            return NotFound();
        if (ModelState.IsValid)
        {
            try
            {
              if (Arquivo != null)
            {
                string nomeArquivo = categoria.Id + Path.GetExtension(Arquivo.FileName);
                string caminho = Path.Combine(_host.WebRootPath, "img\\categorias");
                string novoArquivo = Path.Combine(caminho, nomeArquivo);
                using (FileStream stream = new FileStream(novoArquivo, FileMode.Create))
                {
                    await Arquivo.CopyToAsync(stream);
                }

                categoria.Foto = "\\img\\categorias\\" + nomeArquivo;

                _db.Categorias.Update(categoria);
                await _db.SaveChangesAsync();
            }
  
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

             TempData["Success"] = "Categoria alterada com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        return View(categoria);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int? id) 
    {
        if (id == null)
            return NotFound();
        var categoria = await _db.Categorias.FirstOrDefaultAsync(c => c.Id == id);
        if (categoria == null)
            return NotFound();
        return View(categoria);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var categoria = await _db.Categorias.FindAsync(id);
        if (categoria != null)
            _db.Categorias.Remove(categoria);
        await _db.SaveChangesAsync();
        TempData["Sucess"] = "Categoria Excluída com Sucesso";
        return RedirectToAction(nameof(Index));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}