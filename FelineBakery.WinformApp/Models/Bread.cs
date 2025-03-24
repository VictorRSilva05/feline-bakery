using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineBakery.WinformApp.Models
{
    public class Bread
    {
        public float BreadQuantity { get; set; }
        public float BreadPerClick { get; set; }

        public Bread(float breadQuantity)
        {
            BreadQuantity = breadQuantity;
        }

        public Bread()
        {
            BreadQuantity = 0;
            BreadPerClick = 1;
        }
    }
}
