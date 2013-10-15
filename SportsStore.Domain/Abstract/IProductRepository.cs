using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportsStore.Domain.Entities;
using Moq;

namespace SportsStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        private void AddBindings()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
        }
    }
}
