using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {

        ObservableCollection<IOrderItem> Items { get; set; }

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
    }
}
