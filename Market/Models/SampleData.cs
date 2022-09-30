using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class SampleData
    {
        public static void Initialize(MarketContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User("Иван", "Москва", 4.6f, "+798456782", "ivan_d@gamil.com"),
                    new User("Евгений", "Хабаровск", 5, "+776256621", "jonsonvah@gamil.com"),
                    new User("Jon", "Vashington", 5, "+9876324", "jonVas@gamil.com")




                    );

                context.SaveChanges();
            }
        }
    }
}
