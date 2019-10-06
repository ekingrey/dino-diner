﻿using System;
using System.Collections.Generic;
using System.Text;

using DinoDiner.Menu;


namespace Menu
{
    public class CretacousCombo
    {

        public Entrees Entree { get; set; }

        private Side side;
        public Side Side {
            get { return side; }
            set {
                side = value;
                side.Size = size;
            }
        }

        private Drink drink;
        public Drink Drink {
            get { return drink; }
            
            set
            {
                drink = value;
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

        public CretacousCombo(Entrees entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Water();
        }

        public override string ToString()
        {
            return (Entree.ToString() + " Combo");
        }
    }
}
