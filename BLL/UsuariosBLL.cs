using Registro.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Registro.Entidades;
using System.Data.Entity;

namespace Registro.BLL
{
        public class UsuariosBll
        {
            public static bool Guardar(Usuario usuarios)
            {
                bool paso = false;
                Contexto db = new Contexto();
                try
                {
                    if (db.usuarios.Add(usuarios) != null)
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

            public static bool Modificar(Usuario usuarios)
            {
                bool paso = false;
                Contexto db = new Contexto();

                try
                {
                    db.Entry(usuarios).State = System.Data.Entity.EntityState.Modified;
                    paso = (db.SaveChanges() > 0);
                    db.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return paso;
            }

            public static bool Eliminar(int id)
            {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.usuarios.Find(id);
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

            public static Usuario Buscar(int id)
            {
                Contexto db = new Contexto();
                Usuario usuarios = new Usuario();
                try
                {
                    usuarios = db.usuarios.Find(id);
                    db.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return usuarios;
            }

            public static List<Usuario> GetList(Expression<Func<Usuario, bool>> persona)
            {
                List<Usuario> people = new List<Usuario>();
                Contexto db = new Contexto();
                try
                {
                    people = db.usuarios.Where(persona).ToList();
                    db.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return people;
            }


        }
    }





