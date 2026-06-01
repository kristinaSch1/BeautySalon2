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
    public partial class RemoveForm : Form
    {
        public RemoveForm()
        {
            InitializeComponent();
        }
        public RemoveForm(string option)
        {
            InitializeComponent();
            Option = option;
        }
        public string Option { get; set; }
        private async void button1_Click(object sender, EventArgs e)
        {
            EmployeeController employeeController = new EmployeeController();
            ServiceController serviceController = new ServiceController();
            if (Option == "Employee")
            {
                List<Employee> emps = await employeeController.GetEmployees();
                foreach (Employee emp in emps)
                {
                    listBox1.Items.Add($"{emp.Id}. {emp.FirstName} {emp.LastName}");
                }
            }
            else if (Option == "Service")
            {
                List<Service> services = await serviceController.GetServices();
                foreach (Service s in services)
                {
                    listBox1.Items.Add($"{s.Id}. {s.Name}");
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            EmployeeController employeeController = new EmployeeController();
            ServiceController serviceController = new ServiceController();
            DialogResult res = MessageBox.Show("Are you sure?", "Confirmation",
                MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    if (Option == "Employee")
                    {
                        int index = listBox1.SelectedIndex;
                        List<Employee> emps = await employeeController.GetEmployees();
                        Employee emp = emps[index];
                        await employeeController.DeleteEmployeeById(emp.Id);
                        DialogResult = DialogResult.OK;
                    }
                    else if (Option == "Service")
                    {
                        int index = listBox1.SelectedIndex;
                        List<Service> services = await serviceController.GetServices();
                        Service s = services[index];
                        await serviceController.DeleteServiceById(s.Id);
                        DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
