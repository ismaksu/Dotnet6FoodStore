using AutoMapper;
using FoodStore.Dto.DTOs.AboutDTOs;
using FoodStore.Dto.DTOs.SliderDTOs;
using FoodStore.Entity.Concrete;

namespace FoodStore.Presentation.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            //About mapping
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<GetByIdAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            //Slider mapping
            CreateMap<ResultSliderDto, Slider>().ReverseMap();
            CreateMap<CreateSliderDto, Slider>().ReverseMap();
            CreateMap<GetByIdSliderDto, Slider>().ReverseMap();
            CreateMap<UpdateSliderDto, Slider>().ReverseMap();
        }
    }
}
