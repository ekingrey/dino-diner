/*IMenuItem.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// the price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// the calories
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// the ingredients
        /// </summary>
        List<string> Ingredients { get; }


    }
}
