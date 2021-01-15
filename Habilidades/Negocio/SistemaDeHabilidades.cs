using Interfaces;
using Entidades;

namespace Negocio
{
    public class SistemaDeHabilidades
    {
        public IPersistencia persistencia;
        public SistemaDeHabilidades(IPersistencia persistencia)
        {
            this.persistencia = persistencia;
        }
        public string HabilidadAdquirida(Personaje personaje, Habilidad habilidad, Vestimenta vestimenta)
        {
            persistencia.Grabar(personaje);
            persistencia.Grabar(habilidad);
            persistencia.Grabar(vestimenta);
            persistencia.Grabar(new HabilidadesPorPersonaje{ PersonajeId = personaje.Id, HabilidadId = habilidad.Id });
            return string.Format("El {0} Adquirio la habilidad {1} , su vestimenta es{2}", personaje.Nombre, habilidad.Nombre, vestimenta.Nombre);
        }
    }
}
