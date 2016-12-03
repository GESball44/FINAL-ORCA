namespace ORCA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tickidtoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Responses", "TickId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Responses", "TickId", c => c.String());
        }
    }
}
