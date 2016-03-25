using System;
using System.Collections.Generic;

namespace SnowCrashBank.Models
{
    // Do we add Constructor/Destructor or Functions?
    public class Profile
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        private DateTime _joined = DateTime.Now;
        public DateTime JoinDate
          {
               get { return _joined; }
               set { _joined = value; }
          }
          public string ReturnDateForDisplay
          {
               get { return this._joined.ToString("d"); }
          }

          public virtual ICollection<Join> Joins { set; get; }
    }

}
