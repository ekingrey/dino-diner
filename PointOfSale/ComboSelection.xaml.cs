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
using DinoDiner;
using Menu;

namespace PointOfSale
{
   
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
       // private Drink drink;
        //private Side side;
        private CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
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
                NavigationService.Navigate(new CustomizePBJ(e,true, cc));
            }
            

        }
        /// <summary>
        /// taes you to the drink page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            
            NavigationService.Navigate(new DrinkSelection(cc.Drink));

        }
        /// <summary>
        /// taes you to the customize page on button push
        /// </summary>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {

            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                cc.Entree = bw;
                
                NavigationService.Navigate(new CustomizePBJ(cc.Entree, true, this.cc));
               // CretaceousCombo cc = new CretaceousCombo(bw);
                order.Add(cc);
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
                cc.Entree = dn;
                NavigationService.Navigate(new CustomizePBJ(dn, true, cc));
                //CretaceousCombo cc = new CretaceousCombo(dn);
                order.Add(cc);
                
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
                cc.Entree = pbj;
                NavigationService.Navigate(new CustomizePBJ(pbj, true, cc));
                //CretaceousCombo cc = new CretaceousCombo(pbj);
                order.Add(cc);
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
                cc.Entree = entree;
                 order.Add(cc);
                NavigationService.Navigate(new CustomizeCombo(cc));
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
                cc.Entree = sb;
                NavigationService.Navigate(new CustomizePBJ(sb, true, cc));
               // CretaceousCombo cc = new CretaceousCombo(sb);
                order.Add(cc);
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
                cc.Entree = tx;
                NavigationService.Navigate(new CustomizePBJ(tx, true, cc));
                //CretaceousCombo cc = new CretaceousCombo(tx);
                order.Add(cc);
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
                cc.Entree = vw;
                NavigationService.Navigate(new CustomizePBJ(vw, true, cc));
                //CretaceousCombo cc = new CretaceousCombo(vw);
                order.Add(cc);
            }

        }
    }
}
