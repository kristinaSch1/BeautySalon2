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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(Employee emp)
        {
            InitializeComponent();
            Employee = emp;
        }
        public Employee Employee { get; set; }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            EmployeeController employeeController = new EmployeeController();
            if(radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Choose an option!");
                return;
            }

            try
            {
                if (radioButton1.Checked)
                {
                    List<Appointment> apps = await employeeController
                        .GetAppointmentsForEmployee(Employee.Id);
                    foreach (Appointment app in apps)
                    {
                        richTextBox1.Text += $"{app.Time}, {app.Service.Name}, {app.Client.FirstName} \n";
                    }
                }
                else if(radioButton2.Checked)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
