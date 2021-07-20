using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsTipo
    {
        public List<Tipo> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Tipo.ToList();
            }
        }

        public int Crear(Tipo tipo)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.Tipo.Add(tipo);
                return bd.SaveChanges();
            }
        }
    }
}
