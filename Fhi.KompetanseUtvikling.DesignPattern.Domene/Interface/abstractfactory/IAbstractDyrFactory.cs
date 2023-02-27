using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.abstractfactory
{
    public interface IAbstractDyrFactory
    {
        IKattFactory? CreateKattFactory();
        IKrokodilleFactory? CreateKrokodilleFactory();
        ISlangeFactory? CreateSlangeFactory();

    }
}
