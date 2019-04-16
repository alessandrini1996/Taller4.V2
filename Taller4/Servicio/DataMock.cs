using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public static class DataMock
    {
        internal static IEnumerable<Alumno> Alumnos { get; private set; }
        internal static IEnumerable<Profesor> Profesores { get; private set; }
        internal static IEnumerable<Aula> Aulas { get; private set; }
        internal static IEnumerable<Materia> Materias { get; private set; }
        internal static IEnumerable<Examen> Examenes { get; private set; }

        public static void Inicialize()
        {
            #region
            var materia1 = new Materia("T4", "Taller 4");
            var materia2 = new Materia("BD", "Base de Datos");
            var materia3 = new Materia("SI", "Simulacio");
            var materia4 = new Materia("AyM", "Analisis y Metodologias");
            var materia5 = new Materia("RD", "Redes");

            #endregion

            #region
            var alumno1 = new Alumno("Mariano", "Perez", "36789987", new DateTime(1968, 04, 21));
            var alumno2 = new Alumno("Sofia", "Meriadiano", "3978998", new DateTime(1997, 11, 23));
            var alumno3 = new Alumno("Fernando", "Exposito", "38908678", new DateTime(1996, 02, 29));
            var alumno4 = new Alumno("Gabriela", "Gallo", "35789098", new DateTime(1995, 09, 24));
            var alumno5 = new Alumno("Maria", "Felix", "31890345", new DateTime(1994, 12, 24));
            var alumno6 = new Alumno("Walter", "Cruz", "33456987", new DateTime(1999, 03, 31));
            var alumno7 = new Alumno("Emilia", "Clark", "33456987", new DateTime(1993, 06, 12));
            var alumno8 = new Alumno("Walter", "Cruz", "33456987", new DateTime(1991, 05, 18));
            var alumno9 = new Alumno("Walter", "Cruz", "33456987", new DateTime(1997, 10, 06));
            var alumno10 = new Alumno("Walter", "Cruz", "33456987", new DateTime(1994, 07, 29));
            var alumno11 = new Alumno("Walter", "Cruz", "33456987", new DateTime(1998, 02, 01));

            alumno1.InscribirMateria(materia2);
            alumno2.InscribirMateria(materia4);
            alumno3.InscribirMateria(materia3);
            alumno4.InscribirMateria(materia5);
            alumno5.InscribirMateria(materia1);
            alumno6.InscribirMateria(materia5);
            alumno7.InscribirMateria(materia2);
            alumno8.InscribirMateria(materia3);
            alumno9.InscribirMateria(materia4);
            alumno10.InscribirMateria(materia1);
            alumno11.InscribirMateria(materia5);

            #endregion

            #region
            var profesor1 = new Profesor("Santiago", "Perez", "32456788", materia1);
            var profesor2 = new Profesor("Mariana", "Andalu", "16787543", materia3);
            var profesor3 = new Profesor("Sandra", "Ver", "32122235", materia4);
            var profesor4 = new Profesor("Mariano", "Exposito", "19876899", materia2);
            var profesor5 = new Profesor("Bautista", "Lopez", "18765335", materia5);

            profesor1.Incribir(materia1);
            profesor2.Incribir(materia4);
            profesor3.Incribir(materia5);
            profesor4.Incribir(materia3);
            profesor5.Incribir(materia2);

            #endregion

            #region
            var aula1 = new Aula("1", "B");
            var aula2 = new Aula("4", "C");
            var aula3 = new Aula("2", "D");
            var aula4 = new Aula("5", "A");
            var aula5 = new Aula("3", "E");

            aula1.AsignarMateria(materia1);
            aula2.AsignarMateria(materia3);
            aula3.AsignarMateria(materia4);
            aula4.AsignarMateria(materia5);
            aula5.AsignarMateria(materia2);

            #endregion

            #region

            var examen1 = new Examen(9, new DateTime(2019,03,18),alumno1,materia2);
            var examen2 = new Examen(7, new DateTime(2019,03,22),alumno2,materia1);
            var examen3 = new Examen(5, new DateTime(2019,03,29),alumno3,materia4);
            var examen4 = new Examen(6, new DateTime(2019,04,03),alumno4,materia3);
            var examen5 = new Examen(2, new DateTime(2019,04,10),alumno1,materia5);
            var examen6 = new Examen(3, new DateTime(2019,04,17),alumno6,materia1);
            var examen7 = new Examen(4, new DateTime(2019, 04, 17), alumno2, materia4);
            var examen8 = new Examen(8, new DateTime(2019, 04, 17), alumno3, materia5);
            var examen9 = new Examen(9, new DateTime(2019, 04, 17), alumno5, materia2);
            var examen10 = new Examen(3, new DateTime(2019, 04, 17), alumno5, materia1);
            var examen11 = new Examen(3, new DateTime(2019, 04, 17), alumno4, materia2);

            alumno1.Evaluar(examen2);
            alumno2.Evaluar(examen1);
            alumno3.Evaluar(examen4);
            alumno4.Evaluar(examen6);
            alumno5.Evaluar(examen3);
            alumno6.Evaluar(examen7);
            alumno7.Evaluar(examen8);
            alumno8.Evaluar(examen9);
            alumno9.Evaluar(examen10);
            alumno10.Evaluar(examen11);
            alumno11.Evaluar(examen5);

            #endregion

            #region
            Alumnos = new[] { alumno1, alumno2, alumno3, alumno4, alumno5, alumno6 };
            Materias = new[] { materia1, materia2, materia3, materia4, materia5 };
            Profesores = new[] { profesor1, profesor2, profesor3, profesor4, profesor5 };
            Aulas = new[] { aula1, aula2, aula3, aula4, aula5 };
            Examenes = new[] { examen1, examen2, examen3, examen4, examen5, examen6 };
            #endregion
        }
    }
}
