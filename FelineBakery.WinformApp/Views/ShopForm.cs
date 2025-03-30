using FelineBakery.WinformApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelineBakery.WinformApp.Views
{
    public partial class ShopForm : Form
    {
        Bread bread1 = new Bread();
        Cats cats1 = new Cats();

        public ShopForm(Bread bread, Cats cats)
        {
            InitializeComponent();
            bread1 = bread;
            cats1 = cats;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("You got some boxes from the supermarket so the cats can feel safe and relax" +
                "\nBread per second:+0.05 Price:50", label5);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cats don't like to eat the same boring dry food everyday, also, wet food" +
                "is good for their kidneys!\nBread per second:+0.07 Price:125", label6);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cats love sunlight, so now they feel warm and cozy" +
                "\nBread per second:+0.12 Price:500", label7);
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Catnip is a plant that makes cats go crazy, they love it!" +
                "\nBread per second:+0.17 Price:850", label9);
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cats prefer to drink water from a fountain, it's more fun!" +
                "\nBread per second:+0.22 Price:1200", label8);
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("You start going to the gym to help you knead the dough faster" +
                "\nBread per second: Price:", label13);
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Besides the gym, you also train your forearms with a rice bucket" +
                "\nBread per second: Price:", label14);
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("You don't care about the side effects, you need to knead faster!" +
                "\nBread per second: Price:", label15);
        }

        private void buttonBoxes_Click(object sender, EventArgs e)
        {
            if (bread1.BreadQuantity >= 50)
            {
                cats1.BreadPerSecond += 0.05f;
                bread1.BreadQuantity -= 50;
                buttonBoxes.Enabled = false;
                MessageBox.Show("You bought some boxes from the supermarket so the cats can feel safe and relax");
            }
            else
            {
                MessageBox.Show("You don't have enough bread to buy this item!");
            }
        }

        private void buttonWetFood_Click(object sender, EventArgs e)
        {
            if (bread1.BreadQuantity >= 125)
            {
                cats1.BreadPerSecond += 0.07f;
                bread1.BreadQuantity -= 125;
                buttonBoxes.Enabled = false;
                MessageBox.Show("You bought some wet food for the cats, they love it!");
            }
            else
            {
                MessageBox.Show("You don't have enough bread to buy this item!");
            }
        }

        private void buttonWindows_Click(object sender, EventArgs e)
        {
            if (bread1.BreadQuantity >= 500)
            {
                cats1.BreadPerSecond += 0.12f;
                bread1.BreadQuantity -= 500;
                buttonWindows.Enabled = false;
                MessageBox.Show("You bought some windows so the cats can feel warm and cozy");
            }
            else
            {
                MessageBox.Show("You don't have enough bread to buy this item!");
            }
        }

        private void buttonCatnip_Click(object sender, EventArgs e)
        {
            if (bread1.BreadQuantity >= 850)
            {
                cats1.BreadPerSecond += 0.17f;
                bread1.BreadQuantity -= 850;
                buttonCatnip.Enabled = false;
                MessageBox.Show("You bought some catnip, the cats love it!");
            }
            else
            {
                MessageBox.Show("You don't have enough bread to buy this item!");
            }
        }

        private void buttonRunningWater_Click(object sender, EventArgs e)
        {
            if (bread1.BreadQuantity >= 1200)
            {
                cats1.BreadPerSecond += 0.22f;
                bread1.BreadQuantity -= 1200;
                buttonRunningWater.Enabled = false;
                MessageBox.Show("You bought a running water fountain for the cats, they love it!");
            }
            else
            {
                MessageBox.Show("You don't have enough bread to buy this item!");
            }
        }
    }
}
