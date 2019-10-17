﻿/*PterodactyWings.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{ 
    public class PterodactylWings : Entrees, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// an event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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

        /// <summary>
        /// gets a desctiption of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                //special.Add("");
                return special.ToArray();
            }
        }

    
    }
}
