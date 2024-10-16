using AutoMapper;
using FoodStore.Business.Abstract;
using FoodStore.Dto.DTOs.AboutDTOs;
using FoodStore.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Presentation.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IActionResult AboutList()
        {
            var values = _mapper.Map<List<ResultAboutDto>>(_aboutService.TGetAll());
            return View(values);
        }

        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAbout([FromForm] CreateAboutDto aboutDto)
        {
            _aboutService.TInsert(_mapper.Map<About>(aboutDto));
            return RedirectToAction("AboutList");
        }

        public IActionResult DeleteAbout(int id)
        {
            _aboutService.TDelete(id);
            return RedirectToAction("AboutList");
        }

        public IActionResult UpdateAbout (int id)
        {
            var value = _mapper.Map<UpdateAboutDto>(_aboutService.TGetById(id));
            return View(value);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateAbout([FromForm] UpdateAboutDto aboutDto)
        {
            _aboutService.TUpdate(_mapper.Map<About>(aboutDto));
            return RedirectToAction("AboutList");
        }
    }
}
