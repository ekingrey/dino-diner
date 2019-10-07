/*TRexKingBurger.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class TRexKingBurger :Entrees 
    {
       

        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;

            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Mayo");
            ingredients.Add("Onion");
            ingredients.Add("Lettuce");
            ingredients.Add("Tomato");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            
        }
        /// <summary>
        /// takes the bun off the burger
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
            
        }
        /// <summary>
        /// takes the pickles off the burger
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
        /// <summary>
        /// takes mayo off the burger
        /// </summary>
        public void HoldMayo()
        {
            
            ingredients.Remove("Mayo");
            
        }
        /// <summary>
        /// takes tomatos off the burger
        /// </summary>
        public void HoldTomato()
        {
           
            ingredients.Remove("Tomato");
        }
        /// <summary>
        /// takes the lettuce off the burger
        /// </summary>
        public void HoldLettuce()
        {
           
            ingredients.Remove("Lettuce");
            
        }
        /// <summary>
        /// takes teh onion off the burger
        /// </summary>
        public void HoldOnion()
        {
           
            ingredients.Remove("Onion");
            
        }

        public override string ToString()
        {
            return "T-Rex King Burger";
        }


    }
}
