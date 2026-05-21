using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Console.WriteLine("Ejemplo List");
        CasoList casoList = new CasoList();

        Alumno a1 = new Alumno(1, "Franco", 7.0);
        Alumno a2 = new Alumno(2, "Celeste", 8.0);
        Alumno a3 = new Alumno(3, "Pedro", 9.0);
        
        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        Console.WriteLine("Contenido de la lista: ");
        foreach (var Alumno in casoList.ListarAlumnos())
        {
            Console.WriteLine($"- {Alumno.Id}: {Alumno.Nombre} | Promedio {Alumno.Promedio}");
        }
        
        
        Alumno? busqueda = casoList.BuscarAlumno("Franco");
        Console.WriteLine("Buscando alumno que existe");
        if (busqueda != null)
        {
            Console.WriteLine($"Alumno encontrado: {busqueda.Id}: {busqueda.Nombre} | Promedio {busqueda.Promedio}");
        }

        Alumno? busqueda2 = casoList.BuscarAlumno("Salomon");
        Console.WriteLine("Buscando alumno que no existe");
            if (busqueda2 == null)
            {
                Console.WriteLine("No existe");
            }

        Console.WriteLine("Eliminando alumno y mostrando");    
        casoList.EliminarAlumno(a2);
        foreach (var Alumno in casoList.ListarAlumnos())
        {
            Console.WriteLine($"{Alumno.Id} {Alumno.Nombre} | Promedio {Alumno.Promedio}");
        }

        Console.WriteLine("Eliminando primer alumno y mostrando");
        casoList.EliminarAlumno(0);
        foreach (var Alumno in casoList.ListarAlumnos())
        {
            Console.WriteLine($"{Alumno.Id} {Alumno.Nombre} | Promedio {Alumno.Promedio}");
        }


    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Console.WriteLine("Ejemplo Dictionary");

        CasoDictionary casoDictionary = new CasoDictionary();
        
        Alumno a1 = new Alumno(1, "Franco", 7.0);
        Alumno a2 = new Alumno(2, "Celeste", 8.0);
        Alumno a3 = new Alumno(3, "Pedro", 9.0);
        
        casoDictionary.AgregarAlumno(a1);
        casoDictionary.AgregarAlumno(a2);
        casoDictionary.AgregarAlumno(a3);
        
        Console.WriteLine("Contenido del dictionary: ");
        foreach (var Alumno in casoDictionary.ListarAlumnos())
        {
            Console.WriteLine($"{Alumno.Key} -  {Alumno.Value.Nombre} |  Promedio {Alumno.Value.Promedio}");
        }

        Console.WriteLine("Buscando alumno por clave: 2");
        Alumno?  busqueda = casoDictionary.BuscarAlumno(2);
        if (busqueda != null)
        {
            Console.WriteLine($"Alumno encontrado: {busqueda.Id} - {busqueda.Nombre}| Promedio {busqueda.Promedio}");
        }

        Console.WriteLine("Buscando alumno que no existe: 934");
        Alumno? busqueda2 = casoDictionary.BuscarAlumno(934);
        if (busqueda2 == null)
        {
            Console.WriteLine("No existe");
        }
        
        Console.WriteLine("Eliminando alumno y mostrando");
        casoDictionary.EliminarAlumno(2);
        foreach (var Alumno in casoDictionary.ListarAlumnos())
        {
            Console.WriteLine($"{Alumno.Key} - {Alumno.Value.Nombre} | Promedio {Alumno.Value.Promedio}");
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
