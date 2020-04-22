using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class ProductDisplayService
    {
        private readonly IProductSourceAdapter _productSourceAdapter;

        public ProductDisplayService(IProductSourceAdapter productSourceAdapter)
        {
            _productSourceAdapter = productSourceAdapter;
        }

        public async Task<string> GetProducts()
        {
            var products = await _productSourceAdapter.GetProducts();

            var sb = new StringBuilder();
            foreach (Product product in products)
            {
                sb.AppendLine($"{product.Name} :: {product.Description} :: {product.Price}");
            }

            return sb.ToString();
        }
    }
}
