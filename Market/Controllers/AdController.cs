using Market.Models;
using Market.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Controllers
{
    public class AdController : Controller
    {
        MarketContext db;
        public AdController(MarketContext context)
        {
            db = context;
        }
        public async Task<IActionResult> AdPage(int AdId)
        {
            Ad ad = await db.Ads.Include(a => a.User).FirstOrDefaultAsync(a => a.Id == AdId);
            return View(ad);
        }
    }
}
