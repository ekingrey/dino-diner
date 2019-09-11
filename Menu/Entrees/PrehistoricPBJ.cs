///Name: Ethan Kingrey
///PrehistoricPBJ.cs
/// Description: this class is used to order the Prehistoric PBJ. it allows the user to remove ingredients
/// and also holds the information about its price, calories, and ingredients.
/// 
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// takes peanut butter off the sandwich
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// takes jelly off the sandwich
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
