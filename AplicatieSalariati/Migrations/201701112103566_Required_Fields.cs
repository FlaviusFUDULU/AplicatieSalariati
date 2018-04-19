namespace AplicatieSalariati.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Required_Fields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SalariatModels", "Nume", c => c.String(nullable: false));
            AlterColumn("dbo.SalariatModels", "Prenume", c => c.String(nullable: false));
            AlterColumn("dbo.SalariatModels", "Functie", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SalariatModels", "Functie", c => c.String());
            AlterColumn("dbo.SalariatModels", "Prenume", c => c.String());
            AlterColumn("dbo.SalariatModels", "Nume", c => c.String());
        }
    }
}
