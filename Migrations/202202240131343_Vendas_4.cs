namespace Vendas_2022._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendas_4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Pedido_Id", "dbo.Pedidoes");
            DropIndex("dbo.Items", new[] { "Pedido_Id" });
            AddColumn("dbo.Items", "Pedido_Id1", c => c.Int());
            AlterColumn("dbo.Items", "Pedido_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "Pedido_Id1");
            AddForeignKey("dbo.Items", "Pedido_Id1", "dbo.Pedidoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Pedido_Id1", "dbo.Pedidoes");
            DropIndex("dbo.Items", new[] { "Pedido_Id1" });
            AlterColumn("dbo.Items", "Pedido_Id", c => c.Int());
            DropColumn("dbo.Items", "Pedido_Id1");
            CreateIndex("dbo.Items", "Pedido_Id");
            AddForeignKey("dbo.Items", "Pedido_Id", "dbo.Pedidoes", "Id");
        }
    }
}
