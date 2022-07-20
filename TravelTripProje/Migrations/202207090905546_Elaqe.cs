namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Elaqe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elaqes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ad = c.String(),
                        email = c.String(),
                        nomre = c.String(),
                        mesaj = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Elaqes");
        }
    }
}
