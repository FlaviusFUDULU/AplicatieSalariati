namespace AplicatieSalariati.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smallchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DateAngajatModels", "Echipa", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DateAngajatModels", "Echipa");
        }
    }
}
