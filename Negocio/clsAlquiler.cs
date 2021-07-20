using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsAlquiler
    {
        public List<Alquiler> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                var qry = BD.Alquiler.Include("Propiedad").Include("Inquilino").Include("Garante").ToList();
                return qry;
                //return BD.Alquiler.ToList();
            }
        }

        public List<Alquiler> ListarXID(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                var qry = BD.Alquiler.Include("Propiedad").Include("Inquilino").Where(b => b.IDAlquiler == ID).ToList();
                return qry;
                //return BD.Alquiler.Where(b => b.IDAlquiler == ID).ToList();
            }
        }

        public List<Alquiler> ListarXPropied(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                var qry = BD.Alquiler.Include("Inquilino").Where(b => b.IDPropiedad == ID).ToList();
                return qry;
                //return BD.Alquiler.Where(b => b.IDAlquiler == ID).ToList();
            }
        }

        public int CrearModificar(Alquiler alquiler)
        {
            if (alquiler.IDAlquiler == 0)
            {
                return insert(alquiler);
            }
            else
            {
                return update(alquiler);
            }
        }

        private int insert(Alquiler alquiler)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.Alquiler.Add(alquiler);
                return bd.SaveChanges();
            }
        }

        private int update(Alquiler alquiler)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                Alquiler Alq = bd.Alquiler.SingleOrDefault(b => b.IDAlquiler == alquiler.IDAlquiler);

                if (Alq != null)
                {
                    Alq.IDAlquiler = Convert.ToInt64(alquiler.IDAlquiler);
                    Alq.IDPropiedad = alquiler.IDPropiedad;
                    
                    //txtPropiet.Text = itemAlq.Propiedad.Propietario.NombreYApellido;
                    Alq.IDInquilino = alquiler.IDInquilino;
                    Alq.IDGarante1 = alquiler.IDGarante1;
                    Alq.IDGarante2 = alquiler.IDGarante2;
                    Alq.Fecha = alquiler.Fecha;
                    Alq.FechaInicioContrato = alquiler.FechaInicioContrato;
                    Alq.FechaFinContrato = alquiler.FechaFinContrato;
                    Alq.MontoAlquiler = alquiler.MontoAlquiler;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }
    }
}
