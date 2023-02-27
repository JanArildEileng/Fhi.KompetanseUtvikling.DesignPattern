using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Katt;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KattFactory
{
    public class AfrikaKattFactory : IKattFactory
    {
        public Katt CreateKatt()
        {
            return new Løve();
        }
    }
}
