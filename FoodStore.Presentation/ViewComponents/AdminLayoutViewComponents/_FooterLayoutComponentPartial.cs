using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Presentation.ViewComponents.AdminLayoutViewComponents
{
	public class _FooterLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
