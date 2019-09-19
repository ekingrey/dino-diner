/*TRexKingBurger.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger :Entrees 
    {
        //private bool bun = true, pickle = true, ketchup = true, mustard = true, lettuce = true, tomato = true, onion = true, mayo = true;
        /// <summary>
        /// gets or sets the price
        /// </summary>
        //public double Price { get; set; }
        /// <summary>
        /// gets or sets the Calories
        /// </summary>
        //public uint Calories { get; set; }
        /// <summary>
        /// a list of all the ingredients of the menue item
        /// </summary>
        //public List<string> Ingredients
        //{
        //    get
        //    {
        //        List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
        //        if (bun) ingredients.Add("Whole Wheat Bun");
        //        if (pickle) ingredients.Add("Pickle");
        //        if (ketchup) ingredients.Add("Ketchup");
        //        if (mustard) ingredients.Add("Mustard");
        //        if (mayo) ingredients.Add("Mayo");
        //        if (onion) ingredients.Add("Onion");
        //        if (lettuce) ingredients.Add("Lettuce");
        //        if (tomato) ingredients.Add("Tomato");


        //        return ingredients;
        //    }
        //}

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
    }
}
