
using FelineBakery.WinformApp.Models;
using System.Diagnostics;

namespace FelineBakery.WinformApp
{
    public partial class Form1 : Form
    {
        Bread Bread = new Bread();
        Cats Cats = new Cats();
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {
            gameTimer.Start(); // Initialize the timer 
            stopwatch.Start(); // Start the stopwatch
        }
        private void gameTimer_Tick_1(object sender, EventArgs e)//Every 1000ms this event will trigger
        {
            UpdateTimer();
            textBoxTotalBread.Text = Bread.BreadQuantity.ToString();
            textBoxBreadPerClick.Text = Bread.BreadPerClick.ToString();
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

    }
}
