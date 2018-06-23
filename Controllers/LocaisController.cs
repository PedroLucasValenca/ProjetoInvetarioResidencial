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
    public class LocaisController : IBaseController<Local>
    {
        Contexto contexto = new Contexto();

        public void Adicionar(Local entity)
        {
            contexto.Locais.Add(entity);
            contexto.SaveChanges();
        }

        public Local BuscarPorID(int id)
        {
            return contexto.Locais.Find(id);
        }

        public void Editar(Local entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Local Locall = BuscarPorID(id);

            if (Locall != null)
            {
                contexto.Locais.Remove(Locall);
                contexto.SaveChanges();
            }
        }

        public IList<Local> ListarPorNome(string Nome)
        {
            return contexto.Locais.Where(loc => loc.NomeLocal == Nome).ToList();
        }

        public IList<Local> ListarTodos()
        {
            return contexto.Locais.ToList();
        }
    }
}
