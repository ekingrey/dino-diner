﻿///Name: Ethan Kingrey
///DinoNuggets.cs
/// Description: this class is used to order the Dino nuggets. it allows the user to add more nuggets
/// and also holds the information about its price, calories, and ingredients.

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {

        private uint nuggetCount = 6;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i =0; i< nuggetCount; i++)
                {
                    ingredients.Add( "Chicken Nugget" );
                }
                
                
                return ingredients;
            }
        }

        /// <summary>
        /// sets the price and Calories of the menue item
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggetCount;
        }

        /// <summary>
        /// adds one nugget the the custumers order
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            Price += .25;
            Calories += Calories;
        }

        
    }
}
