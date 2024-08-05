using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.ReservationDtos;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services.ReservationServices
{
    public class ReservationService : IReservationService
    {
        private readonly CafeContext _context;
        private readonly IMapper _mapper;
        public ReservationService(CafeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateReservationAsync(CreateReservationDto createReservationDto)
        {
            var values = _mapper.Map<Reservation>(createReservationDto);
            await _context.Reservations.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReservationAsync(int id)
        {
            var values = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(values);   
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultReservationDto>> GetAllReservationAsync()
        {
            var values = await _context.Reservations.ToListAsync();
            return _mapper.Map<List<ResultReservationDto>>(values);
        }

        public async Task<GetReservationByIdDto> GetReservationByIdAsync(int id)
        {
            var values = await _context.Reservations.FindAsync(id);
            return _mapper.Map<GetReservationByIdDto>(values);
        }

        public async Task UpdateReservationAsync(UpdateReservationDto updateReservationDto)
        {
            var values = _mapper.Map<Reservation>(updateReservationDto);
            _context.Reservations.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
