using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.ProductDtos;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly CafeContext _context;
        private readonly IMapper _mapper;
        public ProductService(CafeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task ChangeToFalse(int id)
        {
            var values = await _context.Products.FindAsync(id);
            values.Feature = false;
            _context.Products.Update(values);
            await _context.SaveChangesAsync();  

        }

        public async Task ChangeToTrue(int id)
        {
            var values = await _context.Products.FindAsync(id);
            values.Feature= true;
            _context.Products.Update(values);
            await _context.SaveChangesAsync();
        }

        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var values = _mapper.Map<Product>(createProductDto);
            await _context.Products.AddAsync(values);
            await _context.SaveChangesAsync();  
        }

        public async Task DeleteProductAsync(int id)
        {
            var values = await _context.Products.FindAsync(id);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var values = await _context.Products.Include(c=>c.Category).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<List<ResultProductPreviewDto>> GetAllProductPreiewAsync()
        {
            var valeus = await _context.Products.ToListAsync();
            return _mapper.Map<List<ResultProductPreviewDto>>(valeus);
        }

        public async Task<GetProductByIdDto> GetProductByIdAsync(int id)
        {
            var values = await _context.Products.FindAsync(id);
            return _mapper.Map<GetProductByIdDto>(values);
        }

        public async Task<List<ResultProductDto>> GetProductWhileSelectCategory(int id)
        {
            var values = await _context.Products.Where(x=>x.CategoryId==id).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var values = _mapper.Map<Product>(updateProductDto);
            _context.Products.Update(values);
            await _context.SaveChangesAsync();
        }
        
    }
}
