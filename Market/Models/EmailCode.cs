using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class EmailCode
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Code { get; set; }
    }
}
