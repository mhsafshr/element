using CodeYad_Blog.CoreLayer.Utilities;
using Microsoft.AspNetCore.Mvc;
using Website.CoreLayer.DTOs;
using Website.CoreLayer.Services.ProductsService;
using WebSite.Areas.Admin.Models.ProductsModels;

namespace WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public IActionResult Index()
        {
            return View(_productsService.GetAllProducts());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddProductViewModel addViewModel)
        {
            var result = _productsService.AddProduct(addViewModel.MapToDto());

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = _productsService.GetProductsById(id);
            if (product == null)
            {
              return  RedirectToAction("Index");
            }
            var model = new EditProductViewModel()
            {

                Name = product.Name,
                Price = product.Price,
                Pathphoto = product.Pathphoto,
                type = product.Type

            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,EditProductViewModel editProductViewModel) 
        {
            var result = _productsService.EditeProduct(new EditeProductDto()
            {
                Name = editProductViewModel.Name,
                Price = editProductViewModel.Price,
                Pathphoto = editProductViewModel.Pathphoto,
                type = editProductViewModel.type,
                Id = id
                
            });
            if (result.Status != OperationResultStatus.Success)
            {
                ModelState.AddModelError(nameof(editProductViewModel.Name),result.Message);
                return View();
            }
            return RedirectToAction("Index");
        }

    }
} 
