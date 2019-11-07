/*CretaceousCombo.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

using DinoDiner.Menu;
using System.ComponentModel;


namespace Menu
{
    public class CretaceousCombo: IOrderItem
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
        /// private backing vaiable
        /// </summary>
        private Entrees entree;
        /// <summary>
        /// gets and sets the entree for the combo
        /// </summary>
        public Entrees Entree { get { return entree; } set
            { entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };

            }
        }
        /// <summary>
        /// private backing variable
        /// </summary>
        private Side side ;
        /// <summary>
        /// gets and sets the side
        /// </summary>
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }
        /// <summary>
        /// private backing variable
        /// </summary>
        private Drink drink = new Sodasaurus();
        /// <summary>
        /// gets and sets the drink for the combo
        /// </summary>
        public Drink Drink
        {
            get { return drink; }

            set
            {
                drink = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                drink.Size = size;
            }
        }
        /// <summary>
        /// gets the price
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - .25;
            }

        }
        /// <summary>
        /// gets the callories
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        /// <summary>
        /// private backing variable
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// gets and sets the size
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");


            }
        }
        /// <summary>
        /// vreates a list of inc=gredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// cunstructor
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entrees entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Water();
        }
        /// <summary>
        /// crates the description
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (Entree.ToString() + " Combo");
        }

        /// <summary>
        /// returns the description
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// creates a list of special
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
               
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();

            }
        }
    }
}
