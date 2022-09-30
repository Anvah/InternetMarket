using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class AdWithUserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string[] Images { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
