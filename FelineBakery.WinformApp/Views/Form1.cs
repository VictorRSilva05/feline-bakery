
using FelineBakery.WinformApp.Models;
using FelineBakery.WinformApp.Views;
using System.Diagnostics;

namespace FelineBakery.WinformApp
{
    public partial class Form1 : Form
    {
        Bread Bread1 = new Bread();
        Cats Cat1 = new Cats();
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
            textBoxTotalBread.Text = Bread1.BreadQuantity.ToString("F0");
            textBoxBreadPerClick.Text = Bread1.BreadPerClick.ToString("F2");
            textBoxCatsAdopted.Text = Cat1.CatQuanity.ToString();
            textBoxBreadPerSecond.Text = Cat1.BreadPerSecond.ToString("F2");
            Bread1.BreadQuantity += Cat1.BreadPerSecond; // Bread per second
        }

        private void UpdateTimer()
        {
            textBoxTimer.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bread1.BreadQuantity++;//Bread per click
        }

        private void buttonStreets_Click(object sender, EventArgs e)
        {
            if (streetForm == null || streetForm.IsDisposed)
            {
                streetForm = new StreetForm(Bread1, Cat1); // Need to pass the references of Bread and Cat to the StreetForm
                streetForm.Show();
            }
            else
            {
                streetForm.BringToFront();
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
