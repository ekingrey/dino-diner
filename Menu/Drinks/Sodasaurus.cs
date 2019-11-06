/* Sodasaurous.cs
 * Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// an event handler for PropertyChanged events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// notifies of property change
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// holds the flavor of the drink
        /// </summary>
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// holds the size of the drink
        /// </summary>
        private Size size;
        public override Size Size {
            get { return size; }
            set {
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case (Size.Medium):
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case (Size.Large):
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }
        

        public Sodasaurus(){
            Price = 1.5;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }
        /// <summary>
        /// sets the deffifnition of the drink
        /// </summary>
        /// <returns>returns the description</returns>
        public override string ToString()
        {
            switch (size)
            {
                case (Size.Small):
                    return "Small "+ Flavor + " Sodasaurus";

                case (Size.Medium):
                    return "Medium " + Flavor + " Sodasaurus";

                case (Size.Large):
                    return "Large " + Flavor + " Sodasaurus";

            }
            return "";
        }
        /// <summary>
        /// removes ice
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// returns the description of the drink
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// adds to the special list
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
