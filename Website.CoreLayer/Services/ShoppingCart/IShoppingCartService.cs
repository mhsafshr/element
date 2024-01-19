using CodeYad_Blog.CoreLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;

namespace Website.CoreLayer.Services.ShoppingCart
{
    public interface IShoppingCartService
    {
        OperationResult AddToCart(ProductsDto AddDto,int userid,int proId);
        OperationResult EditToCartPlus(ShoppingCartDto AddDto);
        OperationResult EditToCartMinus(ShoppingCartDto AddDto);
        OperationResult Delete(int Id);

        List<ShoppingCartDto> GetAllShoppingToCart();
        ShoppingCartDto GetShopToCartById(int Id);
    }
}
