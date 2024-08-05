using KlassyCafe.Dtos.ReservationDtos;

namespace KlassyCafe.Services.ReservationServices
{
    public interface IReservationService
    {
        Task<List<ResultReservationDto>> GetAllReservationAsync();
        Task CreateReservationAsync(CreateReservationDto createReservationDto);
        Task UpdateReservationAsync(UpdateReservationDto updateReservationDto);
        Task DeleteReservationAsync(int id);
        Task<GetReservationByIdDto> GetReservationByIdAsync(int id);
    }
}
