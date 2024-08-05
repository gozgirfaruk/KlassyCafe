using KlassyCafe.Dtos.ProductDtos;

namespace KlassyCafe.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(int id);
        Task<GetProductByIdDto> GetProductByIdAsync(int id);
        Task ChangeToTrue(int id);
        Task ChangeToFalse(int id);
    }
}
