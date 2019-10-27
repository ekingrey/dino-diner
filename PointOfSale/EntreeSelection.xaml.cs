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
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entrees entree;
        public EntreeSelection()
        {
            InitializeComponent();
        }
        public EntreeSelection(Entrees entree)
        {
            InitializeComponent();
            this.entree = entree;
        }
        void SelectDrink(object sender, RoutedEventArgs args)
        {

            NavigationService.Navigate(new DrinkSelection());

        }

        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
               
                
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }

        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
        private void OnSelectTRKB(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
    }
}
