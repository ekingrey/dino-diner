﻿///Name: Ethan Kingrey
///SteakosaurusBurger.cs
/// Description: this class is used to order the Steakosaurus burger. it allows the user to remove ingredients
/// and also holds the information about its price, calories, and ingredients.

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        private bool bun = true, pickle = true, ketchup = true, mustard = true, lettuce = true, tomato = true, onion = true, mayo = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                if (onion) ingredients.Add("Onion");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                
                
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldMayo()
        {
            this.mayo = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}