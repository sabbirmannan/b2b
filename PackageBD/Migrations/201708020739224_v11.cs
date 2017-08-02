namespace PackageBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TourPackages", "SuplierInfoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TourPackages", "SuplierInfoId", c => c.String());
        }
    }
}
