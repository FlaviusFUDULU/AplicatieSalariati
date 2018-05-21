namespace AplicatieSalariati.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManagerpartialEchipe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DateEchipeModels",
                c => new
                    {
                        NumeEchipa = c.String(nullable: false, maxLength: 128),
                        NumeManager = c.String(nullable: false),
                        NrTelManager = c.String(nullable: false),
                        EmailEchipa = c.String(),
                        DomeniulDeFunctionare = c.String(nullable: false),
                        Adresa = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.NumeEchipa);
            
            CreateTable(
                "dbo.DateManagerModels",
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
            DropTable("dbo.DateManagerModels");
            DropTable("dbo.DateEchipeModels");
        }
    }
}
