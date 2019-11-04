﻿using System;
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
using DDSize =DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;
        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        void SelectDrink(object sender, RoutedEventArgs args)
        {

            NavigationService.Navigate(new DrinkSelection());

        }


        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {

            if(DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(side);
            }

        }
        private void OnSelectMMC(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(side);
            }

        }
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Add(side);
            }
        }
            private void OnSelectTriceritots(object sender, RoutedEventArgs args)
            {

                if (DataContext is Order order)
                {
                    side = new Triceritots();
                    order.Add(side);
                }

            }
        

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
               side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
       
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }


    }
}
