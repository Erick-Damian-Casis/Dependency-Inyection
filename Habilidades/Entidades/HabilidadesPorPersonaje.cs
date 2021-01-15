using System;

namespace Entidades
{
    public class HabilidadesPorPersonaje 
    {
        public int PersonajeId { get; set; }
        public int HabilidadId { get; set; }
        public int Id { get; set; } = new Random().Next();

    }
}
