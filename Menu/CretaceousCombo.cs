using System;
using System.Collections.Generic;
using System.Text;

using DinoDiner.Menu;
using System.ComponentModel;


namespace Menu
{
    public class CretaceousCombo: IOrderItem
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Entrees entree;
        public Entrees Entree { get { return entree; } protected set
            { entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };

            }
        }

        private Side side ;
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }

        private Drink drink = new Sodasaurus();
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

        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - .25;
            }

        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        private Size size = Size.Small;
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


            }
        }

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


        public CretaceousCombo(Entrees entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Water();
        }

        public override string ToString()
        {
            return (Entree.ToString() + " Combo");
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
