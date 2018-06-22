using Controllers.Base;
using Controllers.DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ItensController : IBaseController<Item>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Item entity)
        {
            contexto.Items.Add(entity);
            contexto.SaveChanges();
        }

        public Item BuscarPorID(int id)
        {
            return contexto.Items.Find(id);
        }

        public void Editar(Item entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Item item = BuscarPorID(id);

            if (item != null)
            {
                contexto.Items.Remove(item);
            }

        }

        public IList<Item> ListarTodos()
        {
            return contexto.Items.ToList();
        }
    }
}
