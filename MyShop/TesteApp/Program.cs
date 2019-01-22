using MyShop.Core.Contracts;
using MyShop.Core.Models;
using MyShop.Services;
using MyShop.WebUI.Controllers;
using MyShop.WebUI.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<Basket> baskets = new MockContext<Basket>();
            IRepository<Product> products = new MockContext<Product>();

            var httpContext = new MockHttpContext();

            IBasketService basketService = new BasketService(products, baskets);
            var controller = new BasketController(basketService);
            controller.ControllerContext = new System.Web.Mvc.ControllerContext(httpContext, new System.Web.Routing.RouteData(), controller);

            //basketService.AddToBasket(httpContext, "1");
            controller.AddToBasket("1");

            Basket basket = baskets.Collection().FirstOrDefault();
        }
    }
}
