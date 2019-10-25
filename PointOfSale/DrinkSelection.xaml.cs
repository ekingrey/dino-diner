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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Drink drink;
        public DrinkSelection()
        {
            InitializeComponent();
        }
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }

        void SelectDrink(object sender, RoutedEventArgs args)
        {

            NavigationService.Navigate(new DrinkSelection());

        }
        void SelectFlavor(object sender, RoutedEventArgs args)
        {

            NavigationService.Navigate(new FlavorSelection());

        }
    }
}
