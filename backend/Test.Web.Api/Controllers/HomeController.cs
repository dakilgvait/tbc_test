using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Test.Web.Api.Models;

namespace Test.Web.Api.Controllers
{
    [Route("api/[action]")]
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

        public object Heroes()
        {
            var res = new List<Hero>() {
                new Hero() { Id = 1, Name ="Hero1" },
                new Hero() { Id = 2, Name ="Hero2" },
                new Hero() { Id = 3, Name ="Hero3" },
                new Hero() { Id = 4, Name ="Hero4" },
                new Hero() { Id = 5, Name ="Hero5" },
                new Hero() { Id = 6, Name ="Hero6" }
            };

            return res;
        }
    }
}