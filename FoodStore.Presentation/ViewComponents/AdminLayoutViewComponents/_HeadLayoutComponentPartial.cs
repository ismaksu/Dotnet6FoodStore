using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Presentation.ViewComponents.AdminLayoutViewComponents
{
	public class _HeadLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
