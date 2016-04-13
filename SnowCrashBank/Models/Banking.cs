using System;
using System.Collections.Generic;

namespace SnowCrashBank.Models
{
    // User money accounts
    public class Banking
    {
        public int ID { get; set; }
        public double checkingAccount { get; set; }
        public double reserveAccount { get; set; }
        public double savingsAccount { get; set; }
        
    }
}