using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repository;

public class RequestRepo(IConfiguration configuration)
{
    static readonly HttpClient client = new HttpClient();

    public async Task CheckBTCPrice()
    {
        try
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", configuration["ApiKey"]);
            
            var url = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest";
            
            var parameters = "?limit=1"; 
            
            var responseBody = JsonDocument.Parse(await client.GetStringAsync(url + parameters));
            var price = responseBody.RootElement.GetProperty("data")[0].GetProperty("quote").GetProperty("USD").GetProperty("price").GetRawText();
            Console.WriteLine($"{decimal.Round(decimal.Parse(price), 2)} USD");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Error en la petición: {e.Message}");
        }
    }
}