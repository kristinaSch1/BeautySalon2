using BeautySalon.Controllers;
using BeautySalon.Data.Entities;
using BeautySalon.Tests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Tests.Services
{
    public class UserControllerTests
    {
        [Test]
        public async Task AddUserWorks()
        {
            var context = BeautySalonContextTest.CreateContext();

            User user = new User
            {
                Username = "kpetrovvaa",
                Password = "kp22"
            };
            UserController userController = new UserController(context);
            await userController.AddUser(user);
            var users = await userController.GetAll();
            int count = users.Count();
            Assert.AreEqual(2, count);
        }
    }
}
