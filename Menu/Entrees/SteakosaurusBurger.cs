///Name: Ethan Kingrey
///SteakosaurusBurger.cs
/// Description: this class is used to order the Steakosaurus burger. it allows the user to remove ingredients
/// and also holds the information about its price, calories, and ingredients.

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        private bool bun = true, pickle = true, ketchup = true, mustard = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// takes the bun off the burger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// takes pickles off the burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// takes ketchup off the burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// takes mustard off the burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
