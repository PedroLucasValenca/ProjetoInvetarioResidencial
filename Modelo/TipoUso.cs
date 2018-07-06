using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TipoUso
    {
        public int TipoUsoID { get; set; }

        public String NomeTipoUso { get; set; }

        public String Descricao { get; set; }

        public override string ToString()
        {
            return NomeTipoUso + " Desc: " + Descricao;
        }
    }
}
