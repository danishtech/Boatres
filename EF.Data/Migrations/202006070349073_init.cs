namespace EF.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boats",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        BoatName = c.String(nullable: false),
                        CustomerName = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Rentdate = c.DateTime(nullable: false),
                        price = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Boats");
        }
    }
}
