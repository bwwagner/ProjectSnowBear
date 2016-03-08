using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SnowCrashBank.Models;

namespace SnowCrashBank.DAL
{
    public class ProfileInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ProfileContext>
    {
        protected override void Seed(ProfileContext context)
        {
            var profiles = new List<Profile>
            {
                new Profile {FirstMidName="Bob",LastName="Scmith",JoinDate=DateTime.Parse("2015-09-01")},
                new Profile {FirstMidName="Sara",LastName="Rage",JoinDate=DateTime.Parse("2015-06-15")},
                new Profile {FirstMidName="John",LastName="Smith",JoinDate=DateTime.Parse("2015-05-20")},
                new Profile {FirstMidName="Jane",LastName="Joe",JoinDate=DateTime.Parse("2015-10-11")},
                new Profile {FirstMidName="Billy Jo",LastName="Bob",JoinDate=DateTime.Parse("2015-03-17")},
                new Profile {FirstMidName="Rachel",LastName="Hatchet",JoinDate=DateTime.Parse("2015-07-22")},
            };
            profiles.ForEach(s => context.Profiles.Add(s));
            context.SaveChanges();

            var accounts = new List<UserAccount>
            {
                new UserAccount {UserAccountID = 1000250, Title = "Banker", Ammount = 0 },
                new UserAccount {UserAccountID = 1000370, Title = "Customer", Ammount = 1000 },
                new UserAccount {UserAccountID = 1000598, Title = "Admin", Ammount = 0 },
                new UserAccount {UserAccountID = 1000176, Title = "Customer", Ammount = 3000 },
                new UserAccount {UserAccountID = 1000020, Title = "Customer", Ammount = 8000 },
                new UserAccount {UserAccountID = 1000999, Title = "Customer", Ammount = 100 },
            };
            accounts.ForEach(s => context.Accounts.Add(s));
            context.SaveChanges();

            var joins = new List<Join>
            {
                new Join {ProfileID = 2, UserAccountID = 1000250, Type = AccountType.B },
                new Join {ProfileID = 3, UserAccountID = 1000370, Type = AccountType.C },
                new Join {ProfileID = 1, UserAccountID = 1000598, Type = AccountType.A },
                new Join {ProfileID = 3, UserAccountID = 1000176, Type = AccountType.C },
                new Join {ProfileID = 3, UserAccountID = 1000020, Type = AccountType.C },
                new Join {ProfileID = 3, UserAccountID = 1000999, Type = AccountType.C },
            };
            joins.ForEach(s => context.Joins.Add(s));
            context.SaveChanges();
        }
    }
}