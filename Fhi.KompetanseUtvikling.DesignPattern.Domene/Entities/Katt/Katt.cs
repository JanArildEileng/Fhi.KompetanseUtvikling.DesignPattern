

using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Katt;

public abstract class Katt : IKatt
{
    public string Typename { get; init; } = nameof(Katt);
  
}


