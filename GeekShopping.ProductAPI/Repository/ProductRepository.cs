using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Models;
using GeekShopping.ProductAPI.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
   public class ProductRepository : IProductRepository
   {
      private readonly MySqlContext _context;
      private IMapper _mapper;

      public ProductRepository(MySqlContext context, IMapper mapper)
      {
         _context = context;
         _mapper = mapper;
      }

      public async Task<ProductVO> Create(ProductVO vo)
      {
         var product = _mapper.Map<Product>(vo);
         _context.Products.Add(product);
         await _context.SaveChangesAsync();
         return _mapper.Map<ProductVO>(product);
      }

      public async Task<bool> Delete(long id)
      {
         try
         {
            var product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();

            if (product == null)
            {
               return false;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
         }
         catch (Exception)
         {
            return false;
         }
      }

      public async Task<IEnumerable<ProductVO>> FindAll()
      {
         // Busca a lista de produtos do banco
         var products = await _context.Products.ToListAsync();
         // Mapeia a lista de produtos para uma lista de VO
         return _mapper.Map<List<ProductVO>>(products);
      }

      public async Task<ProductVO> FindById(long id)
      {
         var product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
         // Mapeia a lista de produtos para uma lista de VO
         return _mapper.Map<ProductVO>(product);
      }

      public async Task<ProductVO> Update(ProductVO vo)
      {
         var product = _mapper.Map<Product>(vo);
         _context.Products.Update(product);
         await _context.SaveChangesAsync();
         return _mapper.Map<ProductVO>(product);
      }
   }
}