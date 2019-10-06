using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    class Menu
    {

        private List<IMenuItem> availableItems = new List<IMenuItem>();
        private List<Entrees> availableEntrees = new List<Entrees>();
        private List<Side> availableSides = new List<Side>();
        private List<Drink> availableDrinks = new List<Drink>();

        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                
                availableItems.Add(new JurrasicJava());
                availableItems.Add(new Sodasaurus());
                availableItems.Add(new Tyrannotea());
                availableItems.Add(new Water());

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

                return availableItems;
            }
        }

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

                return availableEntrees;
            }
        }

        public List<Side> AvailableSides
        {
            get
            {
                availableSides.Add(new Fryceritops());
                availableSides.Add(new MeteorMacAndCheese());
                availableSides.Add(new MezzorellaSticks());
                availableSides.Add(new Triceritots());

                return availableSides;
            }
        }

        public List<Drink> AvailableDrinks
        {
            get
            {
                availableDrinks.Add(new JurrasicJava());
                availableDrinks.Add(new Sodasaurus());
                availableDrinks.Add(new Tyrannotea());
                availableDrinks.Add(new Water());

                return availableDrinks;
            }
        }

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
