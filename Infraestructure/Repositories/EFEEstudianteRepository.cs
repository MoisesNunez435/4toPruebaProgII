using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class EFEEstudianteRepository : IEstudianteRepository
    {
        private IPepitoSchoolDbContext pepitoSchoolDbContext;
        public EFEEstudianteRepository(IPepitoSchoolDbContext pepitoSchoolDbContext)
        {
            this.pepitoSchoolDbContext = pepitoSchoolDbContext;
        }

        public double CalcularPromedio(int nota1, int nota2, int nota3, int nota4)
        {
            try
            {
                double promedio = 0;
                return promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Create(Estudiante t)
        {
            try
            {
                pepitoSchoolDbContext.Estudiantes.Add(t);
                pepitoSchoolDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto Estudiante no puede ser null.");
                }

                Estudiante estudiante = FindByCarnet(t.Carnet);
                if (estudiante == null)
                {
                    throw new Exception($"El objeto con dni {t.Carnet} no existe.");
                }

                pepitoSchoolDbContext.Estudiantes.Remove(estudiante);
                int result = pepitoSchoolDbContext.SaveChanges();

                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante FindByCarnet(string carnet)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(carnet))
                {

                    throw new ArgumentException($"El objeto carnet no puede ser null o estar vacia");
                }

                return pepitoSchoolDbContext.Estudiantes.FirstOrDefault(x => x.Carnet.Equals(carnet));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            try
            {
                return pepitoSchoolDbContext.Estudiantes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto estudiante no puede ser null.");
                }

                Estudiante estudiante = FindByCarnet(t.Carnet);
                if (estudiante == null)
                {
                    throw new Exception($"El objeto estudiante con ese carnet no existe.");
                }

                estudiante.Nombres = t.Nombres;
                estudiante.Apellidos = t.Apellidos;
                estudiante.Carnet = t.Carnet;
                estudiante.Correo = t.Correo;
                estudiante.Direccion = t.Direccion;
                estudiante.Phone = t.Phone;
                estudiante.Contabilidad = t.Contabilidad;
                estudiante.Estadistica = t.Estadistica;
                estudiante.Matematica = t.Matematica;
                estudiante.Programacion = t.Programacion;

                pepitoSchoolDbContext.Estudiantes.Update(estudiante);
                return pepitoSchoolDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }



}
