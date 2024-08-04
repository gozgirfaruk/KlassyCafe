using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.SliderDtos;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services.SliderServices
{
    public class SliderService : ISliderService
    {
        private readonly CafeContext _context;
        private readonly IMapper _mapper;

        public SliderService(CafeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task ChangeStatusToFalse(int id)
        {
            var values = await _context.Sliders.FindAsync(id);
            values.Status = false;
            _context.Sliders.Update(values);
            await _context.SaveChangesAsync();

        }

        public async Task ChangeStatusToTrue(int id)
        {
            var values = await _context.Sliders.FindAsync(id);
            values.Status=true;
            _context.Sliders.Update(values);
            await _context.SaveChangesAsync();
        }

        public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            var valeus = _mapper.Map<Slider>(createSliderDto);
            await _context.Sliders.AddAsync(valeus);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSliderAsync(int id)
        {
           var values = await _context.Sliders.FindAsync(id);
             _context.Sliders.Remove(values);
           await _context.SaveChangesAsync();
        }

        public async Task<GetSliderByIdDto> GetSliderByIdAsync(int id)
        {
            var values = await _context.Sliders.FindAsync(id);
            return _mapper.Map<GetSliderByIdDto>(values);
        }

        public async Task<List<ResultSliderDto>> GetSliderListAsync()
        {
            var values = await _context.Sliders.ToListAsync();
            return _mapper.Map<List<ResultSliderDto>>(values);
        }

        public async Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            var values = _mapper.Map<Slider>(updateSliderDto);
             _context.Sliders.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
