using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class Brontowurst
    {
        private bool bun, peppers, onions;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "brautwurst"};
                if (bun) ingredients.Add("whole-wheat bun");
                if (peppers) ingredients.Add("peppers");
                if (onions) ingredients.Add("onions");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void holdBun()
        {
            this.bun = false;
        }

        public void holdPeppers()
        {
            this.peppers = false;
        }

        public void holdOnions()
        {
            this.onions = false;
        }
    }
}
