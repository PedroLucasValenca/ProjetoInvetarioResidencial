using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Item
    {
        public int ItemID { get; set; }

        public String  NomeItem { get; set; }

        public int Quantidade { get; set; }

        public String Descricao { get; set; }

        public int LocalID { get; set; }

        public int LocalUsoID { get; set; }
    }
}
