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
    public class ClientController
    {
        private BeautySalonContext context;

        public ClientController()
        {
            context = new BeautySalonContext();
        }

        public async Task AddClient(Client client, User user)
        {
            if (context.Users.Any(x => x.Username == user.Username))
                throw new ArgumentException("This account already exists!");
            if (client.Age < 17)
                throw new ArgumentException("You must be over 16 to make an account!");
            if (client.PhoneNumber.Any(x => !char.IsDigit(x)))
                throw new ArgumentException("Invalid phone number!");
            if (!client.Email.Contains('@'))
                throw new ArgumentException("Invalid email!");

            List<string> emails = context.Clients.Select(x => x.Email).ToList();
            emails.AddRange(context.Employees.Select(x => x.Email).ToList());
            if (emails.Contains(client.Email))
                throw new ArgumentException("There is already an account using this email!");
            List<string> pns = context.Clients.Select(x => x.PhoneNumber).ToList();
            pns.AddRange(context.Employees.Select(x => x.PhoneNumber).ToList());
            if (pns.Contains(client.PhoneNumber))
                throw new ArgumentException("There is already an account using this phone number!");
            context.Users.Add(user);
            context.Clients.Add(client);
            context.SaveChanges();
        }
        public async Task<Client> GetClientByUsername(string username)
        {
            Client c = await context.Clients.FirstOrDefaultAsync(x => x.Username == username);
            return c;
        }

        public async Task<List<Client>> GetClients()
        {
            if(context.Clients.Count() == 0)
                throw new ArgumentException("No clients!");

            return await context.Clients.ToListAsync();
        }
    }
}
