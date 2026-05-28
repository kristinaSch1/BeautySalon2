using BeautySalon.Data;
using BeautySalon.Data.Entities;
using BeautySalon.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Controllers
{
    public class ServiceController
    {
        private BeautySalonContext context;
        public ServiceController()
        {
            context = new BeautySalonContext();
        }
        public ServiceController(BeautySalonContext context)
        {
            this.context = context;
        }
        public async Task AddService(Service s)
        {
            if (s.Price <= 0)
                throw new ArgumentException("Invalid service price!");
            if (s.Duration <= 0)
                throw new ArgumentException("Invalid service duration!");
            if (context.Services.Any(x => x.Name == s.Name))
                throw new ArgumentException("This service already exists!");

            context.Services.Add(s);
            await context.SaveChangesAsync();
        }
        public async Task<List<Service>> GetServices()
        {
            if (context.Services.Count() == 0)
                throw new ArgumentException("No services!");

            return await context.Services.ToListAsync();
        }

        public async Task UpdateService(Service s)
        {
            if (s.Id < 1)
                throw new ArgumentException("Id is always a positive number!");
            if (!context.Services.Any(x => x.Id == s.Id))
                throw new ArgumentException("No service with the given id!");
            if (s.Price <= 0)
                throw new ArgumentException("Invalid service price!");
            if (s.Duration <= 0)
                throw new ArgumentException("Invalid service duration!");

            Service sToUpdate = context.Services.First(x => x.Id == s.Id);
            sToUpdate.Name = s.Name;
            sToUpdate.Price = s.Price;
            sToUpdate.Duration = s.Duration;
            sToUpdate.Description = s.Description;
            sToUpdate.Category = s.Category;

            await context.SaveChangesAsync();
        }

        public async Task DeleteServiceById(int id)
        {
            if (id < 1)
                throw new ArgumentException("Id is always a positive number!");
            if (!context.Employees.Any(x => x.Id == id))
                throw new ArgumentException("No service with the given id!");

            Service s = context.Services.First(x => x.Id == id);
            context.Services.Remove(s);
            await context.SaveChangesAsync();
        }

        public async Task<List<Service>> GetServicesByCategory(CategoryType cat)
        {
            if (context.Services.Count() == 0)
                throw new ArgumentException("No services in this category!");

            List<Service> services = await context.Services
                .Where(x => x.Category == cat)
                .ToListAsync();

            return services;
        }
    }
}
