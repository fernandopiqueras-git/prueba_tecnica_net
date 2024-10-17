using Prueba_tecnica.Clases;

namespace Prueba_tecnica.Services
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Service_Api
    {
        private readonly HttpClient _httpClient;

        public Service_Api(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Método que consume la API externa y devuelve una lista de Data_Test
        public async Task<List<Data_Test>> GetMarketData()
        {
            var response = await _httpClient.GetAsync("https://api.opendata.esett.com/marketdata");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Data_Test>>(json); //Deserializar el JSON
                return data;
            }

            return null;
        }
    }
}
