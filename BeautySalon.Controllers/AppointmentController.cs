using BeautySalon.Data;
using BeautySalon.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Controllers
{
    public class AppointmentController
    {
        private BeautySalonContext context;
        public AppointmentController()
        {
            context = new BeautySalonContext();
        }
        public async Task<List<Appointment>> GetAppointments()
        {
            if (context.Appointments.Count() == 0)
                throw new ArgumentException("No appointments!");

            return await context.Appointments
                .Include(x => x.Client)
                .Include(x => x.Employee)
                .Include(x => x.Service)
                .ToListAsync();
        }
        public async Task AddAppointment(Appointment app)
        {
            if (app.ClientId < 1 || app.ServiceId < 1 || app.EmployeeId < 1)
                throw new ArgumentException("Id is always a positive number!");
            if (!context.Clients.Any(x => x.Id == app.ClientId))
                throw new ArgumentException("No client with the given id!");
            if (!context.Services.Any(x => x.Id == app.ServiceId))
                throw new ArgumentException("No service with the given id!");
            if (!context.Employees.Any(x => x.Id == app.EmployeeId))
                throw new ArgumentException("No employee with the given id!");
            if (app.Time < DateTime.Now)
                throw new ArgumentException("Invalid appointment date!");

            context.Appointments.Add(app);
            await context.SaveChangesAsync();
        }

        public async Task<List<Appointment>> GetAppointmentsForClient(int cId)
        {
            if (cId < 1)
                throw new ArgumentException("Id is always a positive number!");
            if (!context.Clients.Any(x => x.Id == cId))
                throw new ArgumentException("No client with the given id!");

            List<Appointment> apps = await context.Appointments
                .Where(x => x.ClientId == cId)
                .Include(x => x.Service)
                .Include(x => x.Client)
                .Include(x => x.Employee)
                .ToListAsync();

            if (apps.Count() == 0)
                throw new ArgumentException("No appointments!");

            return apps;
        }

        //public async Task<List<Appointment>> GetAvailabelAppointmentsForEmployee(int empId)
        //{
        //    List<int> hours = new List<int> { 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        //    List<Appointment> apps = context.Appointments
        //        .Include(x => x.Service)
        //        .Where(x => x.EmployeeId == empId)
        //        .ToList();
        //    List<int> unavailable = new List<int>();
        //    for (int i = 0; i < apps.Count; i++)
        //    {
        //        for (int j = 0; j < apps[i].Service.Duration; j++)
        //        {
        //            unavailable.Add(apps[i].Time.Hour + j);
        //        }
        //    }

        //}
    }
}
