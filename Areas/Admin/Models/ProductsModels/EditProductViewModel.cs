using System.ComponentModel.DataAnnotations;

namespace WebSite.Areas.Admin.Models.ProductsModels

{
    public class EditProductViewModel
    {
        public int Id { get; set; }
        [Display(Name = " نام محصول ")]
        [Required(ErrorMessage = "وارد کردن {0}اجباری است")]
        public string Name { get; set; }
        [Display(Name = " مسیر عکس را مشخص کنید ")]
        [DataType(DataType.ImageUrl)]
        public string Pathphoto { get; set; }

        public int Price { get; set; }
        [Display(Name = " دسته بندی ")]
        [Required(ErrorMessage = "وارد کردن {0}اجباری است")]
        public Website.DataLayer.Entities.Type type { get; set; }
       
    }
}
