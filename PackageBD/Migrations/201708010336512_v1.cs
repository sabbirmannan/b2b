namespace PackageBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgentInfoes",
                c => new
                    {
                        AgentInfoID = c.String(nullable: false, maxLength: 128),
                        AgentCode = c.Long(nullable: false, identity: true),
                        AgencyName = c.String(),
                        AgencyEmail = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Designation = c.String(),
                        IATAStatus = c.Int(nullable: false),
                        NatureOfBusiness = c.Int(nullable: false),
                        BusinessType = c.Int(nullable: false),
                        HearBy = c.Int(nullable: false),
                        PreferredCurrency = c.Int(nullable: false),
                        Address = c.String(),
                        PostCode = c.String(),
                        Telephone = c.String(),
                        Mobile = c.String(),
                        Fax = c.String(),
                        CountryId = c.Int(nullable: false),
                        CityID = c.Int(nullable: false),
                        TimeZone = c.Int(nullable: false),
                        Website = c.String(),
                        LogoPath = c.String(),
                        AccountsName = c.String(),
                        AccountsEmail = c.String(),
                        AccountsNumber = c.String(),
                        ReservationName = c.String(),
                        ReservationEmail = c.String(),
                        ReservationNumber = c.String(),
                        ManagementName = c.String(),
                        ManagementEmail = c.String(),
                        ManagementNumber = c.String(),
                        Activation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AgentInfoID)
                .ForeignKey("dbo.AspNetUsers", t => t.AgentInfoID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.AgentInfoID)
                .Index(t => t.CountryId)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        JoiningDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(precision: 7, storeType: "datetime2"),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.SupplierInfoes",
                c => new
                    {
                        SupplierID = c.String(nullable: false, maxLength: 128),
                        SupplierCode = c.Long(nullable: false, identity: true),
                        SupplierName = c.String(),
                        SupplerAddress = c.String(),
                        Postcode = c.String(),
                        Telephone = c.String(),
                        Fax = c.String(),
                        Mobile = c.String(),
                        SupEmail = c.String(),
                        CountryId = c.Int(nullable: false),
                        CityID = c.Int(nullable: false),
                        TimeZone = c.Int(nullable: false),
                        PreferredCurrency = c.Int(nullable: false),
                        SrviceType = c.Int(nullable: false),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        ContactEmail = c.String(),
                        ContactPerson1 = c.String(),
                        ContactPerson2 = c.String(),
                        ReservationEmail = c.String(),
                        CancellationEmail = c.String(),
                        ModificationEmail = c.String(),
                        TechnicalEmail = c.String(),
                        AccountsName = c.String(),
                        AccountsEmail = c.String(),
                        AccountsNumber = c.String(),
                        Activation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.SupplierID)
                .Index(t => t.SupplierID)
                .Index(t => t.CountryId)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityID)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryID);
            
            CreateTable(
                "dbo.BookPackages",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                        City = c.String(),
                        AgentInfo_AgentInfoID = c.String(maxLength: 128),
                        Country_CountryID = c.Int(),
                        TourPackage_TourPackageID = c.Int(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.AgentInfoes", t => t.AgentInfo_AgentInfoID)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .ForeignKey("dbo.TourPackages", t => t.TourPackage_TourPackageID)
                .Index(t => t.AgentInfo_AgentInfoID)
                .Index(t => t.Country_CountryID)
                .Index(t => t.TourPackage_TourPackageID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Queries = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.FileDetails",
                c => new
                    {
                        FileDetailsId = c.Guid(nullable: false),
                        FileName = c.String(),
                        Extension = c.String(),
                        TourPackageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FileDetailsId)
                .ForeignKey("dbo.TourPackages", t => t.TourPackageId, cascadeDelete: true)
                .Index(t => t.TourPackageId);
            
            CreateTable(
                "dbo.TourPackages",
                c => new
                    {
                        TourPackageID = c.Int(nullable: false, identity: true),
                        TourPackageTitle = c.String(),
                        TourPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TourDiscountPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalNights = c.Int(nullable: false),
                        Itinerary = c.String(),
                        Facilities = c.String(),
                        TearmsAndConditions = c.String(),
                        FAQ = c.String(),
                        Available = c.String(),
                        HotelName = c.String(),
                        TourDestination = c.String(),
                        HotelStar = c.String(),
                        Adults = c.Int(nullable: false),
                        Childrens = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DepartingDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ExpiryDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        SuplierInfoId = c.String(),
                        SupplierInfo_SupplierID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TourPackageID)
                .ForeignKey("dbo.SupplierInfoes", t => t.SupplierInfo_SupplierID)
                .Index(t => t.SupplierInfo_SupplierID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.TourPackages", "SupplierInfo_SupplierID", "dbo.SupplierInfoes");
            DropForeignKey("dbo.FileDetails", "TourPackageId", "dbo.TourPackages");
            DropForeignKey("dbo.BookPackages", "TourPackage_TourPackageID", "dbo.TourPackages");
            DropForeignKey("dbo.BookPackages", "Country_CountryID", "dbo.Countries");
            DropForeignKey("dbo.BookPackages", "AgentInfo_AgentInfoID", "dbo.AgentInfoes");
            DropForeignKey("dbo.AgentInfoes", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.AgentInfoes", "CityID", "dbo.Cities");
            DropForeignKey("dbo.AgentInfoes", "AgentInfoID", "dbo.AspNetUsers");
            DropForeignKey("dbo.SupplierInfoes", "SupplierID", "dbo.AspNetUsers");
            DropForeignKey("dbo.SupplierInfoes", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.SupplierInfoes", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.TourPackages", new[] { "SupplierInfo_SupplierID" });
            DropIndex("dbo.FileDetails", new[] { "TourPackageId" });
            DropIndex("dbo.BookPackages", new[] { "TourPackage_TourPackageID" });
            DropIndex("dbo.BookPackages", new[] { "Country_CountryID" });
            DropIndex("dbo.BookPackages", new[] { "AgentInfo_AgentInfoID" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.SupplierInfoes", new[] { "CityID" });
            DropIndex("dbo.SupplierInfoes", new[] { "CountryId" });
            DropIndex("dbo.SupplierInfoes", new[] { "SupplierID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AgentInfoes", new[] { "CityID" });
            DropIndex("dbo.AgentInfoes", new[] { "CountryId" });
            DropIndex("dbo.AgentInfoes", new[] { "AgentInfoID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.TourPackages");
            DropTable("dbo.FileDetails");
            DropTable("dbo.Contacts");
            DropTable("dbo.BookPackages");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.SupplierInfoes");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AgentInfoes");
        }
    }
}
