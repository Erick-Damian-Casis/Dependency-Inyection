using System.Collections.Generic;
using System.IO;
using Entidades;
using Interfaces;

namespace Implementacion2
{
    public class Persistencia2 : IPersistencia
    {
        public bool Grabar(Personaje personaje)
        {
            File.AppendAllLines("Personaje.txt", new List<string> { "Nuevo personaje creado", personaje.Nombre });
            return true;
        }
        public bool Grabar(Habilidad habilidad)
        {
            File.AppendAllLines("habilidad.txt", new List<string> { "Felicidades has adquirido la habilidad", habilidad.Nombre });
            return false;
        }
        public bool Grabar(HabilidadesPorPersonaje habilidadesPorPersonaje)
        {
            File.AppendAllLines("habilidadesPorPersonaje.txt", new List<string> { "Tu id es ", habilidadesPorPersonaje.Id.ToString() });
            return false;
        }
        public bool Grabar(Vestimenta vestimenta)
        {
            File.AppendAllLines("vestimenta.txt", new List<string> { "Tu vestimenta es", vestimenta.Nombre.ToString() });
            return true;
        }
    }

}
