namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Elaqes", "ad", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Elaqes", "email", c => c.String(nullable: false));
            AlterColumn("dbo.Elaqes", "nomre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Elaqes", "mesaj", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Elaqes", "mesaj", c => c.String());
            AlterColumn("dbo.Elaqes", "nomre", c => c.String());
            AlterColumn("dbo.Elaqes", "email", c => c.String());
            AlterColumn("dbo.Elaqes", "ad", c => c.String());
        }
    }
}
