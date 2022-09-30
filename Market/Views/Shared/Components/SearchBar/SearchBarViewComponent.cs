using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Views.Shared.Components.SearchBar
{
    public class SearchBarViewComponent: ViewComponent
    {
        public SearchBarViewComponent()
        {

        }
        public IViewComponentResult Invoke(Pager SearchPager)
        {
            return View("Default", SearchPager);
        }
    }
}
