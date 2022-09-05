using Microsoft.AspNetCore.Mvc;

using SimpleApp.Models;

namespace SimpleApp.Controllers;

public class HomeController : Controller
{
    public IDataSource DataSource { get; set; } = new ProductDataSource();

    public ViewResult Index() => View(DataSource.Products);
}
