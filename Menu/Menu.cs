using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    class Menu
    {

        private List<IMenuItem> availableItems = new List<IMenuItem>();

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



    }
}
