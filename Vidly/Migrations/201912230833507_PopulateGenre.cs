namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Horror')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
