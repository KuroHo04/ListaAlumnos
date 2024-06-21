namespace ListaAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de alumnos:");

            List<Alumno> alumnos = new List<Alumno>();


            alumnos.Add(new Alumno { matricula = "31543", nombre = "Juan Esquer", carrera = "Ing. Mecatronica" });
            alumnos.Add(new Alumno { matricula = "32463", nombre = "Juan Lopez", carrera = "Ing. Sistemas Computacionales" });
            alumnos.Add(new Alumno { matricula = "33789", nombre = "Esmeralda Espinosa", carrera = "Ing. Idraulica" });

            while (true)
            {
                Console.WriteLine("\n¿Qué deseas hacer?");
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Eliminar alumno");
                Console.WriteLine("3. Mostrar lista de alumnos");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarAlumno(alumnos);
                        break;
                    case 2:
                        EliminarAlumno(alumnos);
                        break;
                    case 3:
                        MostrarListaAlumnos(alumnos);
                        break;
                    case 4:
                        Console.WriteLine("¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }

        static void AgregarAlumno(List<Alumno> alumnos)
        {
            Console.WriteLine("\nAgregar alumno:");
            Console.Write("Matricula: ");
            string matricula = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Carrera: ");
            string carrera = Console.ReadLine();

            alumnos.Add(new Alumno { matricula = matricula, nombre = nombre, carrera = carrera });
            Console.WriteLine("Alumno agregado exitosamente.");
        }

        static void EliminarAlumno(List<Alumno> alumnos)
        {
            Console.WriteLine("\nEliminar alumno:");
            Console.Write("Matricula del alumno a eliminar: ");
            string matricula = Console.ReadLine();

            Alumno alumno = alumnos.Find(a => a.matricula == matricula);

            if (alumno != null)
            {
                alumnos.Remove(alumno);
                Console.WriteLine("Alumno eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Alumno con la matricula indicada no encontrado.");
            }
        }

        static void MostrarListaAlumnos(List<Alumno> alumnos)
        {
            Console.WriteLine("\nLista de alumnos:");

            if (alumnos.Count == 0)
            {
                Console.WriteLine("La lista de alumnos está vacía.");
            }
            else
            {
                foreach (Alumno alumno in alumnos)
                {
                    Console.WriteLine(alumno);
                    Console.WriteLine("----------------------");
                }
            }
        }
    }
}