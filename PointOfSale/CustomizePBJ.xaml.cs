/*Customizepbj.xaml.cs
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
    /// Interaction logic for PrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePBJ : Page
    {
        private Entrees entree;
        private bool combo;
        public CustomizePBJ(Entrees entree, bool combo)
        {

            InitializeComponent();
            this.combo = combo;
            if (entree is PrehistoricPBJ pbj)
            {
                peanutButter.Visibility = Visibility.Visible;
                Jelly.Visibility = Visibility.Visible;
                this.entree = pbj;
                
            }
            if (entree is Brontowurst bw)
            {
               onions.Visibility = Visibility.Visible;
                bun.Visibility = Visibility.Visible;
                peppers.Visibility = Visibility.Visible;
                this.entree = bw;
            }
            if (entree is DinoNuggets dn)
            {
                nugget.Visibility = Visibility.Visible;
                this.entree = dn;
            }
            if (entree is SteakosaurusBurger sb)
            {
                
                mustard.Visibility = Visibility.Visible;
                ketchup.Visibility = Visibility.Visible;
                
                pickles.Visibility = Visibility.Visible;
               
                bun.Visibility = Visibility.Visible;
                this.entree = sb;
            }
            if (entree is TRexKingBurger tx)
            {
                Tomate.Visibility = Visibility.Visible;
                lettuce.Visibility = Visibility.Visible;
                mustard.Visibility = Visibility.Visible;
                ketchup.Visibility = Visibility.Visible;
                mayo.Visibility = Visibility.Visible;
                pickles.Visibility = Visibility.Visible;
                onions.Visibility = Visibility.Visible;
                bun.Visibility = Visibility.Visible;
                this.entree = tx;
            }
            if (entree is VelociWrap vw)
            {
                cheese.Visibility = Visibility.Visible;
                dressing.Visibility = Visibility.Visible;
                lettuce.Visibility = Visibility.Visible;
                this.entree = vw;
            }

        }
        /// <summary>
        /// holds the peanutButter
        /// </summary>
       
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            ((PrehistoricPBJ)entree).HoldPeanutButter();
        }
        /// <summary>
        /// holds the jelly
        /// </summary>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            ((PrehistoricPBJ)entree).HoldJelly();
        }
        /// <summary>
        /// holds the bun
        /// </summary>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldBun();
            }
            if (entree is TRexKingBurger tx)
            {
                tx.HoldBun();
            }
            if (entree is Brontowurst bw)
            {
                bw.HoldBun();
            }
        }
        /// <summary>
        /// holds the peppers
        /// </summary>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            ((Brontowurst)entree).HoldPeppers();
        }
        /// <summary>
        /// holds the onions
        /// </summary>
        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            if (entree is Brontowurst bw)
            {
                bw.HoldOnion();
            }
            if (entree is TRexKingBurger tx)
            {
                tx.HoldOnion();
            }
        }
        /// <summary>
        /// holds the pickles
        /// </summary>
        private void OnHoldPickles(object sender, RoutedEventArgs args)
        {
            if(entree is SteakosaurusBurger sb)
            {
                sb.HoldPickle();
            }
            if (entree is TRexKingBurger tx)
            {
                tx.HoldPickle();
            }
        }
        /// <summary>
        /// holds the ketchup
        /// </summary>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldKetchup();
            }
            if (entree is TRexKingBurger tx)
            {
                tx.HoldKetchup();
            }
        }
        /// <summary>
        /// holds the mustard
        /// </summary>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            if (entree is SteakosaurusBurger sb)
            {
                sb.HoldMustard();
            }
            if (entree is TRexKingBurger tx)
            {
                tx.HoldMustard();
            }
        }
        /// <summary>
        /// holds the mayo
        /// </summary>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            ((TRexKingBurger)entree).HoldMayo();
        }
        /// <summary>
        /// holds the tomato
        /// </summary>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            
            if (entree is TRexKingBurger tx)
            {
                tx.HoldTomato();
            }

        }
        /// <summary>
        /// holds the lettuce
        /// </summary>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            if (entree is VelociWrap vw)
            {
                vw.HoldLettuce();
            }
            if (entree is TRexKingBurger tx)
            {
                tx.HoldLettuce();
            }

        }
        /// <summary>
        /// holds the dressing
        /// </summary>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            ((VelociWrap)entree).HoldDressing();

        }
        /// <summary>
        /// holds the cheese
        /// </summary>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            ((VelociWrap)entree).HoldCheese();

        }
        /// <summary>
        /// adds nuggets
        /// </summary>
        private void AddNugget(object sender, RoutedEventArgs args)
        {

            ((DinoNuggets)entree).AddNugget();
        }
        /// <summary>
        /// goes back to entree page
        /// </summary>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo)
            {
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
                NavigationService.GoBack();
            }
            
        }

    }
}