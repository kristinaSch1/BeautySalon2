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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            ClientController clientController = new ClientController();
            EmployeeController employeeController = new EmployeeController();
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter username!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Enter password!");
                return;
            }
            try
            {
                User user = await userController
                    .GetUserByUsername(textBox1.Text, textBox2.Text);

                if (user.Role == Data.Enums.RoleType.Admin)
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    DialogResult res = adminForm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        MessageBox.Show("ok");
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                    this.Show();
                }
                else if (user.Role == Data.Enums.RoleType.Client)
                {
                    Client c = await clientController.GetClientByUsername(user.Username);
                    ClientForm clientForm = new ClientForm(c);
                    this.Hide();
                    DialogResult res = clientForm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        MessageBox.Show("ok");
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                    this.Show();
                }
                else
                {
                    Employee emp = await employeeController.GetEmployeeByUsername(user.Username);
                    EmployeeForm empForm = new EmployeeForm(emp);
                    this.Hide();
                    DialogResult res = empForm.ShowDialog();
                    if (res == DialogResult.Cancel)
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                    this.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
