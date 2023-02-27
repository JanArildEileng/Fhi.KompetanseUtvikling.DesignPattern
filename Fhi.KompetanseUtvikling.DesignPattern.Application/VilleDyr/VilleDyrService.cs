using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Krokodille;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Enum;

namespace Fhi.KompetanseUtvikling.DesignPattern.Application.VilleDyr;
public class VilleDyrService
{
    public VilleDyrIKontinent FinnVilleDyrIKontinent(Kontinent kontinent)
    {
        VilleDyrIKontinent villeDyrIKontinent = new VilleDyrIKontinent() { KontinentNavn = kontinent.ToString() };

        switch (kontinent)
        {
            case Kontinent.SørAmerika:
                villeDyrIKontinent.Krokodille = new Kaiman();
                villeDyrIKontinent.Slange = new Anaconda()
                {
                    Slangetype = Slangetype.Kveler
                };
                //TODO Bjørn
                //TODO Katt
                //TODO Rareste
                break;

            case Kontinent.NordAmerika:
                villeDyrIKontinent.Krokodille = new Aligator();
                villeDyrIKontinent.Slange = new KlapperSlange()
                {
                    Slangetype = Slangetype.Gift
                };
                //TODO Bjørn
                //TODO Katt
                //TODO Rareste

                break;

            case Kontinent.Asia:
                //TODO
                break;
            case Kontinent.Afrika:
                //TODO
                break;
            case Kontinent.Australia:
                //TODO
                break;

        }

        return villeDyrIKontinent;
    }
}
