using System.Collections.Generic;

namespace eCommerce.Models;

public class ProductListViewModel
{
    public required IEnumerable<Product> Products { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int ProductsPerPage { get; set; }
    public int TotalProducts { get; set; }
}
