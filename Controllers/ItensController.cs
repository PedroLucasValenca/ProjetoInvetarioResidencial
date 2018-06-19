using Controllers.Base;
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
        public void Adicionar(Item entity)
        {
            throw new NotImplementedException();
        }

        public Item BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Item entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Item> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
