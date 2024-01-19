using CodeYad_Blog.CoreLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;
using Website.CoreLayer.Mapper;
using Website.DataLayer.Context;
using Website.DataLayer.Entities;

namespace Website.CoreLayer.Services.ProductsService
{
    public class ProductsService : IProductsService
    {
        private readonly WebContext _context;

        public ProductsService(WebContext context)
        {
            _context = context;
        }

        public OperationResult AddProduct(AddProductDto AddDto)
        {
            var product = new Products()
            {
               
                Name = AddDto.Name,
                PathPhoto = AddDto.Pathphoto,
                Price = AddDto.Price,
                Type = AddDto.Type
            };
           _context.Products.Add(product);  
            _context.SaveChanges();
            return OperationResult.Success();
        }

       

        public OperationResult EditeProduct(EditeProductDto AddDto)
        {
            var product = _context.Products.FirstOrDefault(p=>p.Id == AddDto.Id);
            if (product == null)
            {
                return  OperationResult.NotFound();
            }
            
            product.Name = AddDto.Name;
            product.PathPhoto = AddDto.Pathphoto;
            product.Price = AddDto.Price;
            product.Type = AddDto.type;
            _context.SaveChanges();
            return OperationResult.Success();
        }

        

        public List<ProductsDto> GetAllProducts()
        {
            return _context.Products.Select(product=>ProductMapper.Map(product)).ToList();
        }

        public ProductsDto GetProductsById(int Id)
        {
            var product = _context.Products.FirstOrDefault(p=>p.Id == Id);
            if (product == null)
            {
                return null;
            }
            return ProductMapper.Map(product);

        }


    }
}
