using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class FileSourceAdapter : IProductSourceAdapter
    {
        private readonly string _filePath;
        private readonly FileSource _fileSource;

        public FileSourceAdapter(string filePath, FileSource fileSource)
        {

            _filePath = filePath;
            _fileSource = fileSource;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _fileSource.GetProductsFromFile(_filePath);
        }
    }
}
