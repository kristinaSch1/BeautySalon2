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
            Booking form = new Booking();
            DialogResult res = form.ShowDialog();
            this.Show();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            AppointmentController appointmentController = new AppointmentController();
            try
            {
                List<Appointment> apps = await appointmentController
                        .GetAppointmentsForClient(Client.Id);
                foreach (Appointment app in apps)
                {
                    richTextBox1.Text += $"{app.Time}, {app.Service.Name}, {app.Client.FirstName} \n";
                }

                richTextBox1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
