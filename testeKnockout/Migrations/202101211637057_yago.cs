namespace testeKnockout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yago : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
