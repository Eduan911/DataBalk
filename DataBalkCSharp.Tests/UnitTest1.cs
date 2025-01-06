using Xunit;
using Microsoft.EntityFrameworkCore;
using DataBalkCSharp.Controllers;
using DataBalkCSharp.Models;
using DataBalkCSharp.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DataBalkCSharp.Tests
{
    public class UnitTest1
    {
        private ApplicationDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            var context = new ApplicationDbContext(options);

            DatabaseSeeder.Seed(context);
            return context;
        }

        [Fact]
        public void GetAllTasks_ReturnsOk()
        {

            var dbContext = GetInMemoryDbContext();
            var controller = new TaskController(dbContext);
            var result = controller.GetAllTasks();
            var okResult = Assert.IsType<OkObjectResult>(result);
            var tasks = Assert.IsType<List<UserTask>>(okResult.Value);


            Assert.Empty(tasks); 
        }

        [Fact]
        public void GetTaskById_ReturnsNotFound()
        {
            var dbContext = GetInMemoryDbContext();
            var controller = new TaskController(dbContext);
            var result = controller.GetTaskById(999); 
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void CreateTask_ReturnsCreated()
        {

            var dbContext = GetInMemoryDbContext();
            var controller = new TaskController(dbContext);
            var newTask = new UserTask
            {
                Title = "New Task",
                Description = "New Task Description",
                Assignee = 1, 
                DueDate = System.DateTime.Now
            };

            var result = controller.CreateTask(newTask);
            var createdResult = Assert.IsType<CreatedAtActionResult>(result);
            var task = Assert.IsType<UserTask>(createdResult.Value);
            Assert.Equal("New Task", task.Title);
        }

        [Fact]
        public void GetUserById_ReturnsOk()
        {
            var dbContext = GetInMemoryDbContext();
            var controller = new UserController(dbContext);
            var result = controller.GetUserById(1); 
            var okResult = Assert.IsType<OkObjectResult>(result);
            var user = Assert.IsType<User>(okResult.Value);
            Assert.Equal("JohnDoe", user.Username); 
        }
    }
}
