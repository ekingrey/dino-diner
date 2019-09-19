/*SteakosaurousBurger.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entrees
    {
        //private bool bun = true, pickle = true, ketchup = true, mustard = true;
        ///// <summary>
        ///// gets or sets the price
        ///// </summary>
        //public double Price { get; set; }
        ///// <summary>
        ///// gets or sets the Calories
        ///// </summary>
        //public uint Calories { get; set; }
        ///// <summary>
        ///// a list of all the ingredients of the menue item
        ///// </summary>
        //public List<string> Ingredients
        //{
        //    get
        //    {
        //        List<string> ingredients = new List<string>() { "Steakburger Pattie" };
        //        if (bun) ingredients.Add("Whole Wheat Bun");
        //        if (pickle) ingredients.Add("Pickle");
        //        if (ketchup) ingredients.Add("Ketchup");
        //        if (mustard) ingredients.Add("Mustard");
        //        return ingredients;
        //    }
        //}
        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;

            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
        }

        /// <summary>
        /// takes the bun off the burger
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
            
        }
        /// <summary>
        /// takes pickles off the burger
        /// </summary>
        public void HoldPickle()
        {
            
            ingredients.Remove("Pickle");
            
        }
        /// <summary>
        /// takes ketchup off the burger
        /// </summary>
        public void HoldKetchup()
        {
            
            ingredients.Remove("Ketchup");
            
        }
        /// <summary>
        /// takes mustard off the burger
        /// </summary>
        public void HoldMustard()
        {
            
            ingredients.Remove("Mustard");
        }
    }
}
