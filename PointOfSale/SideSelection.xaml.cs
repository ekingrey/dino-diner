/* SideSelect.xaml.cs
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
using Menu;
using DDSize =DinoDiner.Menu.Size;

namespace PointOfSale
{
    
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;
        private CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
        private bool combo = false;

        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            combo = true;
            SizeSmall.Visibility = Visibility.Hidden;
            SizeMedium.Visibility = Visibility.Hidden;
            SizeLarge.Visibility = Visibility.Hidden;
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }
        /// <summary>
        /// goes to drink page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {

            NavigationService.Navigate(new DrinkSelection());

        }

        /// <summary>
        /// goes to corosponding page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {

            if(DataContext is Order order)
            {
                side = new Fryceritops();
                if (combo)
                {
                    order.Remove(cc);
                    cc.Side = side;
                    order.Add(cc);
                }
                else
                    order.Add(side);
            }

        }
        /// <summary>
        /// goes to corosponding page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMMC(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                if (combo)
                {
                    order.Remove(cc);
                    cc.Side = side;
                    order.Add(cc);
                }
                else
                    order.Add(side);
            }

        }
        /// <summary>
        /// goes to corosponding page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                if (combo)
                {
                    order.Remove(cc);
                    cc.Side = side;
                    order.Add(cc);
                }
                else
                    order.Add(side);
            }
        }
        /// <summary>
        /// goes to corosponding page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
            {

                if (DataContext is Order order)
                {
                    side = new Triceritots();
                if (combo)
                {
                    order.Remove(cc);
                    cc.Side = side;
                    order.Add(cc);
                }
                else
                    order.Add(side);
            }

            }
        
        /// <summary>
        /// changes size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
               side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
        /// <summary>
        /// goes to main menue page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }


    }
}
