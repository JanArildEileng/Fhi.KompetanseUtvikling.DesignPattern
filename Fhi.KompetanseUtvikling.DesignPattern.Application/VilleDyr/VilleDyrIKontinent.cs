using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Katt;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Krokodille;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface;

namespace Fhi.KompetanseUtvikling.DesignPattern.Application.VilleDyr;

public record VilleDyrIKontinent
{
    public String KontinentNavn { get; init; }
    public Krokodille? Krokodille { get; set; }
    public Slange? Slange { get; set; }
    public Katt? Katt { get; set; }
}
