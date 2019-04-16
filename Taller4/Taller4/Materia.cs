using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    [Serializable]
    public class Materia
    {
        public string nombre { get; set; }
        private readonly string _Codigo;

        public Materia(String codigo)
        {
            _Codigo = codigo;
        }

        public Materia(string nombre, string codigo) : this(codigo)
        {
            this.nombre = nombre;
        }

        public String Codigo
        {
            get
            {
                return _Codigo;
            }
        }

        public Aula AulaAsignada { get; set; }
    }
}
