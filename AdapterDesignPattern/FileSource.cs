using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdapterDesignPattern
{
    public class FileSource
    {
        public async Task<List<Product>> GetProductsFromFile(string filePath)
        {
            return JsonConvert.DeserializeObject<List<Product>>(await File.ReadAllTextAsync(filePath));
        }
    }
}
