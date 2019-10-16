/*PrehistoricPBJ.cs
 * Author: Ethan Kingrey
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entrees, INotifyPropertyChanged
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
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;

            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
            ingredients.Add("Bread");
        }

        /// <summary>
        /// takes peanut butter off the sandwich
        /// </summary>
        public void HoldPeanutButter()
        {
            ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// takes jelly off the sandwich
        /// </summary>
        public void HoldJelly()
        {
            
            ingredients.Remove("Jelly");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        public override string ToString()
        {
            return "Prehistoric PB&J";
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
                if (!ingredients.Contains("Peanut Butter"))
                {
                    special.Add("Hold Peanut Butter");
                }

                if (!ingredients.Contains("Jelly"))
                {
                    special.Add("Hold Jelly");
                }
                return special.ToArray();
            }
        }
        


        
    }
}
