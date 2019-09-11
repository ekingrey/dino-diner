///Name: Ethan Kingrey
///VelociWrap.cs
/// Description: this class is used to order the VelociWrap. it allows the user to remove ingredients
/// and also holds the information about its price, calories, and ingredients.

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool dressing = true, lettuce = true, cheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// takes the dressing off the wrap
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        /// <summary>
        /// takes the lettuce off the wrap
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// takes the cheese off the wrap
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
