using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.SlangeFactory
{
    public class AustraliaSlangeFactory : ISlangeFactory
    {
        public Slange CreateSlange()
        {
            return new BrownSnake()
            {
                Slangetype = Enum.Slangetype.Gift
            };
        }
    }
}

