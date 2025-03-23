namespace FelineBakery.WinformApp.Views
{
    partial class StreetForm
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
            pictureBoxCatImage = new PictureBox();
            labelCatName = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelDescription = new Label();
            buttonAdopt = new Button();
            labelPrice = new Label();
            textBoxAdoptionFee = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCatImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCatImage
            // 
            pictureBoxCatImage.Location = new Point(251, 46);
            pictureBoxCatImage.Name = "pictureBoxCatImage";
            pictureBoxCatImage.Size = new Size(257, 278);
            pictureBoxCatImage.TabIndex = 0;
            pictureBoxCatImage.TabStop = false;
            // 
            // labelCatName
            // 
            labelCatName.AutoSize = true;
            labelCatName.Location = new Point(12, 49);
            labelCatName.Name = "labelCatName";
            labelCatName.Size = new Size(42, 15);
            labelCatName.TabIndex = 1;
            labelCatName.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Race:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 109);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(70, 15);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "Description:";
            // 
            // buttonAdopt
            // 
            buttonAdopt.Location = new Point(251, 342);
            buttonAdopt.Name = "buttonAdopt";
            buttonAdopt.Size = new Size(209, 67);
            buttonAdopt.TabIndex = 12;
            buttonAdopt.Text = "Adopt";
            buttonAdopt.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(16, 342);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 13;
            labelPrice.Text = "Price";
            // 
            // textBoxAdoptionFee
            // 
            textBoxAdoptionFee.Location = new Point(16, 386);
            textBoxAdoptionFee.Name = "textBoxAdoptionFee";
            textBoxAdoptionFee.Size = new Size(100, 23);
            textBoxAdoptionFee.TabIndex = 14;
            // 
            // StreetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(textBoxAdoptionFee);
            Controls.Add(labelPrice);
            Controls.Add(buttonAdopt);
            Controls.Add(labelDescription);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(labelCatName);
            Controls.Add(pictureBoxCatImage);
            Name = "StreetForm";
            Text = "StreetForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCatImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCatImage;
        private Label labelCatName;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelDescription;
        private Button buttonAdopt;
        private Label labelPrice;
        private TextBox textBoxAdoptionFee;
    }
}