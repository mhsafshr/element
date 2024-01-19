using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;
using Website.DataLayer.Entities;

namespace Website.CoreLayer.Mapper
{
    public class CartMapper
    {
        public static ShoppingCartDto Map(ShoppingCarts carts)
        {
            return new ShoppingCartDto()
            {
                id = carts.Id,
                ProductId = carts.ProductId,
                Name = carts.Name,
                UserId = carts.UserId,
                Price = carts.Price,
                Number = carts.Number

            };
        }
    }
}
