using Registro.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Registro.Entidades;
using System.Data.Entity;

namespace Registro.BLL
{
    class CargosBLL
    {
        public static bool Guardar(Cargo cargos)
        {
            bool paso = false;
            ContextoCargo db = new ContextoCargo();
            try
            {
                if (db.cargos.Add(cargos) != null)
                {
                    db.SaveChanges();
                    paso = true;
                }

                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Cargo cargos)
        {
            bool paso = false;
            ContextoCargo db = new ContextoCargo();

            try
            {
                db.Entry(cargos).State = System.Data.Entity.EntityState.Modified;
                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Eliminar(int CargoId)
        {
            bool paso = false;
            ContextoCargo db = new ContextoCargo();

            try
            {
                var eliminar = db.cargos.Find(CargoId);
                //db.Persona.Remove(eliminar);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Cargo Buscar(int CargoId)
        {
            ContextoCargo db = new ContextoCargo();
            Cargo cargos = new Cargo();
            try
            {
                cargos = db.cargos.Find(CargoId);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return cargos;
        }


    }
}
