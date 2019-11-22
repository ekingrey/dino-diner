using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// a reference to the Menu
        /// </summary>
        private DinoDiner.Menu.Menu menu = new DinoDiner.Menu.Menu();
        
        /// <summary>
        /// gets a list of Entree items
        /// </summary>
        public List<Entrees> entree {
            get
            {
                List<Entrees> result = new List<Entrees>();

                foreach (IMenuItem item in menuItems)
                {
                    if (item is Entrees entree)
                    {
                        result.Add(entree);
                    }
                }

                return result;
            }
        }
        /// <summary>
        /// gets a list of Drinks items
        /// </summary>
        public List<Drink> drink { get
            {
              
                    List<Drink> result = new List<Drink>();

                    foreach (IMenuItem item in menuItems)
                    {
                        
                        if (item is Drink drink)
                        {
                            
                           result.Add(drink);
                           
                        }

                    }

                    return result;
                
            }
        }
        /// <summary>
        /// gets a list of Sides items
        /// </summary>
        public List<Side> side { get
            {
                List<Side> result = new List<Side>();

                foreach (IMenuItem item in menuItems)
                {
                    
                    if (item is Side side)
                    {
                        
                            result.Add(side);
                        
                    }
                   

                }

                return result;
            }
        }
        /// <summary>
        /// gets a list of All menue items
        /// </summary>
        public List<IMenuItem> menuItems;
        /// <summary>
        /// gets a list of all ingredients items
        /// </summary>
        public List<string> ingredients { get => menu.AvailableIngredients; }

        public CretaceousCombo cc;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minCost { get; set; }
        [BindProperty]
        public float? maxCost { get; set; }

        public void OnGet()
        {
            menuItems = menu.AvailableMenuItems;
        }

        public void OnPost()
        {
            menuItems = menu.AvailableMenuItems;

            if (search != null)
            {
                menuItems = Search(menuItems, search);
            }
            //if (menuCategory.Count != 0)
            //{
            //    menuItems = MovieDatabase.FilterByMPAA(Movies, rating);
            //}
            //if (minCost != null)
            //{
            //    menuItems = MovieDatabase.FilterByMinimumIMDB(Movies, (float)minIMDB);
            //}
            //if (maxCost != null)
            //{
            //    menuItems = MovieDatabase.FilterByMaximumIMDB(Movies, (float)maxIMDB);
            //}
        }

        public MenuModel()
        {
            
        }

        public static List<IMenuItem> Search(List<IMenuItem> items, string term)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in items)
            {
                if(item is Entrees entree)
                {
                    if (entree.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(item);
                    }
                }
                if (item is Side side)
                {
                    if (side.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(item);
                    }
                }
                if (item is Drink drink)
                {
                    if (drink.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(item);
                    }
                }

            }

            return result;
        }
    }
}