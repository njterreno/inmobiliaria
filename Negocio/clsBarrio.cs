using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsBarrio
    {
        public List<Barrio> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Barrio.ToList();
            }
        }

        public List<Barrio> ListarXLoc(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Barrio.Where(b => b.IDLocalidad == ID).ToList();
            }
        }

        public int Crear(Barrio barrio)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.Barrio.Add(barrio);
                return bd.SaveChanges();
            }
        }
    }
}
