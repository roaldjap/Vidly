namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_ReleaseDate_CreatedDate_StocksToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Movies", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NoOfStocks", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NoOfStocks");
            DropColumn("dbo.Movies", "CreatedAt");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
