/* Tyrannotea.cs
 * Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, IOrderItem, INotifyPropertyChanged
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
        private bool sweet = false;
        /// <summary>
        /// makes the drink sweet or not
        /// </summary>
        public bool Sweet {
            get { return sweet; }
            set
            {
                if (value)
                {
                    sweet = true;
                    ingredients.Add("Cane Sugar");
                }
                else
                {
                    sweet = false;
                    ingredients.Remove("Cane Sugar");
                }
                NotifyOfPropertyChanged("Description");
                //NotifyOfPropertyChanged("Calories");

            }
        }
        /// <summary>
        /// holds ice
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// adds a lemon to the tea
        /// </summary>
        public bool Lemon { get; set; } = false;


        /// <summary>
        /// holds the size of the drink
        /// </summary>
        private Size size;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        Price = .99;
                        if (Sweet)
                        {
                            Calories = 8*2;
                            
                        }
                        else
                        {
                            Calories = 8;
                        }
                        break;
                    case (Size.Medium):
                        Price = 1.49;
                        if (Sweet)
                        {
                            Calories = 16 * 2;
                            
                        }
                        else
                        {
                            Calories = 16;
                        }
                        break;
                    case (Size.Large):
                        Price = 1.99;
                        if (Sweet)
                        {
                            Calories = 32 * 2;
                            
                        }
                        else
                        {
                            Calories = 32;
                        }
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// adds a lemon to the tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }


        public Tyrannotea()
        {
            Price = .99;
            Calories = 8;
            
            ingredients.Add("Water");
            ingredients.Add("Tea");
            if (Sweet)
            {
                ingredients.Add("Cane Sugar");
                //NotifyOfPropertyChanged("Ingredients");
                
            }
            
        }
        /// <summary>
        /// creats the drink deffinition
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (size)
            {
                case (Size.Small):
                    if (Sweet)
                        return "Small Sweet Tyrannotea";
                    else return "Small Tyrannotea";

                case (Size.Medium):
                    if (Sweet)
                        return "Medium Sweet Tyrannotea";
                    else return "Medium Tyrannotea";

                case (Size.Large):
                    if (Sweet)
                        return "Large Sweet Tyrannotea";
                    else return "Large Tyrannotea";

            }
            return "";
        }
        /// <summary>
        /// returns the description
        /// </summary>
        public override string Description
        {
            get {
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
                if (Lemon)
                {
                    special.Add("Add Lemon");
                }


                return special.ToArray();
            }
        }
    }
}
