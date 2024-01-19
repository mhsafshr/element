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

namespace Website.CoreLayer.Services.ShoppingCart
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly WebContext _context;

        public ShoppingCartService(WebContext context)
        {
            _context = context;
        }
        public OperationResult AddToCart(ProductsDto AddDto,int userid,int productId)
        {
            var Shopping = new ShoppingCarts()
            {

                Name = AddDto.Name,
                Price = AddDto.Price,
                UserId = userid,
                ProductId = productId,
                Number=1
                
            };
            _context.shoppingCarts.Add(Shopping);
            _context.SaveChanges();
            return OperationResult.Success();
        }
        
       

        OperationResult IShoppingCartService.EditToCartPlus(ShoppingCartDto AddDto)
        {
            var Shopping = _context.shoppingCarts.FirstOrDefault(p => p.Id == AddDto.id);
            if (Shopping == null)
            {
                return OperationResult.NotFound();
            }

            Shopping.Name = AddDto.Name;
            Shopping.UserId = AddDto.UserId;
            Shopping.Price = AddDto.Price;
            Shopping.Number = AddDto.Number+1;
            _context.SaveChanges();
            return OperationResult.Success();
        }
        OperationResult IShoppingCartService.EditToCartMinus(ShoppingCartDto AddDto)
        {
            var Shopping = _context.shoppingCarts.FirstOrDefault(p => p.Id == AddDto.id);
            if (Shopping == null)
            {
                return OperationResult.NotFound();
            }

            Shopping.Name = AddDto.Name;
            Shopping.UserId = AddDto.UserId;
            Shopping.Price = AddDto.Price;
            Shopping.Number = AddDto.Number - 1;
            _context.SaveChanges();
            return OperationResult.Success();
        }



        List<ShoppingCartDto> IShoppingCartService.GetAllShoppingToCart()
        {
            return _context.shoppingCarts.Select(shop => CartMapper.Map(shop)).ToList();
        }

       

        ShoppingCartDto IShoppingCartService.GetShopToCartById(int Id)
        {
            var shop = _context.shoppingCarts.FirstOrDefault(p => p.ProductId == Id);
            if (shop == null)
            {
                return null;
            }
            return CartMapper.Map(shop);
        }

        OperationResult IShoppingCartService.Delete(int Id)
        {
            var shop = _context.shoppingCarts.FirstOrDefault(p => p.ProductId == Id);
            
            if (shop == null)
            {
                return OperationResult.NotFound();
            }
            _context.shoppingCarts.Remove(shop);
            _context.SaveChanges();
            return OperationResult.Success();
        }
    }
}
