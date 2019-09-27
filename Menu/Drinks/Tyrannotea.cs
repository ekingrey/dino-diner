/* Tyrannotea.cs
 * Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
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

                
            }
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

            }
        }

        /// <summary>
        /// adds a lemon to the tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
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
            }
            
        }

    }
}
