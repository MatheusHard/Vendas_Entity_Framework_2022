using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas_2022._1.Models
{
    public class Produto
    {

        [Key()]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Descricao { get; set; }
        public int Valor { get; set; }

        //public virtual ICollection<Item> PedidoItem { get; set; }

       /* public Produto()
        {
            this.PedidoItem = new HashSet<Item>();
        }*/

        public void add()
        {
            var db = new BaseContext();
            db.Produtos.Add(this);
            db.SaveChanges();
        }

        public List<Produto> getAll()
        {
            var db = new BaseContext();
            return db.Produtos.ToList();
        }

        public Produto getProduto(int id)
        {
            var db = new BaseContext();
            return db.Produtos.Find(id);
        }

        public void remove(int id)
        {
            var db = new BaseContext();
            var p = db.Produtos.Single(o => o.Id == id);
            db.Produtos.Remove(p);
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