/*Velociwrap.cs
 * Author: Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entrees
    {
        //private bool dressing = true, lettuce = true, cheese = true;
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
        //        List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
        //        if (dressing) ingredients.Add("Ceasar Dressing");
        //        if (lettuce) ingredients.Add("Romaine Lettuce");
        //        if (cheese) ingredients.Add("Parmesan Cheese");
        //        return ingredients;
        //    }
        //}

        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
           
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }
        /// <summary>
        /// takes the dressing off the wrap
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
           
        }
        /// <summary>
        /// takes the lettuce off the wrap
        /// </summary>
        public void HoldLettuce()
        {
           
            ingredients.Remove("Romaine Lettuce");
            
        }
        /// <summary>
        /// takes the cheese off the wrap
        /// </summary>
        public void HoldCheese()
        {
            
            ingredients.Remove("Parmesan Cheese");
        }
    }
}
