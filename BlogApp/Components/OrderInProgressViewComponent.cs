using System;
using Services.Contracts;

namespace BlogApp.Components
{
	public class OrderInProgressViewComponent
	{
        private readonly IServiceManager _manager;

        public OrderInProgressViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager
                .OrderService
                .NumberOfInProcess
                .ToString();

        }

    }
}

