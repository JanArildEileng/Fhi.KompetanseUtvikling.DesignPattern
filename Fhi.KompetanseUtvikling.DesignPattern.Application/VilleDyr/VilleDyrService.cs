using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Krokodille;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Enum;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Application.VilleDyr;
public class VilleDyrService
{
    public VilleDyrIKontinent FinnVilleDyrIKontinent(Kontinent kontinent, IKattFactory? kattFactory, IKrokodilleFactory? krokodilleFactory, ISlangeFactory? slangeFactory)
    {
        VilleDyrIKontinent villeDyrIKontinent = new VilleDyrIKontinent() { KontinentNavn = kontinent.ToString() };

        villeDyrIKontinent.Krokodille = krokodilleFactory?.CreateKrokodille();
        villeDyrIKontinent.Katt = kattFactory?.CreateKatt();
        villeDyrIKontinent.Slange = slangeFactory?.CreateSlange();

        //TODO Bjørn
        //TODO Rareste

        return villeDyrIKontinent;
    }
}
