namespace BeautySalon.Forms
{
    partial class ClientForm
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            listBox1 = new ListBox();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Font = new Font("Mongolian Baiti", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(95, 183);
            button1.Name = "button1";
            button1.Size = new Size(142, 50);
            button1.TabIndex = 0;
            button1.Text = "See employees";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Location = new Point(938, 561);
            button2.Name = "button2";
            button2.Size = new Size(118, 47);
            button2.TabIndex = 1;
            button2.Text = "exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.Font = new Font("Mongolian Baiti", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(95, 276);
            button3.Name = "button3";
            button3.Size = new Size(142, 50);
            button3.TabIndex = 2;
            button3.Text = "See services";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleVioletRed;
            button4.Font = new Font("Mongolian Baiti", 12F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(95, 356);
            button4.Name = "button4";
            button4.Size = new Size(142, 50);
            button4.TabIndex = 3;
            button4.Text = "Show my apps";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleVioletRed;
            button5.Font = new Font("Mongolian Baiti", 12F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(273, 183);
            button5.Name = "button5";
            button5.Size = new Size(142, 50);
            button5.TabIndex = 4;
            button5.Text = "Book app";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleVioletRed;
            button6.Font = new Font("Mongolian Baiti", 12F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(273, 276);
            button6.Name = "button6";
            button6.Size = new Size(142, 50);
            button6.TabIndex = 6;
            button6.Text = "Cancel app";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(547, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(410, 452);
            listBox1.TabIndex = 7;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.BackColor = Color.PaleVioletRed;
            button7.Font = new Font("Mongolian Baiti", 12F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(273, 356);
            button7.Name = "button7";
            button7.Size = new Size(142, 50);
            button7.TabIndex = 8;
            button7.Text = "Get total price";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_02_at_09_01_32_Create_rawpixel;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1068, 620);
            Controls.Add(button7);
            Controls.Add(listBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "ClientForm";
            Text = "ClientForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ListBox listBox1;
        private Button button7;
    }
}