using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class User
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string City { get; set; }
       public float Rating { get; set; }
       public string Phone { get; set; }
       public string Email { get; set; }
       public string Password { get; set; }
       public bool IsEmailVefi { get; set; }
       public User()
       {

       }
       public User(string name, string city, float rating, string phone, string email)
        {
            Password = "";
            Name = name;
            City = city;
            Rating = rating;
            Phone = phone;
            Email = email;
        }
    }
}
