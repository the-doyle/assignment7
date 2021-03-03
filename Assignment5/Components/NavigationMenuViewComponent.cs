using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent 
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
                
        }
    }
}
