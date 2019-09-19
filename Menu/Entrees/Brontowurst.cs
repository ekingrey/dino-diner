/*Brontowurst.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst : Entrees
    {
        //private bool bun = true, peppers = true, onions = true;
        /// <summary>
        /// gets or sets the price
        /// </summary>
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
        //        List<string> ingredients = new List<string>() { "Brautwurst"};
        //        if (bun) ingredients.Add("Whole Wheat Bun");
        //        if (peppers) ingredients.Add("Peppers");
        //        if (onions) ingredients.Add("Onion");
        //        return ingredients;
        //    }
        //}
        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
           ingredients.Add("Onion");
            
        }
        /// <summary>
        /// takes the bun off
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }
        /// <summary>
        /// takes the peppers off
        /// </summary>
        public void HoldPeppers()
        {
            ingredients.Remove("Peppers");
        }
        /// <summary>
        /// takes the onions off
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }
    }
}
