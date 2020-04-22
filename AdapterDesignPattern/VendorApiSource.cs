using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdapterDesignPattern
{
    public class VendorApiSource
    {
        public async Task<List<Product>> GetProducts(string clientApiUrl)
        {
            using (var client = new HttpClient())
            {
                var url = clientApiUrl;
                var result = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<VendorApiResult<Product>>(result).Results;
            }
        }
    }
}
