﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalChallenge.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public string class_name { get; set; }
        
        public virtual ICollection<Students> Students { get; set; }
    }
}
