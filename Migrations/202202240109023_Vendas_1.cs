namespace Vendas_2022._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendas_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cpf = c.String(),
                        Telefone = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Perfil = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
