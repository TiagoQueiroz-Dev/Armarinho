using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Armarinho.Models;
using Armarinho.Database;

namespace Armarinho.Controllers;

public class HomeController : Controller
{
    private Contexto _db;
    public HomeController(Contexto db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var produto = _db.Produtos.ToList();
        return View(produto);
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
