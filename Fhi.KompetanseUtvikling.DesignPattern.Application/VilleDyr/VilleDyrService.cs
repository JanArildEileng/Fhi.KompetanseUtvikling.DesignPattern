using Fhi.KompetanseUtvikling.DesignPattern.Domene.Enum;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.abstractfactory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Application.VilleDyr;
public class VilleDyrService
{
    public VilleDyrIKontinent FinnVilleDyrIKontinent(Kontinent kontinent, IAbstractDyrFactory? abstractDyrFactory)
    {
        VilleDyrIKontinent villeDyrIKontinent = new VilleDyrIKontinent() { KontinentNavn = kontinent.ToString() };

        villeDyrIKontinent.Krokodille = abstractDyrFactory?.CreateKrokodilleFactory()?.CreateKrokodille();
        villeDyrIKontinent.Katt = abstractDyrFactory?.CreateKattFactory()?.CreateKatt();
        villeDyrIKontinent.Slange = abstractDyrFactory?.CreateSlangeFactory()?.CreateSlange();

        //TODO Bjørn
        //TODO Rareste

        return villeDyrIKontinent;
    }
}
