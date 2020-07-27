using System;
using System.Collections.Generic;
using System.Text;

namespace OnTheWay.Models
{
    public class Tolken
    {
        public int Id { get; set; }
        public string Access_tolken { get; set; }
        public string Error_description { get; set; }
        public DateTime Expires_date { get; set; } 
        public Tolken() { }
    }
}
 