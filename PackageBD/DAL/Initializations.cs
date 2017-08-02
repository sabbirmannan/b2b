using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PackageBD.DAL
{
    public class Initializations
    {
        #region seed values for role and user
        //protected override void Seed(SecurityModule.DataContexts.IdentityDb context)
        //{
        //    if (!context.Roles.Any(r => r.Name == "AppAdmin"))
        //    {
        //        var store = new RoleStore<IdentityRole>(context);
        //        var manager = new RoleManager<IdentityRole>(store);
        //        var role = new IdentityRole { Name = "AppAdmin" };

        //        manager.Create(role);
        //    }

        //    if (!context.Users.Any(u => u.UserName == "founder"))
        //    {
        //        var store = new UserStore<ApplicationUser>(context);
        //        var manager = new UserManager<ApplicationUser>(store);
        //        var user = new ApplicationUser { UserName = "founder" };

        //        manager.Create(user, "ChangeItAsap!");
        //        manager.AddToRole(user.Id, "AppAdmin");
        //    }
        //}
        #endregion
    }
}