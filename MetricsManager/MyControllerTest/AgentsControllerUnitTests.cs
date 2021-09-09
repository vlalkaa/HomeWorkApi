using System;
using MyController.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using MyController.Models;


namespace MyControllerTest
{
    public class AgentsControllerUnitTests
    {
        private readonly AgentsController  _controller;

        public AgentsControllerUnitTests()
        {
            _controller = new AgentsController();
        }

        [Fact]
        public void RegisterAgent_ReturnsOk()
        {
            var agentInfo = new AgentInfo();
            
            var result = _controller.RegisterAgent(agentInfo);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
        
        [Fact]
        public void EnableAgentById_ReturnsOk()
        {
            var agentId = 5;
            
            var result = _controller.EnableAgentById(agentId);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
        
        [Fact]
        public void DisableAgentById_ReturnsOk()
        {
            var agentId = 5;
            
            var result = _controller.DisableAgentById(agentId);
            
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}