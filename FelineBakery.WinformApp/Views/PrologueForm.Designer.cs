namespace FelineBakery.WinformApp.Views
{
    partial class PrologueForm
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 310);
            label1.Name = "label1";
            label1.Size = new Size(486, 30);
            label1.TabIndex = 0;
            label1.Text = "After dropping out of college, you decide to open a small bakery, but you're all by yourself.\r\nYou look through the window, you see a dirty stray cat, if you only had a way to help it...\r\n";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._445412913_875087544652048_801590817760410871_n;
            pictureBox1.Location = new Point(224, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(346, 377);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 2;
            button1.Text = "Start your adventure!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PrologueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "PrologueForm";
            Text = "Start your adventure!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}