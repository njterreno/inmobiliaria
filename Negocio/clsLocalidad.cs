using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsLocalidad
    {
        public List<Localidad> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Localidad.ToList();
            }
        }

        public List<Localidad> ListarXID(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Localidad.Where(b => b.IDLocalidad == ID).ToList();
            }
        }

        public int CrearModificar(Localidad localidad)
        {
            if (localidad.IDLocalidad == 0)
            {
                return insert(localidad);
            }
            else
            {
                return update(localidad);
            }
        }

        private int insert(Localidad localidad)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.Localidad.Add(localidad);
                return bd.SaveChanges();
            }
        }

        private int update(Localidad localidad)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                Localidad loc = bd.Localidad.SingleOrDefault(b => b.IDLocalidad == localidad.IDLocalidad);

                if (loc != null)
                {
                    loc.IDLocalidad = localidad.IDLocalidad;
                    loc.Nombre = localidad.Nombre;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }
    }
}
