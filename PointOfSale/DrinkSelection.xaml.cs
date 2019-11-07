/* DrinkSelection.xaml.cs
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
using DDSize = DinoDiner.Menu.Size;
using DinoDiner;
using Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Drink drink;
        private bool combo = false;
        public DrinkSelection()
        {
            InitializeComponent();
        }
        private CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
        public DrinkSelection(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            combo = true;
        }
        /// <summary>
        /// takes the user to the drink page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            combo = true;
            if (drink is Sodasaurus soda)
            {
                sdf.IsEnabled = true;
            }
        }
       /// <summary>
       /// sdds to the order
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="args"></param>
        private void OnSelectJurrasicJava(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                sdf.IsEnabled = true;
                drink = new JurrasicJava();
                cc.Drink = new JurrasicJava();
                if (drink is JurrasicJava java)
                {
                   
                }

                if (combo)
                {
                    order.Remove(cc);
                    cc.Drink = drink;
                    order.Add(cc);
                }
                else
                    order.Add(drink);
            }


        }
        /// <summary>
        /// sdds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                //NavigationService.Navigate(new FlavorSelection());
                sdf.IsEnabled = true;
                drink = new Sodasaurus();
                cc.Drink = new Sodasaurus();
                if (drink is Sodasaurus soda)
                {
                    //soda.Flavor=SodasaurusFlavor(drink);
                }

                if (combo)
                {
                    order.Remove(cc);
                    cc.Drink = drink;
                    order.Add(cc);
                }
                else
                    order.Add(drink);
            }


        }
        /// <summary>
        /// sdds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
                if (combo)
                {
                    order.Remove(cc);
                    cc.Drink = drink;
                    order.Add(cc);
                }
                else
                    order.Add(drink);


            }


        }
        /// <summary>
        /// sdds to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                lemon.IsEnabled = true;
                drink = new Water();
                cc.Drink = new Water();
                if (drink is Water water)
                {
                    if (water.Lemon)
                    {
                        water.AddLemon();
                    }
                }

                if (combo)
                {
                    order.Remove(cc);
                    cc.Drink = drink;
                    order.Add(cc);
                }
                else
                    order.Add(drink);
            }


        }
        /// <summary>
        /// makes it decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
        /// <summary>
        /// ads a lemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
        /// <summary>
        /// changes the size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        /// <summary>
        /// go to drink page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {

            NavigationService.Navigate(new DrinkSelection());

        }
        /// <summary>
        /// go to flavor page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {

           // NavigationService.Navigate(new FlavorSelection());

        }
        /// <summary>
        /// go to main menue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
