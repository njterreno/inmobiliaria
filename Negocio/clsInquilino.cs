using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsInquilino
    {
        public List<Inquilino> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                return BD.Inquilino.Include("Localidad").ToList();
            }
        }

        public List<Inquilino> LeerInquilinoXNombre(string NomYApe)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                BD.Inquilino.Include("Localidad").ToList();
                return BD.Inquilino.Where(b => b.NombreYApellido.Contains(NomYApe.ToUpper())).ToList();
            }
        }

        public List<Inquilino> LeerInqXID(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {

                BD.Inquilino.Include("Localidad").ToList();
                return BD.Inquilino.Where(b => b.IDInquilino == ID).ToList();
            }
        }

        public List<Inquilino> LeerInqXDNI(string DNI)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {

                BD.Inquilino.Include("Localidad").ToList();
                return BD.Inquilino.Where(b => b.DNI.Contains(DNI)).ToList();
            }
        }

        public List<Inquilino> Buscar(string NomYApe, string DNI, string Localidad)
        {
            IQueryable<Inquilino> lst;

            BDPropertyEntities bd = null;

            bd = new BDPropertyEntities();

            lst = from x in bd.Inquilino where x.NombreYApellido.Contains(NomYApe) & x.DNI.Contains(DNI) & x.Localidad.Nombre.Contains(Localidad) select x;

            return lst.ToList();
            
            ////consulta
            //var resultadoInquilinos = from inquilinos in bd.Inquilino select inquilinos;

            ////filtramos
            ////if (!string.IsNullOrEmpty(NomYApe))
            ////{
            ////    resultadoInquilinos = resultadoInquilinos.Where(elemento => elemento.NombreYApellido.Trim().ToUpper() == NomYApe);
            ////}

            //if (!string.IsNullOrEmpty(NomYApe) & !string.IsNullOrEmpty(DNI) & !string.IsNullOrEmpty(Localidad))
            //{
            //    resultadoInquilinos = resultadoInquilinos.Where(i => i.NombreYApellido.Contains(NomYApe) & i.DNI.Contains(DNI) & i.Localidad.Nombre == Localidad);
            //}
            //else if (!string.IsNullOrEmpty(NomYApe) & !string.IsNullOrEmpty(DNI))
            //{ 
            //}
            //else if (!string.IsNullOrEmpty(NomYApe) & !string.IsNullOrEmpty(Localidad))
            //{ 
            //}
            //else if ()

            ////if (!string.IsNullOrEmpty(DNI))
            ////{
            ////    resultadoInquilinos = resultadoInquilinos.Where(elemento => elemento.DNI.Trim() == DNI);
            ////}

            ////if (!string.IsNullOrEmpty(Localidad))
            ////{
            ////    resultadoInquilinos = resultadoInquilinos.Where(elemento => elemento.Localidad.Nombre.Trim().ToUpper() == Localidad);
            ////}

            //return resultadoInquilinos.ToList();
        }

        //public int Crear(Inquilino inquilino)
        //{
        //    using (BDPropertyEntities BD = new BDPropertyEntities())
        //    {
        //        BD.Inquilino.Add(inquilino);
        //        return BD.SaveChanges();
        //    }
        //}

        //public int Actualizar(Inquilino inquilino)
        //{
        //    using (var bd = new BDPropertyEntities())
        //    {  
        //        var result = bd.Inquilino.SingleOrDefault(b => b.IDInquilino == inquilino.IDInquilino);
        //        if (result != null)
        //        {
        //            //result.NombreYApellido = inquilino.NombreYApellido;
        //            //result.DNI = inquilino.DNI;
        //            //result.Telefono = inquilino.Telefono;

        //            //bd.Entry(inquilino).State = System.Data.Entity.EntityState.Modified;
        //            bd.Inquilino.Attach(result);
        //            bd.Entry(inquilino).State = System.Data.Entity.EntityState.Modified;
        //            //bd.Entry(inquilino).State =
        //            //bd.Entry(socio).State.Modified; //VER POR QUÉ NO ANDA
        //            return bd.SaveChanges();
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //}

        public int CrearModificar(Inquilino inquilino)
        {

            if (inquilino.IDInquilino == 0)
                return insert(inquilino);
            else
                return update(inquilino);
        }

        private int insert(Inquilino inquilino)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.Inquilino.Add(inquilino);
                return bd.SaveChanges();
            }
        }

        private int update(Inquilino inquilino)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                Inquilino inq = bd.Inquilino.SingleOrDefault(b => b.IDInquilino == inquilino.IDInquilino);

                if (inq != null)
                {
                    //var sourceAcc = new Account { AccountID = account.AccountID });
                    //odc.Entry(account).CurrentValues.SetValues(sourceAcc);
                    
                    //odc.Accounts.Attach(new Account { AccountID = account.AccountID });
                    //((IObjectContextAdapter)odc).ObjectContext
                    //    .ApplyCurrentValues("Accounts", account);
                    //odc.SaveChanges();

                    //bd.Inquilino.Attach(new Inquilino { IDInquilino = inquilino.IDInquilino });
                   
                    //bd.Inquilino.Attach(inq);
                    //bd.ApplyCurrentValues("Inquilino", inquilino);

                    inq.NombreYApellido = inquilino.NombreYApellido;
                    inq.DNI = inquilino.DNI;
                    inq.FechaNac = inquilino.FechaNac;
                    inq.Telefono = inquilino.Telefono;
                    inq.CorreoElectronico = inquilino.CorreoElectronico;
                    inq.Direccion = inquilino.Direccion;
                    inq.IDLocalidad = inquilino.IDLocalidad;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }

        //using (BDClubSociosEntities bd = new BDClubSociosEntities())
        //    {
        //        Socio c = bd.Socio.SingleOrDefault(b => b.IDSocio == socio.IDSocio);

        //        if (c != null)
        //        {
        //            c.IDSocio = socio.IDSocio;
        //            c.Nombre = socio.Nombre;
        //            c.Apellido = socio.Apellido;
        //            c.DNI = socio.DNI;

        //            return bd.SaveChanges();
        //        }
        //        else
        //            return 0;

        //        //if (select(socio.IDSocio) != null)
        //        //{
        //        //    bd.Socio.Attach(socio);
        //        //    //bd.Entry(socio).State.Modified; //VER POR QUÉ NO ANDA
        //        //    return bd.SaveChanges();
        //        //}

        //        //return 0;
        //    }
        //}
    }
}
