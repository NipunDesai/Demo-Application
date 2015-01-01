using Autofac;
using DemoLearningApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac.Integration.Mvc;

namespace DemoLearningApplication.App_Start
{
    public class IocConfig
    {
        public static IContainer Register()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterControllers(typeof(HomeController).Assembly);
          

            var container = containerBuilder.Build();

            return container;
        }
    }
}