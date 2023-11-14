using ProductWeb.Models;

namespace ProductWeb.Services
{
  public interface IproductClient
  {
    Task<IEnumerable<ProductData>> GetProductList();
  }
}
