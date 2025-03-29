using FelineBakery.WinformApp.Models;

namespace FelineBakery.WinformApp.Views
{
    public partial class StreetForm : Form
    {
        Bread Bread = new Bread();
        Cats Cats = new Cats();
        Form1 form1 = new Form1();  
        public StreetForm(Bread bread, Cats cats)
        {
            InitializeComponent();
            UpdateForm();
            Bread = bread;
            Cats = cats;
        }
        private void UpdateForm()
        {
            textBoxAdoptionFee.Text = Cats.AdoptionFee.ToString();
        }

        private void buttonAdopt_Click(object sender, EventArgs e)
        {
            if (Bread.BreadQuantity >= Cats.AdoptionFee)
            {
                MessageBox.Show("You have adopted a cat!");
                Cats.CatQuanity++;
                Bread.BreadQuantity -= Cats.AdoptionFee;
                Cats.BreadPerSecond += 0.1f;
                Cats.AdoptionFee += (25 * Cats.CatQuanity);
            }
            else
            {
                MessageBox.Show("You don't have enough bread to adopt a cat!");
            }
            UpdateForm();
        }
    }


}
