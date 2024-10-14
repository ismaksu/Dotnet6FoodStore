using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Presentation.ViewComponents.AdminLayoutViewComponents
{
	public class _ScriptsLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
