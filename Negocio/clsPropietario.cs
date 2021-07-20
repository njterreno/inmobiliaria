using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsPropietario
    {
        public List<Propietario> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Propietario.ToList();
            }
        }

        public List<Propietario> LeerPropietXNombre(string NomYApe)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                BD.Propietario.Include("Localidad").ToList();
                return BD.Propietario.Where(b => b.NombreYApellido.Contains(NomYApe.ToUpper())).ToList();
            }
        }

        public List<Propietario> LeerPropietXID(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                BD.Propietario.Include("Localidad").ToList();
                return BD.Propietario.Where(b => b.IDPropietario == ID).ToList();
            }
        }

        public List<Propietario> ListarXPropied(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Propietario.Where(b => b.IDPropietario == ID).ToList();
            }
        }

        public List<Propietario> LeerPropietXDNI(string DNI)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                BD.Propietario.Include("Localidad").ToList();
                return BD.Propietario.Where(b => b.DNI.Contains(DNI)).ToList();
            }
        }

        //public int Crear(Propietario propietario)
        //{
        //    using (BDPropertyEntities BD = new BDPropertyEntities())
        //    {
        //        BD.Propietario.Add(propietario);
        //        return BD.SaveChanges();
        //    }
        //}

        public int CrearModificar(Propietario propietario)
        {

            if (propietario.IDPropietario == 0)
                return insert(propietario);
            else
                return update(propietario);
        }

        private int insert(Propietario propietario)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.Propietario.Add(propietario);
                return bd.SaveChanges();
            }
        }

        private int update(Propietario propietario)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                Propietario prop = bd.Propietario.SingleOrDefault(b => b.IDPropietario == propietario.IDPropietario);

                if (prop != null)
                {
                    //bd.Propietario.Attach(prop);
                    //bd.ApplyCurrentValues("Propietario", propietario);

                    prop.NombreYApellido = propietario.NombreYApellido;
                    prop.DNI = propietario.DNI;
                    prop.FechaNac = propietario.FechaNac;
                    prop.Telefono = propietario.Telefono;
                    prop.CorreoElectronico = propietario.CorreoElectronico;
                    prop.Direccion = propietario.Direccion;
                    prop.IDLocalidad = propietario.IDLocalidad;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }


    }
}
