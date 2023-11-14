using ProductWeb.Models;

namespace ProductWeb.Services
{
  public class ProductClient : IproductClient
  {
    private readonly HttpClient _httpClient;
    public ProductClient(HttpClient httpClient)
    {
      _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }
    public async Task<IEnumerable<ProductData>> GetProductList()
    {
      return await _httpClient.GetFromJsonAsync<IEnumerable<ProductData>>("/getproductlist");
    }

  }
}
