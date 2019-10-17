/*SteakosaurousBurger.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entrees, IOrderItem, INotifyPropertyChanged
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
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;

            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
        }

        /// <summary>
        /// takes the bun off the burger
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes pickles off the burger
        /// </summary>
        public void HoldPickle()
        {
            
            ingredients.Remove("Pickle");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes ketchup off the burger
        /// </summary>
        public void HoldKetchup()
        {
            
            ingredients.Remove("Ketchup");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes mustard off the burger
        /// </summary>
        public void HoldMustard()
        {
            
            ingredients.Remove("Mustard");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "Steakosaurus Burger";

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

                if (!ingredients.Contains("Ketchup"))
                {
                    special.Add("Hold Ketchup");
                }
                if (!ingredients.Contains("Mustard"))
                {
                    special.Add("Hold Mustard");
                }
                if (!ingredients.Contains("Pickle"))
                {
                    special.Add("Hold Pickle");
                }
                return special.ToArray();
            }
        }

        }
}
