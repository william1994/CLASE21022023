using Bucles.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles.Negocio
{
    public class ClsEstudiante
    {
        //Est es un arreglo (Variable) de tipo estudiantes
        List<Estudiante> Est= new List<Estudiante>();


        public Estudiante AgregarEstudiante(Estudiante estu) {

            Est.Add(estu);
            return estu;
        }

        //List<String> SoyString = new List<String>();
        //IEnumerable<Estudiante> estudiantes_  = new List<Estudiante>();

    }
}
