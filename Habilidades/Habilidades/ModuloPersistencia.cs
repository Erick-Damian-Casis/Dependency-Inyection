using Implementacion;
using Interfaces;
using Ninject.Modules;


namespace Habilidades
{
    public class ModuloPersistencia : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersistencia>().To<Persistencia>();
        }
    }
}
