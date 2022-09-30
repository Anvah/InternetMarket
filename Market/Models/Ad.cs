using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Ad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public User User  { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public DateTime DateOfPublication { get; set; }
        //public string Adress { get; set; }

        public Ad()
        {

        }
        public Ad(User user, string name, string category, string images, string description, string city, decimal price)
        {
            User = user;
            Name = name;
            //Images = images;
            Description = description;
            City = city;
            Price = price;
            Category = category;

        }
    }
}
