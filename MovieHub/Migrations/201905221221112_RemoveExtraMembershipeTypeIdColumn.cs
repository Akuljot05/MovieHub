namespace MovieHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveExtraMembershipeTypeIdColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "MembershiptTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershiptTypeId", c => c.Byte(nullable: false));
        }
    }
}
