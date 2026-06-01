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
            listBox1.Items.Clear();
            EmployeeController employeeController = new EmployeeController();
            AppointmentController appointmentController = new AppointmentController();
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Choose an option!");
                return;
            }

            DateTime date = dateTimePicker1.Value;

            try
            {
                if (radioButton1.Checked)
                {
                    List<Appointment> apps = await employeeController
                        .GetAppointmentsForEmployeeAtDate(Employee.Id, date);
                    foreach (Appointment app in apps.OrderBy(x => x.Time))
                    {
                        listBox1.Items.Add($"{app.Time.TimeOfDay}, {app.Service.Name} for {app.Client.FirstName} \n");
                    }
                    listBox1.Visible = true;
                }
                else if (radioButton2.Checked)
                {
                    List<int> times = await appointmentController
                        .GetAvailabelAppointmentsForEmployee(Employee.Id, date);
                    foreach (int time in times)
                    {
                        listBox1.Items.Add((time == 9) ? $"0{time}:00 \n" : $"{time}:00 \n");
                    }
                    listBox1.Visible = true;
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

        private async void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Select appointment!");
                return;
            }

            if (radioButton1.Checked)
            {
                if (listBox1.SelectedItem != null)
                {
                    DialogResult res = MessageBox.Show("Are you sure?", "Confirmation",
                        MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        int index = listBox1.SelectedIndex;
                        try
                        {
                            AppointmentController appointmentController = new AppointmentController();
                            List<Appointment> apps = await appointmentController.GetAppointments();
                            int id = apps[index].Id;
                            await appointmentController.DeleteAppById(id);
                            MessageBox.Show("Cancelled appointment!");
                            listBox1.SelectedItem = null;
                            listBox1.Items.Clear();
                            listBox1.Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a booked appointment!");
            }
        }
    }
}
