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
        public ShopForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("You got some boxes from the supermarket so the cats can feel safe and relax" +
                "\nBread per second: Price:", label5);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cats don't like to eat the same boring dry food everyday, also, wet food" +
                "is good for their kidneys!\nBread per second: Price:", label6);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cats love sunlight, so now they feel warm and cozy" +
                "\nBread per second: Price:", label7);
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Catnip is a plant that makes cats go crazy, they love it!" +
                "\nBread per second: Price:", label9);
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cats prefer to drink water from a fountain, it's more fun!" +
                "\nBread per second: Price:", label8);
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
    }
}
