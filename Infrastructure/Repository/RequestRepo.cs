using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Infrastructure.Repository;

public class RequestRepo(IConfiguration configuration)
{
    static readonly HttpClient client = new HttpClient();

    public async Task Prueba()
    {
        try
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", configuration["ApiKey"]);
            
            var url = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest";
            
            var parameters = "?limit=10"; 
            
            string responseBody = await client.GetStringAsync(url + parameters);
            Console.WriteLine(responseBody);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Error en la petición: {e.Message}");
        }
    }
}