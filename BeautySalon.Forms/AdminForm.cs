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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register("employee");
            DialogResult res = register.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Added employee!");
            }
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register("admin");
            DialogResult res = register.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Added admin!");
            }
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowForm form = new ShowForm("Employees", "AdminForm");
            DialogResult res = form.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowForm form = new ShowForm("Clients", "AdminForm");
            DialogResult res = form.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowForm form = new ShowForm("Services", "AdminForm");
            DialogResult res = form.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceForm form = new ServiceForm("Add");
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Added service!");
            }
            this.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceForm form = new ServiceForm("Update");
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Updated service!");
            }
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowForm form = new ShowForm("Appointments", "AdminForm");
            DialogResult res = form.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveForm form = new RemoveForm("Employee");
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Removed employee!");
            }
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveForm form = new RemoveForm("Service");
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Removed service!");
            }
            this.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register form = new Register("UpdateEmployee");
            DialogResult res = form.ShowDialog();
            if(res == DialogResult.OK)
            {
                MessageBox.Show("Updated employee!");
            }
            this.Show();
        }
    }
}
