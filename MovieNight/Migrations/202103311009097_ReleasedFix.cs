namespace MovieNight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReleasedFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Released", c => c.DateTime());
            DropColumn("dbo.Movies", "Relased");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Relased", c => c.DateTime());
            DropColumn("dbo.Movies", "Released");
        }
    }
}
