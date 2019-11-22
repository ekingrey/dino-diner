/*Menu.cs
 * Author: Ethan Kingrey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// list of availible items
        /// </summary>
        private List<IMenuItem> availableItems = new List<IMenuItem>();
        /// <summary>
        /// list of availible items
        /// </summary>
        private List<Entrees> availableEntrees = new List<Entrees>();
        /// <summary>
        /// list of availible items
        /// </summary>
        private List<Side> availableSides = new List<Side>();
        /// <summary>
        /// list of availible items
        /// </summary>
        private List<Drink> availableDrinks = new List<Drink>();

        private List<string> ingredients = new List<string>();

        public List<string> PossibleIngredients
        {
            get {

                foreach (IMenuItem item in AvailableMenuItems)
                {
                    foreach (string ing in item.Ingredients)
                    {
                        if (!ingredients.Contains(ing))
                        {
                            ingredients.Add(ing);
                        }
                    }

                }
                ingredients.Sort();
                return new List<string>(ingredients);
            }
        }

        /// <summary>
        /// crates a list of availible items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                
                

                availableItems.Add(new Brontowurst());
                availableItems.Add(new DinoNuggets());
                availableItems.Add(new PrehistoricPBJ());
                availableItems.Add(new PterodactylWings());
                availableItems.Add(new SteakosaurusBurger());
                availableItems.Add(new TRexKingBurger());
                availableItems.Add(new VelociWrap());

                availableItems.Add(new Fryceritops());
                availableItems.Add(new MeteorMacAndCheese());
                availableItems.Add(new MezzorellaSticks());
                availableItems.Add(new Triceritots());

                availableItems.Add(new JurrasicJava());
                availableItems.Add(new Sodasaurus());
                availableItems.Add(new Tyrannotea());
                availableItems.Add(new Water());

                return new List<IMenuItem>(availableItems);
            }
        }
        /// <summary>
        /// creates a list of avalible entrees
        /// </summary>
        public List<Entrees> AvailableEntrees
        {
            get
            {
                availableEntrees.Add(new Brontowurst());
                availableEntrees.Add(new DinoNuggets());
                availableEntrees.Add(new PrehistoricPBJ());
                availableEntrees.Add(new PterodactylWings());
                availableEntrees.Add(new SteakosaurusBurger());
                availableEntrees.Add(new TRexKingBurger());
                availableEntrees.Add(new VelociWrap());

                return new List<Entrees>(availableEntrees);
            }
        }
        /// <summary>
        /// creates a list of availible sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                availableSides.Add(new Fryceritops());
                availableSides.Add(new MeteorMacAndCheese());
                availableSides.Add(new MezzorellaSticks());
                availableSides.Add(new Triceritots());

                return new List<Side>(availableSides);
            }
        }
        /// <summary>
        /// createas a list of availible drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                availableDrinks.Add(new JurrasicJava());
                availableDrinks.Add(new Sodasaurus());
                availableDrinks.Add(new Tyrannotea());
                availableDrinks.Add(new Water());

                return new List<Drink>(availableDrinks);
            }
        }
        /// <summary>
        /// creates a description
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            foreach (IMenuItem item in AvailableMenuItems)
            {
                return item.ToString() + "\n";
            }
            return "";
        }

    }
}
