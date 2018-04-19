namespace AplicatieSalariati.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalariatModels",
                c => new
                    {
                        Nr_Crt = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Functie = c.String(),
                        Salar_Negociat = c.Double(nullable: false),
                        Salar_Realizat = c.Double(nullable: false),
                        Vechime = c.Double(nullable: false),
                        Spor = c.Double(nullable: false),
                        Premii_Brute = c.Int(nullable: false),
                        Compensatie = c.Double(nullable: false),
                        Total_Brut = c.Double(nullable: false),
                        Brut_Impozabil = c.Double(nullable: false),
                        Impozit = c.Double(nullable: false),
                        CAS = c.Double(nullable: false),
                        Somaj = c.Double(nullable: false),
                        Sanatate = c.Double(nullable: false),
                        Avans = c.Double(nullable: false),
                        Retineri = c.Double(nullable: false),
                        RestPlata = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Nr_Crt);
            
            CreateTable(
                "dbo.TaxePrestabiliteModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Impozit = c.Double(nullable: false),
                        CAS = c.Double(nullable: false),
                        Somaj = c.Double(nullable: false),
                        Sanatate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaxePrestabiliteModels");
            DropTable("dbo.SalariatModels");
        }
    }
}
