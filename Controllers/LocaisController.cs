using Controllers.Base;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class LocaisController : IBaseController<Local>
    {
        public void Adicionar(Local entity)
        {
            throw new NotImplementedException();
        }

        public Local BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Local entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Local> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
