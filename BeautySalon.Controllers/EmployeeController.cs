using BeautySalon.Data;
using BeautySalon.Data.Entities;
using BeautySalon.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Controllers
{
    public class EmployeeController
    {
        private BeautySalonContext context;
        public EmployeeController()
        {
            context = new BeautySalonContext();
        }
        public EmployeeController(BeautySalonContext context)
        {
            this.context = context;
        }

        public async Task AddEmployee(Employee emp, User user)
        {
            if (context.Users.Any(x => x.Username == user.Username))
                throw new ArgumentException("This account already exists!");
            if (emp.Age < 17)
                throw new ArgumentException("You must be over 16 to make an account!");
            if (emp.PhoneNumber.Any(x => !char.IsDigit(x)) 
                || emp.PhoneNumber.Length != 10 || !emp.PhoneNumber.StartsWith('0'))
                throw new ArgumentException("Invalid phonenumber!");
            if (!emp.Email.Contains('@') || !emp.Email.Contains('.'))
                throw new ArgumentException("Invalid email!");
            List<string> emails = context.Clients.Select(x => x.Email).ToList();
            emails.AddRange(context.Employees.Select(x => x.Email).ToList());
            if (emails.Contains(emp.Email))
                throw new ArgumentException("There is already an account using this email!");
            List<string> pns = context.Clients.Select(x => x.PhoneNumber).ToList();
            pns.AddRange(context.Employees.Select(x => x.PhoneNumber).ToList());
            if (pns.Contains(emp.PhoneNumber))
                throw new ArgumentException("There is already an account using this phone number!");

            context.Users.Add(user);
            context.Employees.Add(emp);
            await context.SaveChangesAsync();
        }

        public async Task<Employee> GetEmployeeByUsername(string username)
        {
            if (!context.Employees.Any(x => x.Username == username))
                throw new ArgumentException("No employee with the given username!");

            Employee emp = await context.Employees.FirstAsync(x => x.Username == username);
            return emp;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            if (context.Employees.Count() == 0)
                throw new ArgumentException("No employees!");

            return await context.Employees.ToListAsync();
        }
        public async Task<List<Appointment>> GetAppointmentsForEmployeeAtDate(int eId, DateTime date)
        {
            if (eId < 1)
                throw new ArgumentException("Id is always a positive number!");
            if (!context.Employees.Any(x => x.Id == eId))
                throw new ArgumentException("No employee with the given id!");

            List<Appointment> apps = await context.Appointments
                .Where(x => x.EmployeeId == eId)
                .Where(x => x.Time.Year == date.Year && x.Time.Month == date.Month 
                    && x.Time.Day == date.Day)
                .Include(x => x.Service)
                .Include(x => x.Client)
                .Include(x => x.Employee)
                .ToListAsync();

            if (apps.Count() == 0)
                throw new ArgumentException("No appointments!");

            return apps;
        }
        public async Task<List<Appointment>> GetAppointmentsForEmployee(int eId)
        {
            if (eId < 1)
                throw new ArgumentException("Id is always a positive number!");
            if (!context.Employees.Any(x => x.Id == eId))
                throw new ArgumentException("No employee with the given id!");

            List<Appointment> apps = await context.Appointments
                .Where(x => x.EmployeeId == eId)
                .Include(x => x.Service)
                .Include(x => x.Client)
                .Include(x => x.Employee)
                .ToListAsync();

            if (apps.Count() == 0)
                throw new ArgumentException("No appointments!");

            return apps;
        }

        public async Task<List<Employee>> GetEmployeesForCategory(CategoryType cat)
        {
            List<Employee> emps = new List<Employee>();
            if(cat == CategoryType.Hair)
            {
                emps = (await context.Employees.ToListAsync())
                    .Where(x => x.Specialty == SpecialtyType.HairStylist)
                    .ToList();
            }
            else if(cat == CategoryType.Manicure || cat == CategoryType.Pedicure)
            {
                emps = (await context.Employees.ToListAsync())
                    .Where(x => x.Specialty == SpecialtyType.NailTech)
                    .ToList();
            }
            else
            {
                emps = (await context.Employees.ToListAsync())
                    .Where(x => x.Specialty == SpecialtyType.MakeupArtist)
                    .ToList();
            }

            return emps;
        }

        public async Task DeleteEmployeeById(int id)
        {
            if (id < 1)
                throw new ArgumentException("Id is always a positive number!");
            if (!context.Employees.Any(x => x.Id == id))
                throw new ArgumentException("No employee with the given id!");

            Employee emp = context.Employees.First(x => x.Id == id);
            User user = context.Users.First(x => x.Username == emp.Username);
            context.Users.Remove(user);
            context.Employees.Remove(emp);
            await context.SaveChangesAsync();
        }
        public async Task UpdateEmployee(Employee e, string password)
        {
            if (e.Id < 1)
                throw new ArgumentException("Id is always a positive number!");
            if (!context.Employees.Any(x => x.Id == e.Id))
                throw new ArgumentException("No employee with the given id!");

            Employee eToUpdate = context.Employees.First(x => x.Id == e.Id);
            User uToUpdate = context.Users.First(x => x.Username == eToUpdate.Username);

            List<string> usernames = context.Users.Select(x => x.Username).ToList();
            usernames.Remove(uToUpdate.Username);
            if (usernames.Any(x => x == e.Username))
                throw new ArgumentException("This account already exists!");
            if (e.Age < 17)
                throw new ArgumentException("You must be over 16 to make an account!");
            if (e.PhoneNumber.Any(x => !char.IsDigit(x)) || e.PhoneNumber.Length != 10
                || !e.PhoneNumber.StartsWith('0'))
                throw new ArgumentException("Invalid phone number!");
            if (!e.Email.Contains('@') || !e.Email.Contains('.'))
                throw new ArgumentException("Invalid email!");
            List<string> emails = context.Clients.Select(x => x.Email).ToList();
            emails.AddRange(context.Employees.Select(x => x.Email).ToList());
            emails.Remove(eToUpdate.Email);
            if (emails.Contains(e.Email))
                throw new ArgumentException("There is already an account using this email!");
            List<string> pns = context.Clients.Select(x => x.PhoneNumber).ToList();
            pns.AddRange(context.Employees.Select(x => x.PhoneNumber).ToList());
            pns.Remove(eToUpdate.PhoneNumber);
            if (pns.Contains(e.PhoneNumber))
                throw new ArgumentException("There is already an account using this phone number!");

            uToUpdate.Username = e.Username;
            uToUpdate.Password = password;
            eToUpdate.FirstName = e.FirstName;
            eToUpdate.LastName = e.LastName;
            eToUpdate.Email = e.Email;
            eToUpdate.PhoneNumber = e.PhoneNumber;
            eToUpdate.Age = e.Age;
            eToUpdate.Username = e.Username;
            eToUpdate.Specialty = e.Specialty;

            await context.SaveChangesAsync();
        }
    }
}
