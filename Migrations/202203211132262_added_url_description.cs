namespace UrlShortener.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_url_description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urls", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urls", "Description");
        }
    }
}
