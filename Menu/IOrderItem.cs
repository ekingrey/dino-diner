/*IOrderItem.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public interface IOrderItem : INotifyPropertyChanged
    {

        /// <summary>
        /// gets the price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// gets teh description
        /// </summary>
        string Description { get; }
        /// <summary>
        /// getst the special
        /// </summary>
        string[] Special { get; }
        
        
    }
}
