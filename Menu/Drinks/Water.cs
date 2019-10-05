/* Water.cs
 * Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    public class Water : Drink
    {

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
                        Price = .10;
                        Calories = 0;
                        break;
                    case (Size.Medium):
                        Price = .10;
                        Calories = 0;
                        break;
                    case (Size.Large):
                        Price = .10;
                        Calories = 0;
                        break;
                }

            }
        }


        public Water()
        {
            
            Price = .10;
            Calories = 0;
            ingredients.Add("Water");
            
        }

        /// <summary>
        /// adds a lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }


        public override string ToString()
        {
            switch (size)
            {
                case (Size.Small):
                    return "Small Water";

                case (Size.Medium):
                    return "Medium Water";

                case (Size.Large):
                    return "Large Water";

            }
            return "";
        }

    }
}
