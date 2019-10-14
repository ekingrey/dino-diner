/*Entrees.cs
 * Author: Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    public abstract class Entrees : IMenuItem
    {

        protected readonly List<string> ingredients = new List<string>();
        /// <summary> 
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients
        {
            get { return new List<string>(ingredients); }
        }

        
    }
}
