namespace PackageBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modify_tpack_entities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TourPackageDetails",
                c => new
                    {
                        TourPackageDetailsID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DayOne = c.String(),
                        DayTwo = c.String(),
                        DayThree = c.String(),
                        DayFour = c.String(),
                        DayFive = c.String(),
                        DaySix = c.String(),
                        DaySeven = c.String(),
                        DayEight = c.String(),
                        DayNine = c.String(),
                        DayTen = c.String(),
                    })
                .PrimaryKey(t => t.TourPackageDetailsID);
            
            AddColumn("dbo.TourPackages", "Highlights", c => c.String());
            AddColumn("dbo.TourPackages", "InclusionExclusion", c => c.String());
            AddColumn("dbo.TourPackages", "SpecialNotes", c => c.String());
            AddColumn("dbo.TourPackages", "TourCostPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.TourPackages", "TourSalesPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.TourPackages", "HotelInUse", c => c.String());
            AddColumn("dbo.TourPackages", "DayWiseItienary", c => c.String());
            AddColumn("dbo.TourPackages", "Allotment", c => c.String());
            AddColumn("dbo.TourPackages", "ValidityDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.TourPackages", "TourPackageDetailsID", c => c.Int());
            AlterColumn("dbo.TourPackages", "HotelStar", c => c.Int(nullable: false));
            CreateIndex("dbo.TourPackages", "TourPackageDetailsID");
            AddForeignKey("dbo.TourPackages", "TourPackageDetailsID", "dbo.TourPackageDetails", "TourPackageDetailsID");
            DropColumn("dbo.TourPackages", "TourPrice");
            DropColumn("dbo.TourPackages", "Itinerary");
            DropColumn("dbo.TourPackages", "Facilities");
            DropColumn("dbo.TourPackages", "FAQ");
            DropColumn("dbo.TourPackages", "Available");
            DropColumn("dbo.TourPackages", "HotelName");
            DropColumn("dbo.TourPackages", "ExpiryDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TourPackages", "ExpiryDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.TourPackages", "HotelName", c => c.String());
            AddColumn("dbo.TourPackages", "Available", c => c.String());
            AddColumn("dbo.TourPackages", "FAQ", c => c.String());
            AddColumn("dbo.TourPackages", "Facilities", c => c.String());
            AddColumn("dbo.TourPackages", "Itinerary", c => c.String());
            AddColumn("dbo.TourPackages", "TourPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.TourPackages", "TourPackageDetailsID", "dbo.TourPackageDetails");
            DropIndex("dbo.TourPackages", new[] { "TourPackageDetailsID" });
            AlterColumn("dbo.TourPackages", "HotelStar", c => c.String());
            DropColumn("dbo.TourPackages", "TourPackageDetailsID");
            DropColumn("dbo.TourPackages", "ValidityDate");
            DropColumn("dbo.TourPackages", "Allotment");
            DropColumn("dbo.TourPackages", "DayWiseItienary");
            DropColumn("dbo.TourPackages", "HotelInUse");
            DropColumn("dbo.TourPackages", "TourSalesPrice");
            DropColumn("dbo.TourPackages", "TourCostPrice");
            DropColumn("dbo.TourPackages", "SpecialNotes");
            DropColumn("dbo.TourPackages", "InclusionExclusion");
            DropColumn("dbo.TourPackages", "Highlights");
            DropTable("dbo.TourPackageDetails");
        }
    }
}
