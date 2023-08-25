using Microsoft.AspNetCore.Mvc;

namespace InternshipApp.Web.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}