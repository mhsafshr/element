using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Website.DataLayer.Entities
{
        
    public class Products
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string PathPhoto { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
         public Type Type { get; set; }

        
         

    }
    public enum Type
    {
        Necklace=1, Bracelet , Ring
    }
}
