/*Order.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order:INotifyPropertyChanged
    {
        /// <summary>
        /// an event handler for property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// private backing variable
        /// </summary>
        private List<IOrderItem> items;

        /// <summary>
        /// adds items to the order
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }
        /// <summary>
        /// calculates the subtotal cost
        /// </summary>
        public double SubtotalCost {
            get
            {
                double sum = 0;
                foreach(IOrderItem item in Items){
                    sum += item.Price;
                }
                if (sum >= 0)
                    return sum;
                else
                    return 0;
            }
        }
        /// <summary>
        /// gets and sets the rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }
        /// <summary>
        /// gets the sales tax
        /// </summary>
        public double SalesTaxCost { get => SalesTaxRate * SubtotalCost; }
        /// <summary>
        /// gets the total
        /// </summary>
        public double TotalCost { get => SalesTaxCost + SubtotalCost; }
        //the constructor
        public Order()
        {
            items = new List<IOrderItem>();
            
        }
        /// <summary>
        /// adds to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }
        /// <summary>
        /// removes from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }
        /// <summary>
        /// notifies of property change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }


    }
}
