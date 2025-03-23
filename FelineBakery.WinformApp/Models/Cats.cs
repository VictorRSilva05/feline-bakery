namespace FelineBakery.WinformApp.Models
{
    public class Cats
    {
        public int CatQuanity { get; set; }
        public float BreadPerSecond { get; set; }
        public float AdoptionFee { get; set; }

        Bread Bread = new Bread();
        public Cats()
        {
            CatQuanity = 0;
            BreadPerSecond = 0.0f;
            AdoptionFee = 25;
        }
        public void BuyCat()
        {
            if (Bread.BreadQuantity >= AdoptionFee)
            {
                CatQuanity++;
                Bread.BreadQuantity -= AdoptionFee;
                BreadPerSecond += 0.1f;
                AdoptionFee += (25 * CatQuanity);
            }
        }
    }
}
