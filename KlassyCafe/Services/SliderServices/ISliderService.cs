using KlassyCafe.Dtos.SliderDtos;

namespace KlassyCafe.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetSliderListAsync();
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);
        Task DeleteSliderAsync(int id); 
        Task<GetSliderByIdDto> GetSliderByIdAsync(int id);  
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task ChangeStatusToTrue(int id);
        Task ChangeStatusToFalse(int id);
        Task<List<ResultSliderDto>> GetTrueSliderAsync();
    }
}
