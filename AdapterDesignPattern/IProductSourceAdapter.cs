using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public interface IProductSourceAdapter
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
