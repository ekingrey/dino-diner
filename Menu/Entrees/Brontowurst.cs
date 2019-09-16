/*Brontowurst.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private bool bun = true, peppers = true, onions = true;
        /// <summary>
        /// holds the price of the menue item
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// holds the calories of the menue item
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// a list of all the ingredients of the menue item
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// takes the bun off
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// takes the peppers off
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// takes the onions off
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
