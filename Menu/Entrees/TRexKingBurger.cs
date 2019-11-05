/*TRexKingBurger.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class TRexKingBurger :Entrees , IOrderItem, INotifyPropertyChanged
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
           // NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes the pickles off the burger
        /// </summary>
        public void HoldPickle()
        {
            
            ingredients.Remove("Pickle");
            //NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes ketchup off the burger
        /// </summary>
        public void HoldKetchup()
        {
           
            ingredients.Remove("Ketchup");
            //NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes mustard off the burger
        /// </summary>
        public void HoldMustard()
        {
           
            ingredients.Remove("Mustard");
           // NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes mayo off the burger
        /// </summary>
        public void HoldMayo()
        {
            
            ingredients.Remove("Mayo");
            //NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes tomatos off the burger
        /// </summary>
        public void HoldTomato()
        {
           
            ingredients.Remove("Tomato");
            //NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes the lettuce off the burger
        /// </summary>
        public void HoldLettuce()
        {
           
            ingredients.Remove("Lettuce");
           // NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// takes teh onion off the burger
        /// </summary>
        public void HoldOnion()
        {
           
            ingredients.Remove("Onion");
           // NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// creates the description
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
        /// <summary>
        /// returns the description
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// adds to the special
        /// </summary>
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
                if (!ingredients.Contains("Mayo"))
                {
                    special.Add("Hold Mayo");
                }
                if (!ingredients.Contains("Onion"))
                {
                    special.Add("Hold Onion");
                }
                if (!ingredients.Contains("Tomato"))
                {
                    special.Add("Hold Tomato");
                }
                if (!ingredients.Contains("Lettuce"))
                {
                    special.Add("Hold Lettuce");
                }
                return special.ToArray();
            }
        }
    }
}
