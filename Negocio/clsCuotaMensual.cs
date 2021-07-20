using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.Entity;

namespace Negocio
{
    public class clsCuotaMensual
    {
        public List<CuotaMensual> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                var qry = BD.CuotaMensual.ToList();
                return qry;
                //return BD.Alquiler.ToList();
            }
        }

        public List<CuotaMensual> ListarXIDAlq(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                var qry = BD.CuotaMensual.Where(b => b.IDAlquiler == ID).ToList();
                return qry;
                //return BD.Alquiler.Where(b => b.IDAlquiler == ID).ToList();
            }
        }

        public List<CuotaMensual> ListarXID(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                var qry = BD.CuotaMensual.Where(b => b.IDCuotaMensual == ID).ToList();
                return qry;
                //return BD.Alquiler.Where(b => b.IDAlquiler == ID).ToList();
            }
        }

        public int Crear(CuotaMensual cuotaMensual)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.CuotaMensual.Add(cuotaMensual);
                return bd.SaveChanges();
            }
        }

        public int Montos(CuotaMensual cuotaMensual)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                CuotaMensual CM = bd.CuotaMensual.SingleOrDefault(b => b.IDCuotaMensual == cuotaMensual.IDCuotaMensual);

                if (CM != null)
                {
                    CM.MontoRecargo = cuotaMensual.MontoRecargo;
                    CM.MontoTotal = cuotaMensual.MontoTotal;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public int Pago(CuotaMensual cuotaMensual)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                CuotaMensual CM = bd.CuotaMensual.SingleOrDefault(b => b.IDCuotaMensual == cuotaMensual.IDCuotaMensual);

                if (CM != null)
                {
                    CM.Pago = cuotaMensual.Pago;
                    CM.FechaPago = cuotaMensual.FechaPago;
                    CM.MontoRecargo = cuotaMensual.MontoRecargo;
                    CM.MontoTotal = cuotaMensual.MontoTotal;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }
    }
}

