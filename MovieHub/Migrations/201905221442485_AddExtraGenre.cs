namespace MovieHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExtraGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
