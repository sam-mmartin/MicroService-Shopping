using System.ComponentModel;

namespace GeekShopping.Web.Models
{
   public class ProductModel
   {
      public long Id { get; set; }

      [DisplayName("Produto")]
      public string Name { get; set; }
      [DisplayName("Preço")]
      public decimal Price { get; set; }
      [DisplayName("Descrição")]
      public string? Description { get; set; }
      [DisplayName("Categoria")]
      public string? Category { get; set; }
      public string? ImageURL { get; set; }
   }
}