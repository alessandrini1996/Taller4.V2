using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Dominio
{
    [Serializable]
    public class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private readonly List<Materia> _Materias;
        Materia materia;

        public IEnumerable<Materia> Materias => _Materias.AsEnumerable();
        
        public string Dni => Dni;
        

        public Profesor(string nombre, string apellido, string dni, Materia materia)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.materia = materia;
        }

        public void Incribir(Materia materia)
        {
            _Materias.Add(materia);
        }

    }
}
