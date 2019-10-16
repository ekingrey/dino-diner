/*Brontowurst.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entrees, IOrderItem
    {
        

        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
           ingredients.Add("Onion");
            
        }
        /// <summary>
        /// takes the bun off
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }
        /// <summary>
        /// takes the peppers off
        /// </summary>
        public void HoldPeppers()
        {
            ingredients.Remove("Peppers");
        }
        /// <summary>
        /// takes the onions off
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }

        public override string ToString()
        {
            return "Brontowurst";
        }

        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!ingredients.Contains("Whole Wheat Bun"))
                {
                    special.Add("Hold Whole Wheat Bun");
                }

                if (!ingredients.Contains("Peppers"))
                {
                    special.Add("Hold Peppers");
                }
                if (!ingredients.Contains("Onion"))
                {
                    special.Add("Hold Onion");
                }
                return special.ToArray();
            }
        }
    }
}
