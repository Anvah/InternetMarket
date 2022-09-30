using Market.Models;
using Market.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Views.Shared.Components.SearchBar;
namespace Market.Controllers
{
    public class HomeController : Controller
    {
        MarketContext db;
        public HomeController(MarketContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index(string searchString = "", int page = 1, int pageSize = 2, SortState sortType = SortState.RatingSort)
         {
            /*List<AdWithUserModel> data = new List<AdWithUserModel>();
            List<Ad> ads = await db.Ads.ToListAsync();
            foreach(Ad item in ads)
            {
                User user = await  db.Users.FirstOrDefaultAsync(u => u.Id == item.User.Id);
                data.Add(new AdWithUserModel() { })
            }*/
            if (page < 1) 
                page = 1;
            int pgSkip = (page - 1) * pageSize;
            var ads = db.Ads.Include(a => a.User);
            if (!String.IsNullOrEmpty(searchString))
            {
                ads = ads.Where(s => s.Name.Contains(searchString) || s.Description.Contains(searchString) || s.Category.Contains(searchString)).Include(a => a.User);
            }
            switch(sortType)
            {
                case SortState.PiceSort:
                    ads = ads.OrderBy(a => a.Price).Include(a => a.User);
                    break;
                case SortState.DateSort:
                    ads = ads.OrderBy(a => a.DateOfPublication).Include(a => a.User);
                    break;
                case SortState.RatingSort:
                    ads = ads.OrderBy(a => a.User.Rating).Include(a => a.User);
                    break;

            }
            var listAds = ads.Skip(pgSkip).Take(pageSize);
            Pager SearchPager = new Pager(ads.Count(), page, pageSize) { Action = "Index", Controller = "Home", SearchString = searchString, SortType = Convert.ToInt32(sortType) };
            ViewBag.SearchPager = SearchPager;
            return View( await listAds.Where(a => a.User != null).AsNoTracking().ToListAsync());
         }

        [HttpPost]
        public IActionResult AdPage(int AdId)
        {
          //  List<Ad> ads = await db.Ads.ToListAsync();
            //Ad ad = ads.FirstOrDefault(a => a.Id == AdId);
            return  RedirectToAction("AdPage", "Ad", new { AdId });
           // return RedirectToAction("Test", "Home", new { ad });
        }
        public string Test(Ad ad)
        {
            return ad.Id.ToString();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
