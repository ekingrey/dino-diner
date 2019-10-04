/*DinoNuggets.cs
 * Author: Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entrees
    {

       
        private uint nuggetCount = 6;

        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public DinoNuggets()
        {
            
            this.Price = 4.25;
            this.Calories = 59 * nuggetCount;

            for (int i = 0; i < 6; i++)
            {
                ingredients.Add("Chicken Nugget");
            }
        }

        /// <summary>
        /// adds one nugget the the custumers order
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            Price += .25;
            Calories += Calories;
            ingredients.Add("Chicken Nugget");
        }

        
    }
}
