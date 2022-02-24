using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas_2022._1.Models
{
    public class Cliente
    {
        //81dc9bdb52d04dc20036dbd8313ed055 (1234)

        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Perfil { get; set; }
        //public virtual Pedido Pedido { get; set; }

        public void add()
        {
            var db = new BaseContext();
            db.Clientes.Add(this);
            db.SaveChanges();
        }

        public List<Cliente> getAll()
        {
            var db = new BaseContext();
            return db.Clientes.ToList();
        }

        public Cliente getCliente(int id)
        {
            var db = new BaseContext();
            return db.Clientes.Find(id);
        }

        public void remove(int id)
        {
            var db = new BaseContext();
            var cliente = db.Clientes.Single(o => o.Id == id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
        }
        public void update()
        {
            var db = new BaseContext();
            db.Entry(this).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }


        public Cliente getClientePorLoginSenha(string login, string password)
        {
            var db = new BaseContext();
            return db.Clientes.FirstOrDefault(cliente => cliente.Login == login && cliente.Password == password);



        }

    }
}
