namespace PackageBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TourPackageDetails", "TourPackageID", "dbo.TourPackages");
            DropIndex("dbo.TourPackageDetails", new[] { "TourPackageID" });
            AddColumn("dbo.TourPackages", "DayOne", c => c.String());
            AddColumn("dbo.TourPackages", "DayTwo", c => c.String());
            AddColumn("dbo.TourPackages", "DayThree", c => c.String());
            AddColumn("dbo.TourPackages", "DayFour", c => c.String());
            AddColumn("dbo.TourPackages", "DayFive", c => c.String());
            AddColumn("dbo.TourPackages", "DaySix", c => c.String());
            AddColumn("dbo.TourPackages", "DaySeven", c => c.String());
            AddColumn("dbo.TourPackages", "DayEight", c => c.String());
            AddColumn("dbo.TourPackages", "DayNine", c => c.String());
            AddColumn("dbo.TourPackages", "DayTen", c => c.String());
            DropTable("dbo.TourPackageDetails");
        }
        
        public override void Down()
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
                        TourPackageID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TourPackageDetailsID);
            
            DropColumn("dbo.TourPackages", "DayTen");
            DropColumn("dbo.TourPackages", "DayNine");
            DropColumn("dbo.TourPackages", "DayEight");
            DropColumn("dbo.TourPackages", "DaySeven");
            DropColumn("dbo.TourPackages", "DaySix");
            DropColumn("dbo.TourPackages", "DayFive");
            DropColumn("dbo.TourPackages", "DayFour");
            DropColumn("dbo.TourPackages", "DayThree");
            DropColumn("dbo.TourPackages", "DayTwo");
            DropColumn("dbo.TourPackages", "DayOne");
            CreateIndex("dbo.TourPackageDetails", "TourPackageID");
            AddForeignKey("dbo.TourPackageDetails", "TourPackageID", "dbo.TourPackages", "TourPackageID", cascadeDelete: true);
        }
    }
}
