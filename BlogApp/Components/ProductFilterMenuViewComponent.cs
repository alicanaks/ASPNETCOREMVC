using System;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Components
{
	public class ProductFilterMenuViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

