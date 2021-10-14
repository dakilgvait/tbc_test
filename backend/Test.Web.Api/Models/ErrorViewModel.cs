using System;

namespace Test.Web.Api.Models
{
    public class TestModel
    {
        public string Title { get; set; }
        public DateTimeOffset CurrentTime { get; set; }
        public bool IsAvailable { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}