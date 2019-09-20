/*Triceritots.cs
 * Author: Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        private Size size;
        /// <summary>
        /// gets or sets the size of the side
        /// </summary>
        public override Size Size
        {
            
            set
            {
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case (Size.Medium):
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case (Size.Large):
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
            get { return size; }
        }


        /// <summary>
        /// sets the price, calories, and adds the ingredianets to a list
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            ingredients.Add("Potato");
            ingredients.Add("Breading");
            ingredients.Add("Vegetable Oil");
        }

    }
}
