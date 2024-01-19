using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;
using Website.DataLayer.Entities;

namespace Website.CoreLayer.Mapper
{
    public class ProductMapper
    {
        public static ProductsDto Map (Products product)
        {
            return new ProductsDto()
            {
                Id = product.Id,
                Name = product.Name,
                Pathphoto = product.PathPhoto,
                Price = product.Price,
                Type = product.Type

            };
        }
       
    }
}
