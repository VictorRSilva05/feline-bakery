
using FelineBakery.WinformApp.Models;

namespace FelineBakery.WinformApp
{
    public partial class Form1 : Form
    {
        Bread Bread = new Bread();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bread.BreadQuantity++;
            textBoxTotalBread.Text = Bread.BreadQuantity.ToString();
            textBoxBreadPerClick.Text = Bread.BreadPerClick.ToString();
        }
    }
}
