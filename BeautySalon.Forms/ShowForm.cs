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
            richTextBox1.Clear();
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
                                $"{emp.Specialty.ToString()} " +
                                $"\nAge: {emp.Age}" +
                                $"\nPhone number: {emp.PhoneNumber} " +
                                $"\nEmail: {emp.Email}" +
                                $"\nUsername: {emp.Username} \n";
                            richTextBox1.Text += Environment.NewLine;
                        }
                    }
                    else if (Sender == "ClientForm")
                    {
                        foreach (Employee emp in emps)
                        {
                            richTextBox1.Text += $"{emp.FirstName} {emp.LastName} - " +
                                $"{emp.Specialty.ToString()} " +
                                $"\nPhone number: {emp.PhoneNumber} " +
                                $"\nEmail: {emp.Email} \n";
                            richTextBox1.Text += Environment.NewLine;
                        }
                    }
                }
                else if(Text == "Clients")
                {
                    List<Client> clients = await clientController.GetClients();
                    foreach (Client c in clients)
                    {
                        richTextBox1.Text += $"{c.Id}. {c.FirstName} {c.LastName}" +
                            $"\nPhone number: {c.PhoneNumber}" +
                            $"\nEmail: {c.Email}" +
                            $"\nAge: {c.Age}" +
                            $"\nUsername: {c.Username} \n";
                        richTextBox1.Text += Environment.NewLine;
                    }
                }
                else if(Text == "Services")
                {
                    if (Sender == "AdminForm")
                    {
                        List<Service> services = await serviceController.GetServices();
                        foreach (Service s in services)
                        {
                            richTextBox1.Text += $"{s.Id}. {s.Name} - {s.Description}" +
                                $"\nPrice: {s.Price}€" +
                                $"\nDuration: {s.Duration}h" +
                                $"\nCategory: {s.Category.ToString()} \n";

                            richTextBox1.Text += Environment.NewLine;
                        }
                    }
                    else if(Sender == "ClientForm")
                    {
                        List<Service> services = await serviceController.GetServices();
                        foreach (Service s in services)
                        {
                            richTextBox1.Text += $"{s.Name} - {s.Description}" +
                                $"\nPrice: {s.Price}€" +
                                $"\nDuration: {s.Duration}h" +
                                $"\nCategory: {s.Category.ToString()} \n";
                            richTextBox1.Text += Environment.NewLine;
                        }
                    }
                }
                else if(Text == "Appointments")
                {
                    List<Appointment> apps = await appointmentController
                        .GetAppointments();
                    foreach(Appointment app in apps.OrderBy(x => x.Time))
                    {
                        richTextBox1.Text += $"Time: {app.Time.ToString("dd/MM HH:mm")}" +
                            $"\nEmployee: {app.Employee.FirstName}" +
                            $"\nClient: {app.Client.FirstName}" +
                            $"\nService: {app.Service.Name} \n";
                        richTextBox1.Text += Environment.NewLine;
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
