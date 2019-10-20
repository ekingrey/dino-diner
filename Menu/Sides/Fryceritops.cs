/*Fryceritops.cs
 * Author: Ethan Kingrey
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class Fryceritops : Side, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// an event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Size size;
        /// <summary>
        /// gets or sets the size of the side
        /// </summary>
        public override Size Size
        {

            set
            {
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case (Size.Medium):
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case (Size.Large):
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
            get { return size; }
        }


        /// <summary>
        /// sets the price, calories, and adds the ingredianets to a list
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }

        public override string ToString()
        {
            switch (size)
            {
                case (Size.Small):
                    return "Small Fryceritops";

                case (Size.Medium):
                    return "Medium Fryceritops";

                case (Size.Large):
                    return "Large Fryceritops";

            }
            return "";
        }


        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                
                return special.ToArray();
            }
        }

    }
}
