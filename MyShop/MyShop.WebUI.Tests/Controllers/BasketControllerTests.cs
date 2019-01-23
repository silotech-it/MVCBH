using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShop.Core.Contracts;
using MyShop.Core.Models;
using MyShop.WebUI.Tests.Mocks;
using MyShop.Services;
using System.Linq;
using MyShop.WebUI.Controllers;

namespace MyShop.WebUI.Tests.Controllers
{
    /// <summary>
    /// Descrição resumida para BasketControllerTests
    /// </summary>
    [TestClass]
    public class BasketControllerTests
    {

        [TestMethod]
        public void CanAddBasketItem()
        {
            IRepository<Basket> baskets = new MockContext<Basket>();
            IRepository<Product> products = new MockContext<Product>();
            IRepository<Order> orders = new MockContext<Order>();
            
            var httpContext = new MockHttpContext();

            IBasketService basketService = new BasketService(products, baskets);
            IOrderService orderService = new OrderService(orders);
            //var controller = new BasketController(basketService, orderService);
            //controller.ControllerContext = new System.Web.Mvc.ControllerContext(httpContext, new System.Web.Routing.RouteData(), controller);

            //basketService.AddToBasket(httpContext, "1");
            //controller.AddToBasket("1", httpContext);

            Basket basket = baskets.Collection().FirstOrDefault();

            Assert.IsNull(basket);
        }
    }
}
