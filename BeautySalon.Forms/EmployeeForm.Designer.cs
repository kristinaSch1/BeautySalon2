namespace BeautySalon.Forms
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            button6 = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(189, 380);
            button1.Name = "button1";
            button1.Size = new Size(143, 46);
            button1.TabIndex = 0;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.Location = new Point(1009, 622);
            button2.Name = "button2";
            button2.Size = new Size(102, 42);
            button2.TabIndex = 1;
            button2.Text = "exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightPink;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(168, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Mongolian Baiti", 12F);
            radioButton2.ForeColor = Color.DarkRed;
            radioButton2.Location = new Point(21, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(110, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Available";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Mongolian Baiti", 12F);
            radioButton1.ForeColor = Color.DarkRed;
            radioButton1.Location = new Point(21, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Booked";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(81, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 34);
            dateTimePicker1.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleVioletRed;
            button6.Font = new Font("Mongolian Baiti", 12F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(189, 462);
            button6.Name = "button6";
            button6.Size = new Size(142, 50);
            button6.TabIndex = 7;
            button6.Text = "Cancel app";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(607, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(393, 480);
            listBox1.TabIndex = 8;
            listBox1.Visible = false;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1123, 676);
            Controls.Add(listBox1);
            Controls.Add(button6);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private Button button6;
        private ListBox listBox1;
    }
}