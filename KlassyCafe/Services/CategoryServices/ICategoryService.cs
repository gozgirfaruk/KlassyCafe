using KlassyCafe.Dtos.CategoryDtos;

namespace KlassyCafe.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(UpdateCategoryDto categoryDto);
        Task<GetCategoryByIdDto> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync(CreateCategoryDto categoryDto);
        Task ChangeToFalse(int id);
        Task ChangeToTrue(int id);
    }
}
