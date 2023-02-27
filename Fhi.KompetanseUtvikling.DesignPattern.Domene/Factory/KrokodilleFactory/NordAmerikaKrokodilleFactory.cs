
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Krokodille;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KrokodilleFactory
{
    public class NordAmerikaKrokodilleFactory : IKrokodilleFactory
    {
        public Krokodille CreateKrokodille()
        {
            return new Aligator();
        }
    }
}
