using System;
using MyController.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
namespace MyControllerTest
{
    public class RamMetricsControllerUnitTest
    {
        private readonly RamMetricsController _controller;
        
        public RamMetricsControllerUnitTest() 
        {
            _controller = new RamMetricsController();
        }
        
        [Fact]
        public void GetMetricsAvailableFrom_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = _controller.GetMetricsAvailableFrom(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}