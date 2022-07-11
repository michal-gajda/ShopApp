namespace ShopApp.WebUI.Controllers;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Application.Products.Queries;

public class HomeController : Controller
{
    private readonly IMediator mediator;

    public HomeController(IMediator mediator)
        => this.mediator = mediator;

    public async Task<IActionResult> Index(CancellationToken cancellationToken = default)
    {
        var request = new GetProductsOfTheWeek();

        var productsOfTheWeek = await this.mediator.Send(request, cancellationToken);

        return View(productsOfTheWeek);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}