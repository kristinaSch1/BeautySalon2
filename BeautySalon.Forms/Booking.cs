using BeautySalon.Controllers;
using BeautySalon.Data.Entities;
using BeautySalon.Data.Enums;
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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        public Booking(Client c)
        {
            InitializeComponent();
            Client = c;
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(CategoryType));
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
        public Client Client { get; set; }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                return;
            }

            CategoryType type = (CategoryType)comboBox1.SelectedItem;
            EmployeeController employeeController = new EmployeeController();
            ServiceController serviceController = new ServiceController();
            List<Employee> emps = await employeeController.GetEmployeesForCategory(type);
            comboBox2.DataSource = emps;
            comboBox2.DisplayMember = "FirstName";
            comboBox2.Visible = true;
            comboBox2.SelectedItem = null;

            List<Service> services = await serviceController.GetServicesByCategory(type);
            comboBox3.DataSource = services;
            comboBox3.DisplayMember = "Name";
            comboBox3.Visible = true;
            comboBox3.SelectedItem = null;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Select an employee!");
                return;
            }
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Select a service!");
                return;
            }
            Employee emp = (Employee)comboBox2.SelectedItem;
            Service service = (Service)comboBox3.SelectedItem;
            DateTime date = dateTimePicker1.Value;
            if(date < DateTime.Now)
            {
                MessageBox.Show("Invalid date!");
                return;
            }
            AppointmentController appointmentController = new AppointmentController();
            try
            {
                List<int> apps = await appointmentController
                    .GetAvailableAppsForService(emp.Id, date, service);
                comboBox4.DataSource = apps;
                comboBox4.Visible = true;
                button2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Select an employee!");
                return;
            }
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Select a service!");
                return;
            }
            Employee emp = (Employee)comboBox2.SelectedItem;
            Service service = (Service)comboBox3.SelectedItem;
            DateTime date = dateTimePicker1.Value;
            int time = (int)comboBox4.SelectedItem;
            DateTime date2 = new DateTime(date.Year, date.Month, date.Day, time, 0, 0);
            Appointment app = new Appointment
            {
                ClientId = Client.Id,
                EmployeeId = emp.Id,
                ServiceId = service.Id,
                Time = date2
            };

            AppointmentController appointmentController = new AppointmentController();
            try
            {
                await appointmentController.AddAppointment(app);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
