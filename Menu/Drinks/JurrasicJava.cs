/* JurrasicJava.cs
 * Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    public class JurrasicJava : Drink
    {
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

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
            
        public void AddIce()
        {
            Ice = true;
        }


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

    }
}
