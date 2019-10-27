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
using DDSize = DinoDiner.Menu.Size;

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
            if (drink is Sodasaurus soda)
            {
                sdf.IsEnabled = true;
            }
        }

        private void OnSelectJurrasicJava(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                sdf.IsEnabled = true;
                drink = new JurrasicJava();
                if (drink is JurrasicJava java)
                {
                   
                }

                //if(drink)
                order.Add(drink);
            }


        }
        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                //NavigationService.Navigate(new FlavorSelection());
                sdf.IsEnabled = true;
                drink = new Sodasaurus();
                if (drink is Sodasaurus soda)
                {
                    //soda.Flavor=SodasaurusFlavor(drink);
                }

                //if(drink)
                order.Add(drink);
            }


        }
        private void OnSelectTea(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                lemon.IsEnabled = true;
                sdf.IsEnabled = true;
                drink = new Tyrannotea();
                if (drink is Tyrannotea tea)
                {
                    if (tea.Lemon)
                    {
                        tea.AddLemon();
                    }
                }

                //if(drink)
                order.Add(drink);
            }


        }
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                lemon.IsEnabled = true;
                drink = new Water();
                if(drink is Water water)
                {
                    if (water.Lemon)
                    {
                        water.AddLemon();
                    }
                }
                
                //if(drink)
                order.Add(drink);
            }


        }

        private void MakeDecaf(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (drink is JurrasicJava java)
                    {
                        java.Decaf = true;

                    }
                    if (drink is Tyrannotea tea)
                    {
                        tea.Sweet = true;

                    }
                    if (drink is Sodasaurus soda)
                    {
                        NavigationService.Navigate(new FlavorSelection(soda));

                    }

                }

            }
            sdf.IsEnabled = false;
        }

        private void AddLemon(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (drink is Water water)
                    {
                        water.Lemon = true;
                        
                    }
                    if (drink is Tyrannotea tea)
                    {
                        tea.Lemon = true;

                    }
                }
                
            }
            lemon.IsEnabled = false;
        }
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }


        void SelectDrink(object sender, RoutedEventArgs args)
        {

            NavigationService.Navigate(new DrinkSelection());

        }
        void SelectFlavor(object sender, RoutedEventArgs args)
        {

           // NavigationService.Navigate(new FlavorSelection());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
