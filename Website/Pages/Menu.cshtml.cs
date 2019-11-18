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
        private MenuItems menu { get; }
        
        public void OnGet()
        {
            
        }
        
        public MenuModel()
        {
            
        }

        public Entrees entree = menu.AvailableEntrees;//menu.AvailableEntrees;
        
    }
}