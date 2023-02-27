using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KattFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KrokodilleFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.SlangeFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.abstractfactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.Abstract
{
    public class AustraliaDyrFactory : IAbstractDyrFactory
    {
        public IKattFactory? CreateKattFactory()
        {
            return null;
        }

        public IKrokodilleFactory? CreateKrokodilleFactory()
        {
            return new AustrliaKrokodilleFactory();
        }

        public ISlangeFactory? CreateSlangeFactory()
        {
            return new AustraliaSlangeFactory();
        }
    }
}
