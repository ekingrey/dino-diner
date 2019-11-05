/*ComboSelection.xaml.cs
 * Ethan Kingrey
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// takes tje user to the customize combo page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void CustomCombo(object sender, RoutedEventArgs args)
        {
            if(DataContext is Entrees e)
            {
                NavigationService.Navigate(new CustomizePBJ(e,true));
            }
            

        }
        /// <summary>
        /// taes you to the drink page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {

            NavigationService.Navigate(new DrinkSelection());

        }
        /// <summary>
        /// taes you to the customize page on button push
        /// </summary>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();

                NavigationService.Navigate(new CustomizePBJ(bw, true));
                order.Add(bw);
            }

        }
        /// <summary>
        /// taes you to the customize page on button push
        /// </summary>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();

                NavigationService.Navigate(new CustomizePBJ(dn, true));
                order.Add(dn);
            }

        }
        /// <summary>
        /// taes you to the customize page on button push
        /// </summary>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();

                NavigationService.Navigate(new CustomizePBJ(pbj, true));
                order.Add(pbj);
            }

        }
        /// <summary>
        /// adds wings to the order
        /// </summary>
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                PterodactylWings entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new CustomizeCombo());
            }

        }
        /// <summary>
        /// taes you to the customize page on button push
        /// </summary>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();

                NavigationService.Navigate(new CustomizePBJ(sb, true));
                order.Add(sb);
            }

        }
        /// <summary>
        /// taes you to the customize page on button push
        /// </summary>
        private void OnSelectTRKB(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                TRexKingBurger tx = new TRexKingBurger();

                NavigationService.Navigate(new CustomizePBJ(tx, true));
                order.Add(tx);
            }

        }
        /// <summary>
        /// taes you to the customize page on button push 
        /// </summary>
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();

                NavigationService.Navigate(new CustomizePBJ(vw, true));
                order.Add(vw);
            }

        }
    }
}
