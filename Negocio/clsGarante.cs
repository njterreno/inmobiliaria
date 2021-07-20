using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsGarante
    {
        public List<Garante> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Garante.ToList();
            }
        }

        public List<Garante> LeerGaranteXNombre(string NomYApe)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                BD.Garante.Include("Localidad").ToList();
                return BD.Garante.Where(b => b.NombreYApellido.Contains(NomYApe.ToUpper())).ToList();
            }
        }

        public List<Garante> LeerGarXID(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {

                BD.Garante.Include("Localidad").ToList();
                return BD.Garante.Where(b => b.IDGarante == ID).ToList();
            }
        }

        public List<Garante> LeerGarXDNI(string DNI)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                BD.Garante.Include("Localidad").ToList();
                return BD.Garante.Where(b => b.DNI.Contains(DNI)).ToList();
            }
        }

        //public int Crear(Garante garante)
        //{
        //    using (BDPropertyEntities BD = new BDPropertyEntities())
        //    {
        //        BD.Garante.Add(garante);
        //        return BD.SaveChanges();
        //    }
        //}

        public int CrearModificar(Garante garante)
        {

            if (garante.IDGarante == 0)
                return insert(garante);
            else
                return update(garante);
        }

        private int insert(Garante garante)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.Garante.Add(garante);
                return bd.SaveChanges();
            }
        }

        private int update(Garante garante)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                Garante gar = bd.Garante.SingleOrDefault(b => b.IDGarante == garante.IDGarante);

                if (gar != null)
                {
                    //bd.Garante.Attach(gar);
                    //bd.ApplyCurrentValues("Garante", garante);

                    gar.NombreYApellido = garante.NombreYApellido;
                    gar.DNI = garante.DNI;
                    gar.FechaNac = garante.FechaNac;
                    gar.Telefono = garante.Telefono;
                    gar.CorreoElectronico = garante.CorreoElectronico;
                    gar.Direccion = garante.Direccion;
                    gar.IDLocalidad = garante.IDLocalidad;
                    gar.MontoSueldo = garante.MontoSueldo;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }
    }
}
