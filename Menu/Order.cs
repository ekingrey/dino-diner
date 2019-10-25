using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order:INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private List<IOrderItem> items;

        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

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

        public double SalesTaxRate { get; protected set; }

        public double SalesTaxCost { get => SalesTaxRate * SubtotalCost; }

        public double TotalCost { get => SalesTaxCost + SubtotalCost; }

        public Order()
        {
            items = new List<IOrderItem>();
            
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
