using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectConntrollerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectConntrollerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBinds();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBinds() { }
    }
}