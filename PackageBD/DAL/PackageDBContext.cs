using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PackageBD.Areas.Supplier.Models;
using PackageBD.Areas.Agent.Models;
using PackageBD.Models;
using System;

namespace PackageBD.DAL
{
    //
    /// <summary>
    /// role class
    /// </summary>
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }
        public string Description { get; set; }
    }
    //
    /// <summary>
    /// user class
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public DateTime JoiningDate { get; set; }
        public virtual AgentInfo AgentInfo { get; set; }
        public virtual SupplierInfo SupplierInfo { get; set; }
    }

    public class PackageDBContext : IdentityDbContext<ApplicationUser>
    {
        public PackageDBContext()
            : base("DbConnection", throwIfV1Schema: false)
        {
            
        }
        #region DbSet
        //DbSet start
        public DbSet<AgentInfo> AgentInfos { get; set; }
        public DbSet<SupplierInfo> SupplierInfos { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<TourPackage> TourPackages { get; set; }
        public DbSet<FileDetail> FileDetail { get; set; }
        public DbSet<BookPackage> BookPackages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        //DbSet end
        #endregion

        public static PackageDBContext Create()
        {
            return new PackageDBContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ApplicationUser>().ToTable("Users_tbl", "Account").Property(p => p.Id).HasColumnName("UserID");
            //modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles_tbl", "Account");
            //modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins_tbl", "Account");
            //modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims_tbl", "Account");
            //modelBuilder.Entity<IdentityRole>().ToTable("Roles_tbl", "Account");

            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
        }
        //Introducing FOREIGN KEY constraint 'FK_dbo.Cities_dbo.Countries_CountryID' on table 'Cities' may cause cycles or multiple cascade paths.Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
        //Could not create constraint or index.See previous errors.

    }

}