using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Highsay.OrderManagement.Dal
{
    public class OrderMgmtInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<OrderMgmtContext>
    {
        
        protected override void Seed(OrderMgmtContext context)
        {
            var users = new List<User>
            {
            new User{FirstName="Carson",LastName="Alexander"},
            new User{FirstName="Meredith",LastName="Alonso"},
            new User{FirstName="Arturo",LastName="Anand"},
            new User{FirstName="Gytis",LastName="Barzdukas"},
            new User{FirstName="Yan",LastName="Li"},
            new User{FirstName="Peggy",LastName="Justice"},
            new User{FirstName="Laura",LastName="Norman"},
            new User{FirstName="Nino",LastName="Olivetto"}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}