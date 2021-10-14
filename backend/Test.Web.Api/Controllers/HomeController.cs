using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Test.Web.Api.Models;

namespace Test.Web.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public TestModel TestAction()
        {
            return new TestModel()
            {
                Count = 2,
                CurrentTime = DateTimeOffset.Now,
                IsAvailable = true,
                Price = 7000.01M,
                Title = "Hello"
            };
        }
    }
}