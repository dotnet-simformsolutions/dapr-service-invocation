using ProductApi.Models;
using System.Net.Http;

namespace ProductApi.Service
{
  public class ProductService : IproductService
  {
    private static readonly List<ProductData> productList = new List<ProductData>()
    {
      new ProductData{
                  ProductName = "Laptop",
                  ProductAvailability = true,
                  Price = 150000
      },
      new ProductData{
                  ProductName = "MobilePhone",
                  ProductAvailability = false,
                  Price = 20000
            },
      new ProductData{
                  ProductName = "Tablet",
                  ProductAvailability = true,
                  Price = 18085
            }

    };
    public Task<IEnumerable<ProductData>> GetProductData() => Task.FromResult<IEnumerable<ProductData>>(productList);
  }
}
