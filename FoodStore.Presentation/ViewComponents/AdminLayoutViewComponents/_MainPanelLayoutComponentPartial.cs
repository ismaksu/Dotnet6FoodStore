using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Presentation.ViewComponents.AdminLayoutViewComponents
{
	public class _MainPanelLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
