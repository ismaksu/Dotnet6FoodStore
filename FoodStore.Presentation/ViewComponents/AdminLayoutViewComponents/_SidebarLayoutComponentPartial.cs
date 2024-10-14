using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Presentation.ViewComponents.AdminLayoutViewComponents
{
	public class _SidebarLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
