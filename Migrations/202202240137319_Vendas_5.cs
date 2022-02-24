namespace Vendas_2022._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendas_5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Pedido_Id1", "dbo.Pedidoes");
            DropIndex("dbo.Items", new[] { "Pedido_Id1" });
            RenameColumn(table: "dbo.Items", name: "Pedido_Id1", newName: "PedidoId");
            AlterColumn("dbo.Items", "PedidoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "PedidoId");
            AddForeignKey("dbo.Items", "PedidoId", "dbo.Pedidoes", "Id", cascadeDelete: true);
            DropColumn("dbo.Items", "Pedido_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Pedido_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Items", "PedidoId", "dbo.Pedidoes");
            DropIndex("dbo.Items", new[] { "PedidoId" });
            AlterColumn("dbo.Items", "PedidoId", c => c.Int());
            RenameColumn(table: "dbo.Items", name: "PedidoId", newName: "Pedido_Id1");
            CreateIndex("dbo.Items", "Pedido_Id1");
            AddForeignKey("dbo.Items", "Pedido_Id1", "dbo.Pedidoes", "Id");
        }
    }
}
