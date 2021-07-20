using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsEstado
    {
        public List<Estado> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Estado.ToList();
            }
        }
    }
}
