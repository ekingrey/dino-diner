﻿/* OrderList.xaml.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {

        public NavigationService NavigationService { get; set; }

        public OrderList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// goes to the corosponding page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {

            if(OrderItems.SelectedItem is Side side)
            {
                NavigationService.Navigate(new SideSelection(side));
            }
            if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService.Navigate(new DrinkSelection(drink));
            }
            if (OrderItems.SelectedItem is Entrees entrees)
            {
                NavigationService.Navigate(new EntreeSelection(entrees));
            }
        }
        /// <summary>
        /// removes the itrem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }

                }
            }
        }


    }
}
