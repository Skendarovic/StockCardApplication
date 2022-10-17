namespace StockCardApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abcmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockNo = c.String(nullable: false),
                        StockName = c.String(nullable: false),
                        StockCount = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Kdv = c.Int(nullable: false),
                        StockDetails = c.String(nullable: false),
                        WarehouseNo = c.String(nullable: false),
                        RegisterDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StockCards");
        }
    }
}
