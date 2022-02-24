namespace Vendas_2022._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendas_3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Pedido_Id", c => c.Int());
            CreateIndex("dbo.Items", "Pedido_Id");
            AddForeignKey("dbo.Items", "Pedido_Id", "dbo.Pedidoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Pedido_Id", "dbo.Pedidoes");
            DropIndex("dbo.Items", new[] { "Pedido_Id" });
            DropColumn("dbo.Items", "Pedido_Id");
        }
    }
}
