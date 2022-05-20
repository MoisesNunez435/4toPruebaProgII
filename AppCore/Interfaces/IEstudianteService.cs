using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public interface IEstudianteService : IService<Estudiante>
    {
        double CalcularPromedio(int nota1, int nota2, int nota3, int nota4);
        Estudiante FindByCarnet(string carnet);
    }
}
