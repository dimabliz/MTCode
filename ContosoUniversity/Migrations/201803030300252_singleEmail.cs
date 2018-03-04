namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class singleEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "AddressInfo_Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "AddressInfo_Email");
        }
    }
}
