using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.DataLayer.Entities;

namespace Website.CoreLayer.DTOs
{
    public class AddProductDto
    {
        
        public string Name { get; set; }
        public string Pathphoto { get; set; }
        public int Price { get; set; }
        public DataLayer.Entities.Type Type { get; set; }
    }
    public class EditeProductDto:AddProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pathphoto { get; set; }
        public int Price { get; set; }
        public DataLayer.Entities.Type type { get; set; }
    }
    public class ProductsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pathphoto { get; set; }
        public int Price { get; set; }
        public DataLayer.Entities.Type Type { get; set; }

    }

}
