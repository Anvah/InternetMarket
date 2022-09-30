using Market.Models;
using Market.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Controllers
{
    public class PostingController : Controller
    {
        MarketContext db;
        IWebHostEnvironment _appEnvironment;
        public PostingController(MarketContext context, IWebHostEnvironment appEnvironment)
        {
            db = context;
            _appEnvironment = appEnvironment;
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddAd()
        {
            return View();
        }

        /*public async Task<IActionResult> AddAd(PostingModel pm)
        {
            Ad ad = new Ad { Name = pm.Name, Price = pm.Price, Description = pm.Description, City = pm.City, Category = pm.Category };
            ad.User = await db.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
            
            if (pm.Image != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(pm.Image.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pm.Image.Length);
                }
                // установка массива байтов
                ad.Image = imageData;
            }
            if (ad.User != null)
            {
                db.Ads.Add(ad);
                await db.SaveChangesAsync();
            }    
            return RedirectToAction("Index", "Home");
        }*/
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddAd(PostingModel pm)
        {
            Ad ad = new Ad { Name = pm.Name, Price = pm.Price, Description = pm.Description, City = pm.City, Category = pm.Category };
            ad.DateOfPublication = DateTime.Now;
            ad.User = await db.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);

            if (pm.Image != null)
            {
                string path = "/Files/" + pm.Image.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await pm.Image.CopyToAsync(fileStream);
                }
                ad.Image = path;
            }
            if (ad.User != null)
            {
                db.Ads.Add(ad);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
