using BeautySalon.Controllers;
using BeautySalon.Data.Entities;
using BeautySalon.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public Register(string role)
        {
            InitializeComponent();
            if (role == "admin")
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label8.Visible = false;
                comboBox1.Visible = false;
            }
            else if(role == "client")
            {
                label8.Visible = false;
                comboBox1.Visible = false;
            }
            else if (role == "UpdateEmployee")
            {
                label9.Visible = true;
                textBox8.Visible = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            if(string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Enter username!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Enter password!");
                return;
            }
            
            string username = textBox6.Text;
            string password = textBox7.Text;
            try
            {
                if (label1.Visible == false)
                {
                    User user = new User
                    {
                        Username = username,
                        Password = password,
                        Role = RoleType.Admin
                    };
                    await userController.AddUser(user);
                    DialogResult = DialogResult.OK;
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Enter first name!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Enter last name!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Enter age!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Enter phone number!");
                    return;
                }
                string fn = textBox1.Text;
                string ln = textBox2.Text;
                int age = int.Parse(textBox3.Text);
                string pn = textBox4.Text;
                string email = textBox5.Text;
                if (label8.Visible == false)
                {
                    User user = new User
                    {
                        Username = username,
                        Password = password,
                        Role = Data.Enums.RoleType.Client
                    };
                    Client client = new Client
                    {
                        FirstName = fn,
                        LastName = ln,
                        Age = age,
                        Email = email,
                        PhoneNumber = pn,
                        Username = username
                    };

                    ClientController clientController = new ClientController();
                    await clientController.AddClient(client, user);

                    DialogResult = DialogResult.OK;
                    return;
                }
                else if(label9.Visible == false)
                {
                    if (string.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Choose a specialty!");
                        return;
                    }

                    User user = new User
                    {
                        Username = username,
                        Password = password,
                        Role = Data.Enums.RoleType.Employee
                    };
                    SpecialtyType type = SpecialtyType.MakeupArtist;

                    if (comboBox1.SelectedItem == "Makeup artist")
                        type = SpecialtyType.MakeupArtist;
                    else if (comboBox1.SelectedItem == "Hair stylist")
                        type = SpecialtyType.HairStylist;
                    else if (comboBox1.SelectedItem == "Nail tech")
                        type = SpecialtyType.NailTech;

                    Employee employee = new Employee
                    {
                        FirstName = fn,
                        LastName = ln,
                        Age = age,
                        Email = email,
                        PhoneNumber = pn,
                        Username = username,
                        Specialty = type
                    };

                    EmployeeController employeeController = new EmployeeController();
                    await employeeController.AddEmployee(employee, user);
                    DialogResult = DialogResult.OK;
                    return;
                }
                else
                {
                    if(string.IsNullOrWhiteSpace(textBox8.Text))
                    {
                        MessageBox.Show("Enter id!");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Choose a specialty!");
                        return;
                    }
                    SpecialtyType type = SpecialtyType.MakeupArtist;

                    if (comboBox1.SelectedItem == "Makeup artist")
                        type = SpecialtyType.MakeupArtist;
                    else if (comboBox1.SelectedItem == "Hair stylist")
                        type = SpecialtyType.HairStylist;
                    else if (comboBox1.SelectedItem == "Nail tech")
                        type = SpecialtyType.NailTech;
                    int id = int.Parse(textBox8.Text);
                    Employee employee = new Employee
                    {
                        Id = id,
                        FirstName = fn,
                        LastName = ln,
                        Age = age,
                        Email = email,
                        PhoneNumber = pn,
                        Username = username,
                        Specialty = type
                    };

                    EmployeeController employeeController = new EmployeeController();
                    await employeeController.UpdateEmployee(employee, password);
                    DialogResult = DialogResult.OK;
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
