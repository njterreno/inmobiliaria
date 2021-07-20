using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsPropiedad
    {
        public List<Propiedad> Listar()
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                var qry = BD.Propiedad.Include("Edificio").Include("Barrio").Include("Tipo").ToList();
                return qry;
                
                //BD.Propiedad.Include("Edificio");
                //return BD.Propiedad.ToList();
            }
        }

        public List<Propiedad> ListarXID(Int64 ID)
        {
            using (BDPropertyEntities BD = new BDPropertyEntities())
            {
                //var qry = BD.Propiedad.Where(b => b.IDPropiedad == ID).Include("Edificio").Include("Barrio").Include("Tipo").ToList();
                var qry = BD.Propiedad.Include("Edificio").Include("Barrio").Include("Tipo").Where(b => b.IDPropiedad == ID).ToList();
                return qry;
                //return BD.Propiedad.Where(b => b.IDPropiedad == ID).ToList();
            }
        }

        public int CrearModificar(Propiedad propiedad)
        {
            if (propiedad.IDPropiedad == 0)
            {
                return insert(propiedad);
            }
            else
            {
                return update(propiedad);
            }
        }

        private int insert(Propiedad propiedad)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                bd.Propiedad.Add(propiedad);
                return bd.SaveChanges();
            }
        }

        private int update(Propiedad propiedad)
        {
            using (BDPropertyEntities bd = new BDPropertyEntities())
            {
                Propiedad prop = bd.Propiedad.SingleOrDefault(b => b.IDPropiedad == propiedad.IDPropiedad);

                if (prop != null)
                {
                    //prop.Nombre = propiedad.Nombre;
                    prop.IDPropietario = Convert.ToInt64(propiedad.IDPropietario);
                    prop.IDBarrio = Convert.ToInt64(propiedad.IDBarrio);
                    prop.IDTipo = Convert.ToInt64(propiedad.IDTipo);
                    if (propiedad.IDEdificio == 0) prop.IDEdificio = null; else prop.IDEdificio = Convert.ToInt64(propiedad.IDEdificio);
                    //prop.IDEdificio = Convert.ToInt64(propiedad.IDEdificio);
                    prop.IDEstado = Convert.ToInt64(propiedad.IDEstado);
                    prop.Direccion = propiedad.Direccion;
                    prop.IDLocalidad = Convert.ToInt64(propiedad.IDLocalidad);
                    prop.Tamaño = propiedad.Tamaño;
                    prop.CantHabitac = propiedad.CantHabitac;
                    prop.CantBaños = propiedad.CantBaños;
                    prop.PisoNro = propiedad.PisoNro;

                    prop.Patio = propiedad.Patio;
                    prop.Cochera = propiedad.Cochera;
                    prop.Garage = propiedad.Garage;
                    prop.Cocina = propiedad.Cocina;
                    prop.Comedor = propiedad.Comedor;
                    prop.VistaCalle = propiedad.VistaCalle;
                    prop.GasNatural = propiedad.GasNatural;
                    prop.Pileta = propiedad.Pileta;
                    prop.Asador = propiedad.Asador;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }
    }
}
