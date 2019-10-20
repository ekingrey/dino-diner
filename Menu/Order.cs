using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {

        ObservableCollection<IOrderItem> Items { get; set; }

        public double SubtotalCost { get; }

        public double SalesTaxRate { get; protected set; }

        public double SalesTaxCost { get; }

        public double TotalCost { get; }
    }
}
