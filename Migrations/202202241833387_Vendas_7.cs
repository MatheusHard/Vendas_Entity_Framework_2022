namespace Vendas_2022._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendas_7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ProdutoId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "ProdutoId");
        }
    }
}
