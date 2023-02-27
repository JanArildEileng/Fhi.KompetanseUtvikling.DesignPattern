using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;


namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KrokodilleFactory
{
    public class SørAmerikaSlangeFactory : ISlangeFactory
    {
        public Slange CreateSlange()
        {
            return new Anaconda()
            {
                Slangetype = Enum.Slangetype.Kveler
            };
        }
    }
}

