using System.Collections.Generic;

namespace AdapterDesignPattern
{
    public class VendorApiResult<T>
    {
        public int Count { get; set; }
        public List<T> Results { get; set; }
    }
}
