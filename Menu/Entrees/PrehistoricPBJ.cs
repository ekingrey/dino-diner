/*PrehistoricPBJ.cs
 * Author: Ethan Kingrey
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entrees
    {
        //private bool peanutButter = true;
        //private bool jelly = true;
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
        //        List<string> ingredients = new List<string>() { "Bread" };
        //        if (peanutButter) ingredients.Add("Peanut Butter");
        //        if (jelly) ingredients.Add("Jelly");
        //        return ingredients;
        //    }
        //}

        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;

            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
            ingredients.Add("Bread");
        }

        /// <summary>
        /// takes peanut butter off the sandwich
        /// </summary>
        public void HoldPeanutButter()
        {
            ingredients.Remove("Peanut Butter");
            
        }

        /// <summary>
        /// takes jelly off the sandwich
        /// </summary>
        public void HoldJelly()
        {
            
            ingredients.Remove("Jelly");
        }
    }
}
