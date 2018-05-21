namespace AplicatieSalariati.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class angajatready : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DateAngajatModels",
                c => new
                    {
                        CNP = c.String(nullable: false, maxLength: 128),
                        Nume = c.String(nullable: false),
                        Prenume = c.String(nullable: false),
                        Email = c.String(),
                        Functie = c.String(nullable: false),
                        Adresa = c.String(nullable: false),
                        TelefonPersonal = c.String(),
                        TelefonServici = c.String(),
                    })
                .PrimaryKey(t => t.CNP);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DateAngajatModels");
        }
    }
}
