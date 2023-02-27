using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KrokodilleFactory
{
    public class NordAmerikaSlangeFactory : ISlangeFactory
    {
        public Slange CreateSlange()
        {
            return new KlapperSlange()
            {
                Slangetype = Enum.Slangetype.Gift
            };
        }
    }
}

