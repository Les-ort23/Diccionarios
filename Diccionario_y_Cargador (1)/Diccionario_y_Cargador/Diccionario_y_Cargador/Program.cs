using Diccionario_y_Cargador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Diccionario_y_Cargador
{
    internal class Program
    {
        static void Main()
        {            
            Cargador cargador = new Cargador();
            Dictionary<int, Mascota> diccionarioMascotas = cargador.diccionarioMacotas;
            Dictionary<int, Profesor> diccionarioProfesores = cargador.diccionarioProfesores;
            Dictionary<int, Alumno> diccionarioAlumnos = cargador.diccionarioAlumnos;



            int decision;
            



            do {
                try
                {
                    Console.WriteLine("Ingresa el numero correspondiente a la clase con la que deseas trabajar\n1 - Mascota\n2 - Profesor\n3 - Alumno");
                    decision = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();



                    if (decision == 1 || decision == 2 || decision == 3)
                    {
                        break;

                    }
                    else 
                    {
                        Console.WriteLine("Error! El valor introducido no es valido\nPresiona Enter y elige una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                        
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Error! El valor ingresado no es un numero\nPresiona Enter y elige una opcion valida");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (true);




            switch (decision)
            {
                
                case 1:

                    for (int i = 0; i < 3; i++)
                    {
                        Mascota mascota = new Mascota();
                        do
                        {
                            try
                            {
                                Console.WriteLine("Ingresa el ID de la mascota: ");
                                int id = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Ingresa el nombre de la mascota: ");
                                mascota.Name = Console.ReadLine();

                                cargador.RellenarDiccionarioMascota(id, mascota);
                                Console.Clear();
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error! El valor ingresado no es un numero entero\nPresiona enter e ingresa un valor valido");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        } while (true);
                        
                    }

                    

                    string teclaoprimidaCasoUno;
                    do
                    {
                        Console.WriteLine("Ingresa el id de la mascota que deseas conocer su nombre");
                        int idBuscada = Convert.ToInt16(Console.ReadLine());
                        if (diccionarioMascotas.ContainsKey(idBuscada))
                        {
                            Console.WriteLine($"El nombre de la mascota con id {idBuscada} es: {diccionarioMascotas[idBuscada].Name}");
                        }
                        else
                        {
                            Console.WriteLine($"No existe nunguna mascosta con el id: {idBuscada} en el diccionario");
                        }


                        Console.WriteLine("\n¿Desea buscar otro id de mascota? \nPulse \"Enter\" para SI o Ingrese \"N\" para NO");
                        teclaoprimidaCasoUno = Console.ReadLine().ToLower();
                        if (teclaoprimidaCasoUno == "n")
                        {
                            Console.WriteLine("Programa terminado, hasta pronto.");
                            break;
                        }
                        Console.Clear();
                    } while (true);

                    break;


                case 2:
                    
                    for (int i = 0; i < 3; i++)
                    {
                        Profesor profesor = new Profesor();
                        do
                        {
                            try
                            {
                                Console.WriteLine("Ingresa el ID del Profesor: ");
                                int id = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Ingresa el nombre del Profesor: ");
                                profesor.Name = Console.ReadLine();

                                cargador.RellenarDiccionarioProfesor(id, profesor);
                                Console.Clear();
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error! El valor ingresado no es un numero entero\nPresiona enter e ingresa un valor valido");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        } while (true);
                    }



                    string teclaoprimidaCasoDos;
                    do
                    {
                        Console.WriteLine("Ingresa el id del Profesor que deseas conocer su nombre");
                        int idBuscada = Convert.ToInt16(Console.ReadLine());
                        if (diccionarioProfesores.ContainsKey(idBuscada))
                        {
                            Console.WriteLine($"El nombre del Profesor con id {idBuscada} es: {diccionarioProfesores[idBuscada].Name}");
                        }
                        else
                        {
                            Console.WriteLine($"No existe nungun Profesor con el id: {idBuscada} en el diccionario");
                        }


                        Console.WriteLine("\n¿Desea buscar otro id de Profesor? \nPulse \"Enter\" para SI o Ingrese \"N\" para NO");
                        teclaoprimidaCasoDos = Console.ReadLine().ToLower();
                        if (teclaoprimidaCasoDos == "n")
                        {
                            Console.WriteLine("Programa terminado, hasta pronto.");
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    
                    break;


                case 3:

                    for (int i = 0; i < 3; i++)
                    {
                        Alumno alumno = new Alumno();
                        do
                        {
                            try
                            {
                                Console.WriteLine("Ingresa el ID del alumno: ");
                                int id = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Ingresa el nombre del alumno: ");
                                alumno.Name = Console.ReadLine();

                                cargador.RellenarDiccionarioAlumno(id, alumno);
                                Console.Clear();
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error! El valor ingresado no es un numero entero\nPresiona enter e ingresa un valor valido");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        } while (true);
                    }


                    string teclaoprimidaCasoTres;
                    do
                    {
                        Console.WriteLine("Ingresa el id del alumno que deseas conocer su nombre");
                        int idBuscada = Convert.ToInt16(Console.ReadLine());
                        if (diccionarioAlumnos.ContainsKey(idBuscada))
                        {
                            Console.WriteLine($"El nombre del alumno con id {idBuscada} es: {diccionarioAlumnos[idBuscada].Name}");
                        }
                        else
                        {
                            Console.WriteLine($"No existe nungun alumno con el id: {idBuscada} en el diccionario");
                        }


                        Console.WriteLine("\n¿Desea buscar otro id de alumno? \nPulse \"Enter\" para SI o Ingrese \"N\" para NO");
                        teclaoprimidaCasoTres = Console.ReadLine().ToLower();
                        if (teclaoprimidaCasoTres == "n")
                        {
                            Console.WriteLine("Programa terminado, hasta pronto.");
                            break;
                        }
                        Console.Clear();
                    } while (true);

                    




                    break;

                default:
                    
                    break;
            }

            Console.ReadKey();

            


            


            


            
        }
    }
}


