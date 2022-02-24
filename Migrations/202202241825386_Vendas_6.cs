namespace Vendas_2022._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendas_6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Produto_Id", "dbo.Produtoes");
            DropIndex("dbo.Items", new[] { "Produto_Id" });
            DropColumn("dbo.Items", "Produto_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Produto_Id", c => c.Int());
            CreateIndex("dbo.Items", "Produto_Id");
            AddForeignKey("dbo.Items", "Produto_Id", "dbo.Produtoes", "Id");
        }
    }
}
