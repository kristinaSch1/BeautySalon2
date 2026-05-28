namespace BeautySalon.Forms
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(847, 673);
            button1.Name = "button1";
            button1.Size = new Size(107, 49);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1007, 673);
            button2.Name = "button2";
            button2.Size = new Size(117, 49);
            button2.TabIndex = 1;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1183, 749);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}