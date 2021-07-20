using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsProvincia
    {
        public List<Provincia> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Provincia.ToList();
            }
        }
    }
}
