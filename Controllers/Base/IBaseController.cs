using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Base
{
    interface IBaseController<P> where P : class
    {
        void Adicionar(P entity);

        void Editar(P entity);

        void Excluir(int id);

        IList<P> ListarTodos();

        IList<P> ListarPorNome(String Nome);

        P BuscarPorID(int id);


    }
}
