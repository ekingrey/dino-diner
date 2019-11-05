/* JurrasicJava.cs
 * Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurrasicJava : Drink, IOrderItem, INotifyPropertyChanged
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
        /// leaves room in the drink for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// makes the drink decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// holds the size of the drink
        /// </summary>
        private Size size;
        /// <summary>
        /// sets the size of the drink
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        Price = .59;
                        Calories = 2;
                        break;
                    case (Size.Medium):
                        Price = .99;
                        Calories = 4;
                        break;
                    case (Size.Large):
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }


        public JurrasicJava()
        {
            Ice = false;
            Price = .59;
            Calories = 2;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
            
        }

        /// <summary>
        /// leaves room forcream 
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            
            NotifyOfPropertyChanged("Special");
        }
            /// <summary>
            /// adds ice to the drink
            /// </summary>
        public void AddIce()
        {
            Ice = true;
            //NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// overides the name of the drink
        /// </summary>
        /// <returns>the name of hte drink</returns>
        public override string ToString()
        {
            switch (size)
            {
                case (Size.Small):
                    if(Decaf)
                    return "Small Decaf Jurrasic Java";
                    else return "Small Jurrasic Java";

                case (Size.Medium):
                    if (Decaf)
                        return "Medium Decaf Jurrasic Java";
                    else return "Medium Jurrasic Java";

                case (Size.Large):
                    if (Decaf)
                        return "Large Decaf Jurrasic Java";
                    else return "Large Jurrasic Java";

            }
            return "";
        }

        /// <summary>
        /// gets the description
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// adds to the special list
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream)
                {
                    special.Add("Room For Cream");
                }
                if (Ice)
                {
                    special.Add("Add Ice");
                }

                return special.ToArray();
            }
        }
    }
}
