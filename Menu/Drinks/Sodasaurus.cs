using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus
    {
        private SodasaurusFlavor flavor;
       public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value; }
        }

        public double Price { get; set; } = 1.5;

        private Size size;
        public Size Size {
            get { return size; }
            set {
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        Price = 1.50;
                        break;
                    case (Size.Medium):
                        Price = 2.00;
                        break;
                    case (Size.Large):
                        Price = 2.50;
                        break;
                }
                
            }
        }
        public bool Ice { get; set; } = true;
    }
}
