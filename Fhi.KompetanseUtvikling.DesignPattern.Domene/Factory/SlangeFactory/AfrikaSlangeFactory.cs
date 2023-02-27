using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KrokodilleFactory
{
    public class AfrikaSlangeFactory : ISlangeFactory
    {
        public Slange CreateSlange()
        {
           return new SvartMamba()
           {
               Slangetype = Enum.Slangetype.Gift
           };
        }
    }
}
