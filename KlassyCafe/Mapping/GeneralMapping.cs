using AutoMapper;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.SliderDtos;

namespace KlassyCafe.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, GetSliderByIdDto>().ReverseMap();
        }
    }
}
