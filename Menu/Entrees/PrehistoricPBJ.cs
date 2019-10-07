/*PrehistoricPBJ.cs
 * Author: Ethan Kingrey
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entrees
    {
        

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
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        
    }
}
