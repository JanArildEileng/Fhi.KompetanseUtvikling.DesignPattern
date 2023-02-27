using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Katt;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KattFactory
{
    public class AsiaKattFactory : IKattFactory
    {
        public Katt CreateKatt()
        {
            return new Tiger();
        }
    }
}
