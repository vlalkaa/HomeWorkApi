using System;
using MyController.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
namespace MyControllerTest
{
    public class HddMetricsControllerUnitTest
    {
        private readonly HddMetricsController _controller;
        
        public HddMetricsControllerUnitTest() 
        {
            _controller = new HddMetricsController();
        }
        
        [Fact]
        public void GetMetricsLeftFrom_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = _controller.GetMetricsLeftFrom(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}