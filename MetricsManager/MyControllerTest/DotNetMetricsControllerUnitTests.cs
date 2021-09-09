using System;
using MyController.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
namespace MyControllerTest
{
    public class DotNetMetricsControllerUnitTests
    {
        private readonly DotNetMetricsController _controller;

        public DotNetMetricsControllerUnitTests()
        {
            _controller = new DotNetMetricsController();
        }
        
        [Fact]
        public void GetMetricsErrorsCountFrom_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = _controller.GetMetricsErrorsCountFrom(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}