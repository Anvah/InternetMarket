using Market.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Controllers
{
    public class YourAdsController : Controller
    {
        MarketContext db;
        public YourAdsController(MarketContext context)
        {
            db = context;
        }
        [Authorize]
        public async Task<IActionResult> List()
        {
            List<Ad> ads = await db.Ads.Include(a => a.User).ToListAsync();
            return View(ads.Where(a => a.User != null && a.User.Email == User.Identity.Name));
        }

        [HttpPost]
        public async Task<IActionResult> List(int AdId)
        {
            Ad ad = await db.Ads.FirstOrDefaultAsync(a => a.Id == AdId);
            db.Remove(ad);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
