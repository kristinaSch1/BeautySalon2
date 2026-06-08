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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BeautySalon.Forms
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        public ClientForm(Client c)
        {
            InitializeComponent();
            Client = c;
        }
        public Client Client { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowForm form = new ShowForm("Employees", "ClientForm");
            DialogResult res = form.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowForm form = new ShowForm("Services", "ClientForm");
            DialogResult res = form.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking form = new Booking(Client);
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Booked appointment!");
            }
            this.Show();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AppointmentController appointmentController = new AppointmentController();
            try
            {
                List<Appointment> apps = await appointmentController
                        .GetAppointmentsForClient(Client.Id);
                foreach (Appointment app in apps.OrderBy(x => x.Time))
                {
                    listBox1.Items.Add($"{app.Service.Name} by {app.Employee.FirstName}" +
                        $" - {app.Time.ToString("dd/MM HH:mm")}");
                    listBox1.Items.Add(Environment.NewLine);
                }
                listBox1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Select appointment!");
                return;
            }

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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            AppointmentController appointmentController = new AppointmentController();
            try
            {
                decimal sum = await appointmentController.GetTotalPriceForClient(Client.Id);
                MessageBox.Show($"Total price: {sum}€");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
