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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }
        public ServiceForm(string action)
        {
            InitializeComponent();
            if (action == "Update")
            {
                label1.Visible = true;
                textBox1.Visible = true;
                button1.Text = "Update";
            }
            else if (action == "Add")
            {
                button1.Text = "Add";
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && label1.Visible == true)
            {
                MessageBox.Show("Enter service id!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Enter service name!");
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Enter service price!");
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter service description!");
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Enter service duration!");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Choose service category!");
                return;
            }
            string name = textBox2.Text;
            decimal price = decimal.Parse(textBox3.Text);
            string description = textBox4.Text;
            int duration = int.Parse(textBox5.Text);
            CategoryType type = (CategoryType)comboBox1.SelectedItem;

            ServiceController controller = new ServiceController();
            try
            {
                if (label1.Visible == false)
                {
                    Service service = new Service
                    {
                        Name = name,
                        Price = price,
                        Description = description,
                        Duration = duration,
                        Category = type
                    };
                    await controller.AddService(service);
                }
                else
                {
                    Service service = new Service
                    {
                        Id = int.Parse(textBox1.Text),
                        Name = name,
                        Price = price,
                        Description = description,
                        Duration = duration,
                        Category = type
                    };
                    await controller.UpdateService(service);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(CategoryType));
            comboBox1.SelectedIndex = -1;   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
