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
    public class AppointmentControllerTests
    {
        [Test]
        public async Task GetAllWorks()
        {
            var context = BeautySalonContextTest.CreateContext();

            Client c = new Client
            {
                FirstName = "Kristina",
                LastName = "Petrova",
                Age = 17,
                Email = "kpetrova@mail.bg",
                PhoneNumber = "0899823296",
                Username = "kpetrovvaa"
            };

            User user = new User
            {
                Username = "kpetrovvaa",
                Password = "kp22"
            };

            ClientController clientController = new ClientController(context);
            await clientController.AddClient(c, user);

            User user2 = new User
            {
                Username = "emaa",
                Password = "1234"
            };

            Employee emp = new Employee
            {
                FirstName = "Ema",
                LastName = "Shoyleva",
                Age = 35,
                Email = "shoyleva@mail.bg",
                PhoneNumber = "0899345676",
                Username = "shoylevaa",
                Specialty = Data.Enums.SpecialtyType.NailTech
            };

            EmployeeController employeeController = new EmployeeController(context);
            await employeeController.AddEmployee(emp, user2);

            Service s = new Service
            {
                Name = "russian manicure",
                Description = "ewrehtr",
                Duration = 2,
                Price = 35,
                Category = Data.Enums.CategoryType.Manicure
            };

            ServiceController serviceController = new ServiceController(context);
            await serviceController.AddService(s);

            Appointment appointment = new Appointment
            {
                ClientId = 1,
                ServiceId = 1,
                EmployeeId = 1,
                Time = DateTime.Parse("2026-07-22 16:00"),
            };

            AppointmentController appointmentController = new AppointmentController(context);
            await appointmentController.AddAppointment(appointment);
            List<Appointment> apps = await appointmentController.GetAppointments();

            Assert.AreEqual(1, apps.Count);
        }

        [Test]
        public async Task GetAllExc()
        {
            var context = BeautySalonContextTest.CreateContext();
            AppointmentController appointmentController = new AppointmentController(context);
            Assert.ThrowsAsync<ArgumentException>(async () =>
                        await appointmentController.GetAppointments());
        }

        [Test]
        public async Task DeleteWorks()
        {
            var context = BeautySalonContextTest.CreateContext();

            Client c = new Client
            {
                FirstName = "Kristina",
                LastName = "Petrova",
                Age = 17,
                Email = "kpetrova@mail.bg",
                PhoneNumber = "0899823296",
                Username = "kpetrovvaa"
            };

            User user = new User
            {
                Username = "kpetrovvaa",
                Password = "kp22"
            };

            ClientController clientController = new ClientController(context);
            await clientController.AddClient(c, user);

            User user2 = new User
            {
                Username = "emaa",
                Password = "1234"
            };

            Employee emp = new Employee
            {
                FirstName = "Ema",
                LastName = "Shoyleva",
                Age = 35,
                Email = "shoyleva@mail.bg",
                PhoneNumber = "0899345676",
                Username = "shoylevaa",
                Specialty = Data.Enums.SpecialtyType.NailTech
            };

            EmployeeController employeeController = new EmployeeController(context);
            await employeeController.AddEmployee(emp, user2);

            Service s = new Service
            {
                Name = "russian manicure",
                Description = "ewrehtr",
                Duration = 2,
                Price = 35,
                Category = Data.Enums.CategoryType.Manicure
            };

            ServiceController serviceController = new ServiceController(context);
            await serviceController.AddService(s);

            Appointment appointment = new Appointment
            {
                ClientId = 1,
                ServiceId = 1,
                EmployeeId = 1,
                Time = DateTime.Parse("2026-07-22 16:00"),
            };

            AppointmentController appointmentController = new AppointmentController(context);
            await appointmentController.AddAppointment(appointment);
            await appointmentController.DeleteAppById(1);

            Assert.ThrowsAsync<ArgumentException>(async () =>
                        await appointmentController.GetAppointments());
        }
    }
}
