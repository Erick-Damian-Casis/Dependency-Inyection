using System;
using Interfaces;
using Entidades;
using Negocio;
using System.Reflection;
using Ninject;

namespace Habilidades
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kernel = new StandardKernel();
            Kernel.Load(Assembly.GetExecutingAssembly());
            var persistencia = Kernel.Get<IPersistencia>();

            Console.WriteLine("Bienvenido jugador!");
            Console.WriteLine("Escribe el nombre de tu personaje.....");
            var nombrePersonaje= Console.ReadLine();
            Console.WriteLine("¿Que hablidades deseas que tenga tu personaje?");
            var nombreHabilidad = Console.ReadLine();
            Console.WriteLine("¿Que vestimenta te gustaría?");
            var nombreVestimenta = Console.ReadLine();
            Console.WriteLine("Tu personaje fue creado con éxito");


            SistemaDeHabilidades sistemaDeHabilidades = new SistemaDeHabilidades(persistencia);
            Personaje personaje = new Personaje(nombrePersonaje); 
            Habilidad habilidad = new Habilidad(nombreHabilidad);
            Vestimenta vestimenta = new Vestimenta(nombreVestimenta);

            sistemaDeHabilidades.HabilidadAdquirida(personaje, habilidad, vestimenta);
        }
    }
}
