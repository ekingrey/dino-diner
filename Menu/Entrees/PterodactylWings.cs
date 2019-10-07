/*PterodactyWings.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{ 
    public class PterodactylWings : Entrees
    {
        
        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;

            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");

        }

    public override string ToString()
    {
        return "Pterodactyl Wings";
    }


    }
}
