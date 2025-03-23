
using FelineBakery.WinformApp.Models;
using FelineBakery.WinformApp.Views;
using System.Diagnostics;

namespace FelineBakery.WinformApp
{
    public partial class Form1 : Form
    {
        Bread Bread = new Bread();
        Cats Cats = new Cats();
        Stopwatch stopwatch = new Stopwatch();
        private StreetForm streetForm;
        private ShopForm shopForm;
        private KitchenForm kitchenForm;
        public Form1()
        {
            InitializeComponent();
            stopwatch.Start(); // Start the stopwatch
            //For some God know why reason it only works when I put it here
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameTimer.Start(); // Initialize the timer 
        }
        private void gameTimer_Tick_1(object sender, EventArgs e)//Every 1000ms this event will trigger
        {
            UpdateTimer();
            textBoxTotalBread.Text = Bread.BreadQuantity.ToString("F0");
            textBoxBreadPerClick.Text = Bread.BreadPerClick.ToString("F2");
            textBoxCatsAdopted.Text = Cats.CatQuanity.ToString();
            textBoxBreadPerSecond.Text = Cats.BreadPerSecond.ToString("F2");
            Bread.BreadQuantity += Cats.BreadPerSecond; // Bread per second
        }

        private void UpdateTimer()
        {
            textBoxTimer.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bread.BreadQuantity++;//Bread per click
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStreets_Click(object sender, EventArgs e)
        {
            if (streetForm == null || streetForm.IsDisposed) // Check if the form is already open
            {
                streetForm = new StreetForm();
                streetForm.Show();
            }
            else
            {
                streetForm.BringToFront(); // Bring the existing form to the front
            }
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            if (shopForm == null || shopForm.IsDisposed)
            {
                shopForm = new ShopForm();
                shopForm.Show();
            }
            else
            {
                shopForm.BringToFront();
            }
        }

        private void buttonKitchen_Click(object sender, EventArgs e)
        {
            if (kitchenForm == null || kitchenForm.IsDisposed)
            {
                kitchenForm = new KitchenForm();
                kitchenForm.Show();
            }
            else
            {
                kitchenForm.BringToFront();
            }
        }
    }
}
