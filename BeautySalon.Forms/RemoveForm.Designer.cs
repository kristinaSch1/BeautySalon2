namespace BeautySalon.Forms
{
    partial class RemoveForm
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
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Font = new Font("Mongolian Baiti", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(164, 192);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 0;
            button1.Text = "Choose";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(481, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(382, 480);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.Font = new Font("Mongolian Baiti", 12F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(164, 287);
            button2.Name = "button2";
            button2.Size = new Size(117, 48);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Location = new Point(891, 556);
            button3.Name = "button3";
            button3.Size = new Size(95, 33);
            button3.TabIndex = 3;
            button3.Text = "exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // RemoveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(989, 592);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "RemoveForm";
            Text = "RemoveForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
    }
}