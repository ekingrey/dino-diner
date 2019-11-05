/* FlavorSelection.xaml.cs
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
using DDSize = DinoDiner.Menu.SodasaurusFlavor;

namespace PointOfSale
{
    
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Drink drink;

        //public FlavorSelection()
        //{
        //    InitializeComponent();
        //}
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }


        /// <summary>
        /// takes the user to the menue page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDone(object sender, RoutedEventArgs args)
        {

            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// changes the sze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelect(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {

               //drink = new Sodasaurus();
                if (sender is FrameworkElement element)
                {
                    if (drink is Sodasaurus soda)
                    {
                        soda.Flavor = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                    }
                }
                    

                //if(drink)
                //order.Add(drink);
            }


        }

    }
   
}
