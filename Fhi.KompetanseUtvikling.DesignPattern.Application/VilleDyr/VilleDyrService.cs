using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Krokodille;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Entities.Slange;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Enum;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;

namespace Fhi.KompetanseUtvikling.DesignPattern.Application.VilleDyr;
public class VilleDyrService
{
    public VilleDyrIKontinent FinnVilleDyrIKontinent(Kontinent kontinent, IKattFactory kattFactory)
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
                villeDyrIKontinent.Katt = kattFactory.CreateKatt();

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
                villeDyrIKontinent.Katt = kattFactory.CreateKatt();
                //TODO Bjørn
                //TODO Katt
                //TODO Rareste

                break;

            case Kontinent.Asia:
                villeDyrIKontinent.Katt = kattFactory.CreateKatt();
                //TODO
                break;
            case Kontinent.Afrika:
                villeDyrIKontinent.Katt = kattFactory.CreateKatt();
                //TODO
                break;
            case Kontinent.Australia:
                //TODO
                break;

        }

        return villeDyrIKontinent;
    }
}
