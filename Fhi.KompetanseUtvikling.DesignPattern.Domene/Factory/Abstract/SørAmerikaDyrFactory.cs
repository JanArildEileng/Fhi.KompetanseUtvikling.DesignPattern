﻿using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KattFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KrokodilleFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.SlangeFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.abstractfactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.Abstract
{
    public class SørAmerikaDyrFactory : IAbstractDyrFactory
    {
        public IKattFactory CreateKattFactory()
        {
            return new SørAmerikaKattFactory();
        }

        public IKrokodilleFactory CreateKrokodilleFactory()
        {
            return new SørAmerikaKrokodilleFactory();
        }

        public ISlangeFactory CreateSlangeFactory()
        {
            return new SørAmerikaSlangeFactory();
        }
    }
}
