namespace FelineBakery.WinformApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxTotalBread = new TextBox();
            textBoxBreadPerClick = new TextBox();
            textBoxBreadPerSecond = new TextBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            textBoxTimer = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxCatsAdopted = new TextBox();
            buttonKitchen = new Button();
            buttonShop = new Button();
            buttonStreets = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bread_PNG_Clip_Art_2218;
            pictureBox1.Location = new Point(38, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 230);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Total bread";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 261);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Bread per click";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 291);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 3;
            label3.Text = "Bread per second";
            // 
            // textBoxTotalBread
            // 
            textBoxTotalBread.Location = new Point(135, 227);
            textBoxTotalBread.Name = "textBoxTotalBread";
            textBoxTotalBread.Size = new Size(100, 23);
            textBoxTotalBread.TabIndex = 4;
            // 
            // textBoxBreadPerClick
            // 
            textBoxBreadPerClick.Location = new Point(135, 258);
            textBoxBreadPerClick.Name = "textBoxBreadPerClick";
            textBoxBreadPerClick.Size = new Size(100, 23);
            textBoxBreadPerClick.TabIndex = 5;
            // 
            // textBoxBreadPerSecond
            // 
            textBoxBreadPerSecond.Location = new Point(135, 288);
            textBoxBreadPerSecond.Name = "textBoxBreadPerSecond";
            textBoxBreadPerSecond.Size = new Size(100, 23);
            textBoxBreadPerSecond.TabIndex = 6;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Tick += gameTimer_Tick_1;
            // 
            // textBoxTimer
            // 
            textBoxTimer.Location = new Point(135, 198);
            textBoxTimer.Name = "textBoxTimer";
            textBoxTimer.Size = new Size(100, 23);
            textBoxTimer.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 201);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 8;
            label4.Text = "Elapsed time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 320);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 9;
            label5.Text = "Cats adopted";
            // 
            // textBoxCatsAdopted
            // 
            textBoxCatsAdopted.Location = new Point(135, 320);
            textBoxCatsAdopted.Name = "textBoxCatsAdopted";
            textBoxCatsAdopted.Size = new Size(100, 23);
            textBoxCatsAdopted.TabIndex = 10;
            // 
            // buttonKitchen
            // 
            buttonKitchen.Location = new Point(285, 17);
            buttonKitchen.Name = "buttonKitchen";
            buttonKitchen.Size = new Size(209, 67);
            buttonKitchen.TabIndex = 11;
            buttonKitchen.Text = "Kitchen";
            buttonKitchen.UseVisualStyleBackColor = true;
            buttonKitchen.Click += buttonKitchen_Click;
            // 
            // buttonShop
            // 
            buttonShop.Location = new Point(285, 90);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(209, 67);
            buttonShop.TabIndex = 12;
            buttonShop.Text = "Shop";
            buttonShop.UseVisualStyleBackColor = true;
            buttonShop.Click += buttonShop_Click;
            // 
            // buttonStreets
            // 
            buttonStreets.Location = new Point(285, 163);
            buttonStreets.Name = "buttonStreets";
            buttonStreets.Size = new Size(209, 67);
            buttonStreets.TabIndex = 13;
            buttonStreets.Text = "Streets";
            buttonStreets.UseVisualStyleBackColor = true;
            buttonStreets.Click += buttonStreets_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 360);
            Controls.Add(buttonStreets);
            Controls.Add(buttonShop);
            Controls.Add(buttonKitchen);
            Controls.Add(textBoxCatsAdopted);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxTimer);
            Controls.Add(textBoxBreadPerSecond);
            Controls.Add(textBoxBreadPerClick);
            Controls.Add(textBoxTotalBread);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTotalBread;
        private TextBox textBoxBreadPerClick;
        private TextBox textBoxBreadPerSecond;
        private System.Windows.Forms.Timer gameTimer;
        private TextBox textBoxTimer;
        private Label label4;
        private Label label5;
        private TextBox textBoxCatsAdopted;
        private Button buttonKitchen;
        private Button buttonShop;
        private Button buttonStreets;
    }
}
