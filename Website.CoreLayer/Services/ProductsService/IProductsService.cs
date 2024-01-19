using CodeYad_Blog.CoreLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;

namespace Website.CoreLayer.Services.ProductsService
{
    public interface IProductsService
    {
        OperationResult AddProduct(AddProductDto AddDto);
        OperationResult EditeProduct(EditeProductDto AddDto);
        List<ProductsDto > GetAllProducts();
        ProductsDto GetProductsById(int Id);



    }
}
