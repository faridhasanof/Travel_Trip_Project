namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakanMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mekans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        sekil = c.String(),
                        yazi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mekans");
        }
    }
}
