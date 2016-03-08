﻿using System;
using System.Collections.Generic;

namespace SnowCrashBank.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime JoinDate { get; set; }

        public virtual ICollection<Join> Joins { set; get; }
    }
}