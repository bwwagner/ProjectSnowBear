using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SnowCrashBank.Models
{
    // User money accounts
    public class Banking
    {
        public int ID { get; set; }
        public string userName { get; set; }
        public double Balance { get; set; }
          // Required for Transfer Page until full changes are implemented
          public double checkingAccount { get; set; }  
     }

    public class depositViewModel
    {
        [Required]
        public string userName { get; set; }

        [Required]
        public double Amount { get; set; }

        [Display(Name = "Account Balance")]
        public double Balance { get; set; }
    }

}