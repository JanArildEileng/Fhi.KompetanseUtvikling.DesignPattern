using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.SlangeFactory
{
    public class AsiaSlangeFactory : ISlangeFactory
    {
        public Slange CreateSlange()
        {
            return new Python()
            {
                Slangetype = Enum.Slangetype.Kveler
            };
        }
    }
}

