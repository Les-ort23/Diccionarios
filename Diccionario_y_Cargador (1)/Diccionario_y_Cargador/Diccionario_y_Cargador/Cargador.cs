using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario_y_Cargador
{
    public class Cargador
    {
        public Dictionary<int, Mascota> diccionarioMacotas = new Dictionary<int, Mascota>();
        public Dictionary<int, Profesor> diccionarioProfesores = new Dictionary<int, Profesor>();
        public Dictionary<int, Alumno> diccionarioAlumnos = new Dictionary<int, Alumno>();

        public Dictionary<int, Mascota> RellenarDiccionarioMascota(int id, Mascota mascota)
        {


            while (diccionarioMacotas.ContainsKey(id))
            {
                Console.WriteLine("\nError!\nEl ID ya existe. Por favor, ingresa un ID diferente para la mascota \"" + mascota.Name + "\"");
                id = Convert.ToInt16(Console.ReadLine());
            }

            diccionarioMacotas.Add(id, mascota);

            return diccionarioMacotas;
        }

        public Dictionary<int, Profesor> RellenarDiccionarioProfesor(int id, Profesor profesor) 
        {
            while (diccionarioProfesores.ContainsKey(id))
            {
                Console.WriteLine("\nError!\nEl ID ya existe. Por favor, ingresa un ID diferente para el profesor \"" + profesor.Name + "\"");
                id = Convert.ToInt16(Console.ReadLine());
            }

            diccionarioProfesores.Add(id, profesor);

            return diccionarioProfesores;
        }

        public Dictionary<int, Alumno> RellenarDiccionarioAlumno(int id, Alumno alumno) 
        {
            while (diccionarioAlumnos.ContainsKey(id))
            {
                Console.WriteLine("\nError!\nEl ID ya existe. Por favor, ingresa un ID diferente para el alumno \"" + alumno.Name + "\"");
                id = Convert.ToInt16(Console.ReadLine());
            }

            diccionarioAlumnos.Add(id, alumno);

            return diccionarioAlumnos;
        }
        
       
            
     }

}


