using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas_2022._1.Models
{
    public class Pedido
    {

        [Key()]
        public int Id { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        public Pedido()
        {
             this.PedidoItem = new HashSet<Item>();
        }
        //  [ForeignKey("Produto")]
        //   public int ProdutoId { get; set; }

        public double ValorTotal { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<Item> PedidoItem { get; set; }

        public Pedido add()
        {
            var db = new BaseContext();
            db.Pedidos.Add(this);
            db.SaveChanges();
            return this;
        }

        public List<Pedido> getAll()
        {
            var db = new BaseContext();
            return db.Pedidos.ToList();
        }

        public Pedido getPedido(int id)
        {
            var db = new BaseContext();
            return db.Pedidos.Find(id);
        }

        public void remove(int id)
        {
            var db = new BaseContext();
            var p = db.Pedidos.Single(o => o.Id == id);
            db.Pedidos.Remove(p);
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
