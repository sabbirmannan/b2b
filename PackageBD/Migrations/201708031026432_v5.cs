namespace PackageBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookPackages", "ContactDetails", c => c.String());
            AddColumn("dbo.BookPackages", "ReservationDetails", c => c.String());
            AddColumn("dbo.BookPackages", "DepartingDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.BookPackages", "TourType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookPackages", "TourType");
            DropColumn("dbo.BookPackages", "DepartingDate");
            DropColumn("dbo.BookPackages", "ReservationDetails");
            DropColumn("dbo.BookPackages", "ContactDetails");
        }
    }
}
