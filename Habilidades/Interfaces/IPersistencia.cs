using Entidades;

namespace Interfaces
{
    public interface IPersistencia
    {
        public bool Grabar(Personaje personaje);
        public bool Grabar(Habilidad habilidad);
        public bool Grabar(HabilidadesPorPersonaje habilidadesPorPersonaje);
        public bool Grabar(Vestimenta vestimenta);
    }

}
