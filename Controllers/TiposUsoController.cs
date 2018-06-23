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
    public class TiposUsoController : IBaseController<TipoUso>
    {
        Contexto contexto = new Contexto();

        public void Adicionar(TipoUso entity)
        {
            contexto.TiposUsos.Add(entity);
            contexto.SaveChanges();
        }

        public TipoUso BuscarPorID(int id)
        {
            return contexto.TiposUsos.Find(id);
        }

        public void Editar(TipoUso entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            TipoUso tipUs = BuscarPorID(id);

            if (tipUs != null)
            {
                contexto.TiposUsos.Remove(tipUs);
                contexto.SaveChanges();
            }
        }

        public IList<TipoUso> ListarPorNome(string Nome)
        {
            return contexto.TiposUsos.Where(tipoUs => tipoUs.NomeTipoUso == Nome).ToList();
        }

        public IList<TipoUso> ListarTodos()
        {
            return contexto.TiposUsos.ToList();
        }
    }
}
