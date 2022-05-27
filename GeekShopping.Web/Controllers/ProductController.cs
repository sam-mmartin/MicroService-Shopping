using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers;

public class ProductController : Controller
{
   private readonly IProductService _productService;

   public ProductController(IProductService productService)
   {
      _productService = productService ?? throw new ArgumentNullException(nameof(productService));
   }

   public async Task<IActionResult> Products()
   {
      var products = await _productService.FindAllProducts();
      return View(products);
   }

   public IActionResult Create()
   {
      return View();
   }

   [HttpPost]
   public async Task<IActionResult> Create(ProductModel model)
   {
      if (ModelState.IsValid)
      {
         var response = await _productService.CreateProduct(model);

         if (response != null)
         {
            return RedirectToAction(nameof(Products));
         }
      }

      return View(model);
   }

   public async Task<IActionResult> Update(int id)
   {
      var product = await _productService.FindProductById(id);
      if (product != null)
      {
         return View(product);
      }

      return NotFound();
   }

   [HttpPost]
   public async Task<IActionResult> Update(ProductModel model)
   {
      if (ModelState.IsValid)
      {
         var response = await _productService.UpdateProduct(model);

         if (response != null)
         {
            return RedirectToAction(nameof(Products));
         }
      }

      return View(model);
   }

   [HttpPost]
   public async Task<IActionResult> Delete(int id)
   {
      var response = await _productService.DeleteProductById(id);

      if (response)
      {
         return RedirectToAction(nameof(Products));
      }

      return BadRequest("Erro ao excluir produto!");
   }
}