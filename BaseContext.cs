using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas_2022._1.Models;

namespace Vendas_2022._1
{
    //Entity Framework versão: 6.2.0
    public class BaseContext : DbContext
    { 
        public BaseContext() : base("Vendas_DB") { } 
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Item> Itens { get; set; }
    }
}
