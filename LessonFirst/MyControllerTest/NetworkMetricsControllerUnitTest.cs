using System;
using MyController.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
namespace MyControllerTest
{
    public class NetworkMetricsControllerUnitTest
    {
        private readonly NetworkMetricsController _controller;
        
        public NetworkMetricsControllerUnitTest()
        {
            _controller = new NetworkMetricsController();
        }
        
        [Fact]
        public void GetMetricsFrom_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = _controller.GetMetricsFrom(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result); 
        }
    }
}