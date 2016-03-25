using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnowCrashBank.Models
{
    public class UserAccount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserAccountID { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<Join> Joins { get; set; }
    }
}