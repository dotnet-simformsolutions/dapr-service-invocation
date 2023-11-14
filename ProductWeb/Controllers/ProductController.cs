using Microsoft.AspNetCore.Mvc;
using ProductWeb.Services;
using System.Text.Json;

namespace ProductWeb.Controllers
{
  public class ProductController : Controller
  {
    private readonly ILogger<ProductController> _logger;
    private readonly IproductClient _productClient;
    public ProductController(ILogger<ProductController> logger, IproductClient productClient)
    {
      _logger = logger;
      _productClient = productClient;
    }

    public async Task<IActionResult> Index()
    {
      _logger.LogInformation("Inside Index Method");
      var data = await _productClient.GetProductList();
      _logger.LogInformation($"Returning Data{JsonSerializer.Serialize(data)}");
      return View(data);
    }

  }
}
