/*Velociwrap.cs
 * Author: Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class VelociWrap : Entrees, IOrderItem, INotifyPropertyChanged
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
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
           
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }
        /// <summary>
        /// takes the dressing off the wrap
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes the lettuce off the wrap
        /// </summary>
        public void HoldLettuce()
        {
           
            ingredients.Remove("Romaine Lettuce");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes the cheese off the wrap
        /// </summary>
        public void HoldCheese()
        {
            
            ingredients.Remove("Parmesan Cheese");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "Veloci-Wrap";
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
                if (!ingredients.Contains("Romaine Lettuce"))
                {
                    special.Add("Hold Romaine Lettuce");
                }

                if (!ingredients.Contains("Ceasar Dressing"))
                {
                    special.Add("Hold Ceasar Dressing");
                }
                if (!ingredients.Contains("Parmesan Cheese"))
                {
                    special.Add("Hold Parmesan Cheese");
                }
                
                return special.ToArray();
            }
        }
    }
}
