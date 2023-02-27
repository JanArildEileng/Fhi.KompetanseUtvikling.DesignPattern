using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Krokodille;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KrokodilleFactory
{
    public class AfrikaKrokodilleFactory : IKrokodilleFactory
    {
        public Krokodille CreateKrokodille()
        {
           return new Nilkrokodille();
        }
    }
}
