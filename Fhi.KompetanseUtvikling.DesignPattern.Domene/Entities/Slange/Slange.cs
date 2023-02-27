using Fhi.KompetanseUtvikling.DesignPattern.Domene.Enum;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange
{
    public abstract class Slange :ISlange
    {
        public string Typename { get; init; } = nameof(Slange);
        public Slangetype Slangetype { get ; set ; }

    }
}
