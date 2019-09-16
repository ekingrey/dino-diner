﻿/*PterodactyWings.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        /// <summary>
        /// gets or sets the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// gets or sets the Calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// a list of all the ingredients of the menue item
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                
                return ingredients;
            }
        }
        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        
    }
}
