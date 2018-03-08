using ReactiveUI;
using ReactiveUIDemo.Services;
using Splat;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIDemo
{
    public class AppBootsrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; protected set; }

        public AppBootsrapper()
        {
            Router = new RoutingState();

            //We register the service in the locator
            Locator.CurrentMutable.Register(() => new LoginService(), typeof(ILogin));
        }
    }
}
