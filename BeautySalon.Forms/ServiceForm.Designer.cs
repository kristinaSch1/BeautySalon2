namespace BeautySalon.Forms
{
    partial class ServiceForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 16F);
            label1.Location = new Point(239, 102);
            label1.Name = "label1";
            label1.Size = new Size(44, 29);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 16F);
            label2.Location = new Point(198, 145);
            label2.Name = "label2";
            label2.Size = new Size(85, 29);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 16F);
            label3.Location = new Point(206, 193);
            label3.Name = "label3";
            label3.Size = new Size(77, 29);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 16F);
            label4.Location = new Point(132, 240);
            label4.Name = "label4";
            label4.Size = new Size(151, 29);
            label4.TabIndex = 3;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 16F);
            label5.Location = new Point(163, 283);
            label5.Name = "label5";
            label5.Size = new Size(120, 29);
            label5.TabIndex = 4;
            label5.Text = "Duration:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 16F);
            label6.Location = new Point(161, 326);
            label6.Name = "label6";
            label6.Size = new Size(122, 29);
            label6.TabIndex = 5;
            label6.Text = "Category:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(320, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 32);
            textBox1.TabIndex = 6;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(320, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 32);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(320, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 32);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(320, 237);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 32);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F);
            textBox5.Location = new Point(320, 280);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(188, 32);
            textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(320, 322);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(296, 405);
            button1.Name = "button1";
            button1.Size = new Size(120, 47);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Location = new Point(999, 612);
            button3.Name = "button3";
            button3.Size = new Size(96, 36);
            button3.TabIndex = 14;
            button3.Text = "exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1097, 651);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ServiceForm";
            Text = "ServiceForm";
            Load += ServiceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Button button1;
        private Button button3;
    }
}