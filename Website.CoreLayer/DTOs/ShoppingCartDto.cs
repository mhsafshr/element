using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website.CoreLayer.DTOs
{
    public class AddToCartDto
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
    }
  
    public class ShoppingCartDto
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
    }
}
