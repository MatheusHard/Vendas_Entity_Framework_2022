using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas_2022._1.Models
{
    public class Item
    {
        [Key()]
        public int Id { get; set; }
        public double? Valor { get; set; }
        public int Quantidade { get; set; }
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        //public virtual Pedido Pedido { get; set; }
        //public virtual Produto Produto { get; set; }

        public void add()
        {
            var db = new BaseContext();
            db.Itens.Add(this);
            db.SaveChanges();
        }

        public List<Item> getAll()
        {
            var db = new BaseContext();
            return db.Itens.ToList();
        }

        public Item getItem(int id)
        {
            var db = new BaseContext();
            return db.Itens.Find(id);
        }

        public List<Item> getItens(int id)
        {
            var db = new BaseContext();
            return db.Itens.Find(id).getAll();
        }


        public void remove(int id)
        {
            var db = new BaseContext();
            var itens = db.Itens.Single(o => o.Id == id);
            db.Itens.Remove(itens);
            db.SaveChanges();
        }
        public void update()
        {
            var db = new BaseContext();
            db.Entry(this).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

    }
}
