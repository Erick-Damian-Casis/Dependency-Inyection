using System;

namespace Entidades
{
    public class Habilidad 
    {
        public Habilidad(string nombre)
        {
            Nombre = nombre;
            Id = new Random().Next();
        }
        public string Nombre { get; set; }
        public int Id { get; set; }
    }
}
