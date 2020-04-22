using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class VendorApiSourceAdapter : IProductSourceAdapter
    {
        private readonly string _clientApiUrl;
        private readonly VendorApiSource _vendorApiSource;

        public VendorApiSourceAdapter(string clientApiUrl, VendorApiSource vendorApiSource)
        {
            _clientApiUrl = clientApiUrl;
            _vendorApiSource = vendorApiSource;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _vendorApiSource.GetProducts(_clientApiUrl);
        }
    }
}
