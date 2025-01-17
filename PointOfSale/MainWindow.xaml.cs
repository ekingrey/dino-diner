﻿/* MainWindow.xaml.cs
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = new Order();
            //order.Items.Add(new PrehistoricPBJ());
            //order.Items.Add(new Sodasaurus());
            //order.Items.Add(new Fryceritops());
            //SteakosaurusBurger sb = new SteakosaurusBurger();
            //sb.HoldPickle();
            //sb.HoldBun();
            //order.Items.Add(sb);
            DataContext =  order;

            OrderList.NavigationService = OrderUI.NavigationService;
           
        }
        /// <summary>
        /// passes the data context
        /// </summary>
        private void PassDataContextToPage()
        {
            if(OrderUI.Content is Page page){
                page.DataContext = OrderUI.DataContext;
            }
        }
        /// <summary>
        /// passes tje data context
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLoadCompleted(Object sender, NavigationEventArgs args)
        {
            PassDataContextToPage();
        }
        /// <summary>
        /// passes teh data context
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDataContextChanged(Object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContextToPage();
        }
        /// <summary>
        /// go to main menue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnReturnToCategorySelection(object sender, RoutedEventArgs args)
        {
            OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }

    }
}
