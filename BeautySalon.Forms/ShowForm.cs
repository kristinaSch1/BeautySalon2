using BeautySalon.Controllers;
using BeautySalon.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon.Forms
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            InitializeComponent();
        }
        public ShowForm(string text, string sender)
        {
            InitializeComponent();
            Text = text;
            Sender = sender;
        }
        public string Text { get; set; }
        public string Sender { get; set; }
        private async void button1_Click(object sender, EventArgs e)
        {
            EmployeeController employeeController = new EmployeeController();
            ClientController clientController = new ClientController();
            ServiceController serviceController = new ServiceController();
            AppointmentController appointmentController = new AppointmentController();
            try
            {
                if (Text == "Employees")
                {
                    List<Employee> emps = await employeeController.GetEmployees();
                    if (Sender == "AdminForm")
                    {
                        foreach (Employee emp in emps)
                        {
                            richTextBox1.Text += $"{emp.Id}. {emp.FirstName} {emp.LastName} - " +
                                $"{emp.Specialty.ToString()}, {emp.Age}, {emp.PhoneNumber}," +
                                $" {emp.Email}, {emp.Username} \n";
                        }
                    }
                    else if (Sender == "ClientForm")
                    {
                        foreach (Employee emp in emps)
                        {
                            richTextBox1.Text += $"{emp.FirstName} {emp.LastName} - " +
                                $"{emp.Specialty.ToString()}; {emp.PhoneNumber}, " +
                                $"{emp.Email} \n";
                        }
                    }
                }
                else if(Text == "Clients")
                {
                    List<Client> clients = await clientController.GetClients();
                    foreach (Client c in clients)
                    {
                        richTextBox1.Text += $"{c.Id}. {c.FirstName} {c.LastName}, " +
                            $"{c.PhoneNumber}, {c.Email}, {c.Username}, {c.Age} \n";
                    }
                }
                else if(Text == "Services")
                {
                    List<Service> services = await serviceController.GetServices();
                    foreach(Service s in services)
                    {
                        richTextBox1.Text += $"{s.Name} - {s.Description}, {s.Price}, " +
                            $"{s.Duration}, {s.Category.ToString()} \n";
                    }
                }
                else if(Text == "Appointments")
                {
                    List<Appointment> apps = await appointmentController
                        .GetAppointments();
                    foreach(Appointment app in apps)
                    {
                        richTextBox1.Text += $"{app.Employee.FirstName}, " +
                            $"{app.Client.FirstName}, {app.Service.Name}, {app.Time}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
