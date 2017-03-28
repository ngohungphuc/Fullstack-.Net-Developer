namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into genres(id,Name) values (1,'Jazz')");
            Sql("Insert into genres(id,Name) values (2,'Blues')");
            Sql("Insert into genres(id,Name) values (3,'Rock')");
            Sql("Insert into genres(id,Name) values (4,'Country')");
        }

        public override void Down()
        {
            Sql("Delete from genres where id in (1,2,3,4)");
        }
    }
}