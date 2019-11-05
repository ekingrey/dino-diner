/*Entrees.cs
 * Author: Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{

    public abstract class Entrees : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// an event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// notifies of a property change
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected readonly List<string> ingredients = new List<string>();
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
        /// gets the description
        /// </summary>
        public virtual string Description { get; }

        /// <summary>
        /// gets the special
        /// </summary>
        public virtual string[] Special { get; }

    }
}
