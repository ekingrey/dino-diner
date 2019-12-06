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
        public IEnumerable<IMenuItem> menuItems;
        /// <summary>
        /// gets a list of all ingredients items
        /// </summary>
        
        public List<string> ingredients { get => menu.PossibleIngredients; }

        public CretaceousCombo cc;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> ingredientsList { get; set; } = new List<string>();

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        

        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }

        public void OnGet()
        {
            menuItems = menu.AvailableMenuItems;
            
        }

        public void OnPost()
        {
            menuItems = menu.AvailableMenuItems;

            if (search != null)
            {
                
                menuItems = menuItems.Where(item =>
                {
                    if (item is Entrees entree)
                    {   
                        return entree.Description.Contains(search, StringComparison.OrdinalIgnoreCase);
                    }
                    else if (item is Side side)
                    {
                        return side.Description.Contains(search, StringComparison.OrdinalIgnoreCase);
                    }
                    else 
                    {
                        Drink drink = (Drink)item;
                        return drink.Description.Contains(search, StringComparison.OrdinalIgnoreCase);
                    }
                });

            
            }
            if (menuCategory.Count != 0)
            {
                menuItems = menuItems.Where(item =>
                {
                    if (item is Entrees entree)
                    {
                        return (menuCategory.Contains("Entree") || menuCategory.Contains("Combo"));
                    }
                    else if (item is Side side)
                    {
                        return menuCategory.Contains("Side");
                        }
                    else
                    {
                        Drink drink = (Drink)item;
                        return menuCategory.Contains("Drink");
                    }
                });
            }
            if (minimumPrice != null)
            {
                menuItems = menuItems.Where(item => item.Price >= minimumPrice);
            }
            if (maximumPrice != null)
            {
                menuItems = menuItems.Where(item => item.Price <= maximumPrice);
            }
            if (ingredientsList.Count != 0)
            {
                menuItems = menuItems.Where(item =>
                {
                    List<IMenuItem> list = new List<IMenuItem>();
                    foreach (string i in item.Ingredients)
                    {
                        if (ingredientsList.Contains(i))
                            return false;
                    }
                    return true;
                   
                });
            }
        }

        public MenuModel()
        {
            
        }

        
    }
}