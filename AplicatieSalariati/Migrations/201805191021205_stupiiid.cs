namespace AplicatieSalariati.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stupiiid : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DateEchipeModels", newName: "DateEchipaModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.DateEchipaModels", newName: "DateEchipeModels");
        }
    }
}
