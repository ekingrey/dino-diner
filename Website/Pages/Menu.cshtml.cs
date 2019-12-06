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
                //menuItems = FilterByIngredients(menuItems, ingredientsList);
                menuItems = menuItems.Where(item =>
                {
                    
                    if (item is Entrees entree)
                    {
                        foreach (string i in entree.Ingredients)
                        {
                            return ingredientsList.Contains(i);
                        }
                            
                    }
                    else if (item is Side side)
                    {
                        foreach (string i in side.Ingredients)
                        {
                            return ingredientsList.Contains(i);
                        }
                    }
                    else
                    {
                        Drink drink = (Drink)item;
                        foreach (string i in drink.Ingredients)
                        {
                            return ingredientsList.Contains(i);
                        }
                    }
                });
            }
        }

        public MenuModel()
        {
            
        }

        /// <summary>
        /// finds all menu items that mathc the search constraint
        /// </summary>
        /// <param name="items"> the list in menu items</param>
        /// <param name="term"> the search term</param>
        /// <returns></returns>
        //public static List<IMenuItem> Search(List<IMenuItem> items, string term)
        //{
        //    List<IMenuItem> result = new List<IMenuItem>();

        //    foreach (IMenuItem item in items)
        //    {
        //        if(item is Entrees entree)
        //        {
        //            if (entree.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
        //            {
        //                result.Add(item);
        //            }
        //        }
        //        if (item is Side side)
        //        {
        //            if (side.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
        //            {
        //                result.Add(item);
        //            }
        //        }
        //        if (item is Drink drink)
        //        {
        //            if (drink.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
        //            {
        //                result.Add(item);
        //            }
        //        }

        //    }

        //    return result;
        //}

        /// <summary>
        /// filters by the type of menu item(combo, entree, drink, side)
        /// </summary>
        /// <param name="items">teh list of menu items</param>
        /// <param name="catagory">teh search term</param>
        /// <returns></returns>
        //public static List<IMenuItem> FilterByType(List<IMenuItem> items, List<string> catagory)
        //{
        //    List<IMenuItem> result = new List<IMenuItem>();

        //    foreach (IMenuItem item in items)
        //    {
        //        if (item is Entrees && (catagory.Contains("Entree") || catagory.Contains("Combo")))
        //        {
                    
        //                result.Add(item);
                   
        //        }
        //        if (item is Side  && catagory.Contains("Side"))
        //        {
                    
        //                result.Add(item);
                    
        //        }
        //        if (item is Drink  && catagory.Contains("Drink"))
        //        {
                    
        //                result.Add(item);
                    
        //        }

        //    }
        //    return result;
        //}

        /// <summary>
        /// filters by a minimum cost
        /// </summary>
        /// <param name="items">list of menu items</param>
        /// <param name="minCost">min cost</param>
        /// <returns></returns>
        //public static List<IMenuItem> FilterByMinimumCost(List<IMenuItem> items, float minCost)
        //{
        //    List<IMenuItem> result = new List<IMenuItem>();

        //    foreach (IMenuItem item in items)
        //    {
        //        if (item.Price >= minCost)
        //        {
        //            result.Add(item);
        //        }

        //    }
        //    return result;
        //}

        /// <summary>
        /// filters by a maximum cost
        /// </summary>
        /// <param name="items">list of menu items</param>
        /// <param name="maxCost">max cost</param>
        /// <returns></returns>
        //public static List<IMenuItem> FilterByMaximumCost(List<IMenuItem> items, float maxCost)
        //{
        //    List<IMenuItem> result = new List<IMenuItem>();

        //    foreach (IMenuItem item in items)
        //    {
        //        if (item.Price <= maxCost)
        //        {
        //            result.Add(item);
        //        }

        //    }
        //    return result;
        //}

        /// <summary>
        /// filters by ingredients
        /// </summary>
        /// <param name="items">a list of menu items</param>
        /// <param name="list">list of constraints</param>
        /// <returns></returns>
        //public static List<IMenuItem> FilterByIngredients(List<IMenuItem> items, List<string> list)
        //{
        //    List<IMenuItem> result = new List<IMenuItem>(items);

        //    foreach (IMenuItem item in items)
        //    {
        //        if (item is Entrees e)
        //        {
        //            foreach(string i in e.Ingredients)
        //            {
        //                if (list.Contains(i))
        //                {
        //                    result.Remove(item);
        //                }
        //            }
                    

        //        }
        //        if (item is Drink d)
        //        {
        //            foreach (string i in d.Ingredients)
        //            {
        //                if (list.Contains(i))
        //                {
        //                    result.Remove(item);
        //                }
        //            }


        //        }
        //        if (item is Side s)
        //        {
        //            foreach (string i in s.Ingredients)
        //            {
        //                if (list.Contains(i))
        //                {
        //                    result.Remove(item);
        //                }
        //            }


        //        }
                

        //    }
        //    return result;
        //}
    }
}