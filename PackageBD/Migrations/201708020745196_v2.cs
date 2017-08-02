namespace PackageBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TourPackages", "TourPackageDetailsID", "dbo.TourPackageDetails");
            DropIndex("dbo.TourPackages", new[] { "TourPackageDetailsID" });
            AddColumn("dbo.TourPackageDetails", "TourPackageID", c => c.Int(nullable: false));
            CreateIndex("dbo.TourPackageDetails", "TourPackageID");
            AddForeignKey("dbo.TourPackageDetails", "TourPackageID", "dbo.TourPackages", "TourPackageID", cascadeDelete: true);
            DropColumn("dbo.TourPackages", "TourPackageDetailsID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TourPackages", "TourPackageDetailsID", c => c.Int());
            DropForeignKey("dbo.TourPackageDetails", "TourPackageID", "dbo.TourPackages");
            DropIndex("dbo.TourPackageDetails", new[] { "TourPackageID" });
            DropColumn("dbo.TourPackageDetails", "TourPackageID");
            CreateIndex("dbo.TourPackages", "TourPackageDetailsID");
            AddForeignKey("dbo.TourPackages", "TourPackageDetailsID", "dbo.TourPackageDetails", "TourPackageDetailsID");
        }
    }
}
