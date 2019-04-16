using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    [Serializable]
    public class Aula
    {
        public String Piso { get; set; }
        public String Sala { get; set; }
        private Materia Materia { get; set; }

        public Aula()
        {
        }

        public Aula(String piso, String sala) : this()
        {
            Piso = piso;
            Sala = sala;
        }

        public void AsignarMateria(Materia materia)
        {
            Materia = materia;
            materia.AulaAsignada = this;
        }
    }
}
