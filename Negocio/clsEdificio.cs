using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsEdificio
    {
        public List<Edificio> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Edificio.ToList();
            }
        }

        public List<Edificio> ListarXID(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Edificio.Where(b => b.IDEdificio == ID).ToList();
            }
        }

        public int Crear(Edificio edificio)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.Edificio.Add(edificio);
                return bd.SaveChanges();
            }
        }
    }
}
