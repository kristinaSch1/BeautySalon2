using BeautySalon.Data;
using BeautySalon.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Controllers
{
    public class UserController
    {
        private BeautySalonContext context;
        public UserController()
        {
            context = new BeautySalonContext();
        }
        public UserController(BeautySalonContext context)
        {
            this.context = context;
        }
        public async Task<List<User>> GetAll()
        {
            List<User> users = await context.Users.ToListAsync();
            return users;
        }
        public async Task AddUser(User user)
        {
            if (context.Users.Any(x => x.Username == user.Username))
                throw new ArgumentException("This account already exists!");
            context.Users.Add(user);
            context.SaveChanges();
        }
        public async Task<User> GetUserByUsername(string username, string password)
        {
            if (!context.Users.Any(x => x.Username == username))
                throw new ArgumentException("This account does not exist!");
            if (context.Users.First(x => x.Username == username).Password != password)
                throw new ArgumentException("Wrong username or password!");

            return context.Users.FirstOrDefault((x => x.Username == username && x.Password == password));
        }
    }
}
