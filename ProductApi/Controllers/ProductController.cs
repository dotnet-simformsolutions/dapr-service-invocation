using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Service;

namespace ProductApi.Controllers
{
  public class ProductController
  {
    private readonly IproductService _productService;
public ProductController(IproductService productService)
    {
      _productService = productService;
    }
    [HttpGet("getproductlist")]
    public async Task<IEnumerable<ProductData>> Get()
    {
      return await _productService.GetProductData();
    }
  }
}
