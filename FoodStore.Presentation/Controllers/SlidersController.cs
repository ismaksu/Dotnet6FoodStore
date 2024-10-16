﻿using AutoMapper;
using FoodStore.Business.Abstract;
using FoodStore.Dto.DTOs.SliderDTOs;
using FoodStore.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Presentation.Controllers
{
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SlidersController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        public IActionResult SliderList()
        {
            var values = _sliderService.TGetAll();
            return View(_mapper.Map<List<ResultSliderDto>>(values));
        }

        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSlider([FromForm] CreateSliderDto sliderDto, IFormFile file)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "sliderImages", file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            sliderDto.ImageUrl = file.FileName;
            var value = _mapper.Map<Slider>(sliderDto);
            _sliderService.TInsert(value);
            return RedirectToAction("SliderList");
        }

        public IActionResult DeleteSlider(int id)
        {
            _sliderService.TDelete(id);
            return RedirectToAction("SliderList");
        }

        public IActionResult UpdateSlider(int id)
        {
            var value = _mapper.Map<UpdateSliderDto>(_sliderService.TGetById(id));
            return View(value);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateSlider([FromForm] UpdateSliderDto sliderDto, IFormFile file)
        {
            if (file is not null)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "sliderImages", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                sliderDto.ImageUrl = file.FileName;
            }
            _sliderService.TUpdate(_mapper.Map<Slider>(sliderDto));
            return RedirectToAction("SliderList");
        }
    }
}
