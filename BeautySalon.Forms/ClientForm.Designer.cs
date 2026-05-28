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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Font = new Font("Mongolian Baiti", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(183, 151);
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
            button2.BackColor = Color.LightPink;
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
            button3.Location = new Point(183, 244);
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
            button4.Location = new Point(183, 324);
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
            button5.Location = new Point(183, 410);
            button5.Name = "button5";
            button5.Size = new Size(142, 50);
            button5.TabIndex = 4;
            button5.Text = "Book app";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(515, 82);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(399, 444);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1068, 620);
            Controls.Add(richTextBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private RichTextBox richTextBox1;
    }
}