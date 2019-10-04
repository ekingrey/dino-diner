/* Sodasaurous.cs
 * Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// holds the flavor of the drink
        /// </summary>
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// holds the size of the drink
        /// </summary>
        private Size size;
        public override Size Size {
            get { return size; }
            set {
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case (Size.Medium):
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case (Size.Large):
                        Price = 2.50;
                        Calories = 208;
                        break;
                }

            }
        }
        

        public Sodasaurus(){
            Price = 1.5;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

    }
}
