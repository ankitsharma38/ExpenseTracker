namespace ExpenseTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expenses", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Expenses", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expenses", "Description", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Expenses", "Title");
        }
    }
}
