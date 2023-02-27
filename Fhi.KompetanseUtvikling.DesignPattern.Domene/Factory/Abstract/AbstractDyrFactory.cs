using Fhi.KompetanseUtvikling.DesignPattern.Domene.Enum;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.abstractfactory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.Abstract;

public class AbstractDyrFactory
{
    public  static IAbstractDyrFactory? Create(Kontinent kontinent)
    {
        switch (kontinent)
        {
            case Kontinent.SørAmerika:
                return  new SørAmerikaDyrFactory();
            case Kontinent.NordAmerika:
                return new NordAmerikaDyrFactory();
            case Kontinent.Asia:
                return new AsiaDyrFactory();
            case Kontinent.Afrika:
                return new AfrikaDyrFactory();
            case Kontinent.Australia:
                return new AustraliaDyrFactory();
        }
        return null;
    }
}
