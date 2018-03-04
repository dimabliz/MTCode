namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addgpaformat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "GpaFormatted", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "GpaFormatted");
        }
    }
}
