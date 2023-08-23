
using System;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace BlogApp.Components
{
	public class OrderInCompletedViewComponent : ViewComponent
	{
        private readonly IServiceManager _manager;

        public string Invoke()
        {
            return _manager
                .OrderService
                .Orders
                .Count()
                .ToString();
        }
    }
}

