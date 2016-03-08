using SnowCrashBank.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SnowCrashBank.DAL
{
    public class ProfileContext : DbContext
    {

        public ProfileContext() : base("ProfileContext")
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Join> Joins { get; set; }
        public DbSet<UserAccount> Accounts { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}