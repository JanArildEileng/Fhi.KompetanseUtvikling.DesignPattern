using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface;

namespace Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Krokodille;

public abstract class Krokodille : IKrokodille
{
    public string Typename { get; init; } = nameof(Krokodille);
    public int NumberOfTeeth { get; set; }
}
