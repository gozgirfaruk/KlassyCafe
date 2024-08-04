using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.CategoryDtos;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly CafeContext _context;
        private readonly IMapper _mapper;

        public CategoryService(CafeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task ChangeToFalse(int id)
        {
            var values = await _context.Categories.FindAsync(id);
            values.Status = false;
            _context.Categories.Update(values);
            await _context.SaveChangesAsync();
        }

        public async Task ChangeToTrue(int id)
        {
            var values = await _context.Categories.FindAsync(id);
            values.Status = true;
            _context.Categories.Update(values);
            await _context.SaveChangesAsync();
        }

        public async Task CreateCategoryAsync(CreateCategoryDto categoryDto)
        {
            var values = _mapper.Map<Category>(categoryDto);
            await _context.Categories.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var values = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            var values = await _context.Categories.ToListAsync();
            return _mapper.Map<List<ResultCategoryDto>>(values);
        }

        public async Task<GetCategoryByIdDto> GetCategoryByIdAsync(int id)
        {
            var values = await _context.Categories.FindAsync(id);
            return _mapper.Map<GetCategoryByIdDto>(values);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto categoryDto)
        {
            var values = _mapper.Map<Category>(categoryDto);
             _context.Categories.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
