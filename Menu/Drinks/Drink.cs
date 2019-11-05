/* Drink.cs
 * Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;



namespace DinoDiner.Menu
{

    public abstract class Drink: IMenuItem, IOrderItem
    {
        
        protected readonly List<string> ingredients = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary> 
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

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

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        public bool Ice { get; set; } = true;

        /// <summary>
        /// holds the ice
        /// </summary>
        public virtual void HoldIce()
        {
            Ice = false;
            
        }

        /// <summary>
        /// gets the description
        /// </summary>
        public virtual string Description { get; }

        /// <summary>
        /// gets the special
        /// </summary>
        public virtual string[] Special { get; }

    }
}
