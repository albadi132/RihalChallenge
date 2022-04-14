using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalChallenge.Models
{
    public class Students
    {
        public int Id { get; set; }
        public int Class_id { get; set; }
        public int Country_id { get; set; }
        public string name { get; set; }
        public DateTime Date_of_birth { get; set; }

        public Classes Classes { get; set; }

        public Countries Countries { get; set; }
    }
}
