using Domain.ShopCMS.Abstract;
using Domain.ShopCMS.EfSettings;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ShopCMS.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {

            _kernel.Bind<IProductRepository>().To<EfProductRepository>();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}