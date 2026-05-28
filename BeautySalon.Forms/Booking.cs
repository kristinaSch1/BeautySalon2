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

        private void Booking_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(CategoryType));
            comboBox1.SelectedIndex = -1;
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
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
            comboBox2.SelectedItem = null;
        }

    }
}
