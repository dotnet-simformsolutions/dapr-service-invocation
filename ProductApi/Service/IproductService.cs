using ProductApi.Models;

namespace ProductApi.Service
{
  public interface IproductService
  {
    Task<IEnumerable<ProductData>> GetProductData();
  }
}
