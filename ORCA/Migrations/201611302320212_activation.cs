namespace ORCA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class activation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experts", "Activated", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Experts", "Activated");
        }
    }
}
