namespace BeautySalon.Forms
{
    partial class Booking
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            comboBox4 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(238, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedValueChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(238, 181);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(293, 33);
            comboBox2.TabIndex = 1;
            comboBox2.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 11F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(238, 220);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(293, 33);
            comboBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Font = new Font("Mongolian Baiti", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(253, 371);
            button1.Name = "button1";
            button1.Size = new Size(204, 66);
            button1.TabIndex = 3;
            button1.Text = "Show available";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 14F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(736, 123);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(230, 39);
            comboBox4.TabIndex = 4;
            comboBox4.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 16F);
            label1.Location = new Point(96, 146);
            label1.Name = "label1";
            label1.Size = new Size(122, 29);
            label1.TabIndex = 5;
            label1.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 16F);
            label2.Location = new Point(86, 189);
            label2.Name = "label2";
            label2.Size = new Size(132, 29);
            label2.TabIndex = 6;
            label2.Text = "Employee:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 16F);
            label3.Location = new Point(115, 224);
            label3.Name = "label3";
            label3.Size = new Size(103, 29);
            label3.TabIndex = 7;
            label3.Text = "Service:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Location = new Point(238, 260);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 32);
            dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 16F);
            label4.Location = new Point(145, 263);
            label4.Name = "label4";
            label4.Size = new Size(73, 29);
            label4.TabIndex = 9;
            label4.Text = "Date:";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.Font = new Font("Mongolian Baiti", 15F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(789, 285);
            button2.Name = "button2";
            button2.Size = new Size(142, 48);
            button2.TabIndex = 10;
            button2.Text = "Book";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Location = new Point(1030, 661);
            button3.Name = "button3";
            button3.Size = new Size(97, 33);
            button3.TabIndex = 11;
            button3.Text = "exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1130, 695);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox4);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Booking";
            Text = "Booking";
            Load += Booking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private ComboBox comboBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button2;
        private Button button3;
    }
}