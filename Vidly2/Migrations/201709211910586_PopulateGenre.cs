namespace Vidly2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Name) VALUES ('Comedy')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Action')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Family')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Romance')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
