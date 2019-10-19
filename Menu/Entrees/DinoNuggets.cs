/*DinoNuggets.cs
 * Author: Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entrees, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// an event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private uint nuggetCount = 6;

        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public DinoNuggets()
        {
            
            this.Price = 4.25;
            this.Calories = 59 * nuggetCount;

            for (int i = 0; i < 6; i++)
            {
                ingredients.Add("Chicken Nugget");
            }
        }

        /// <summary>
        /// adds one nugget the the custumers order
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            Price += .25;
            Calories += 59;
            ingredients.Add("Chicken Nugget");
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
        }
        public override string ToString()
        {
            return "Dino-Nuggets";
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
                if(nuggetCount!=6)
                    special.Add((nuggetCount-6)+" Extra Nuggets");
                
                return special.ToArray();
            }
        }
    }
}
