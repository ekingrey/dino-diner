using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;


namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        private DinoDiner.Menu.Menu menu = new DinoDiner.Menu.Menu();
        public List<Entrees> entree { get=> menu.AvailableEntrees; }
        public List<Drink> drink { get => menu.AvailableDrinks; }
        public List<Side> side { get => menu.AvailableSides; }
        public List<IMenuItem> combo { get => menu.AvailableMenuItems; }
        public void OnGet()
        {
            
        }
        
        public MenuModel()
        {
            
        }

        //public Entrees entree = menu.AvailableEntrees;//menu.AvailableEntrees;
        
    }
}