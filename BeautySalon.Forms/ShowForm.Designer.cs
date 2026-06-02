namespace BeautySalon.Forms
{
    partial class ShowForm
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(366, 34);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(455, 503);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(522, 570);
            button1.Name = "button1";
            button1.Size = new Size(119, 52);
            button1.TabIndex = 1;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Location = new Point(1038, 618);
            button2.Name = "button2";
            button2.Size = new Size(94, 35);
            button2.TabIndex = 2;
            button2.Text = "exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            BackgroundImage = Properties.Resources.Screenshot_2026_06_02_at_09_01_32_Create_rawpixel;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1144, 665);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            DoubleBuffered = true;
            Name = "ShowForm";
            Text = "ShowForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}