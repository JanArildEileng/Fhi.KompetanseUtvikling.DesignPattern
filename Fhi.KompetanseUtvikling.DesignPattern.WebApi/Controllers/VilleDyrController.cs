using Fhi.KompetanseUtvikling.DesignPattern.Application.VilleDyr;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Enum;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KattFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KrokodilleFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.factory;
using Microsoft.AspNetCore.Mvc;

namespace Fhi.KompetanseUtvikling.DesignPattern.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class VilleDyrController : ControllerBase
{
    private readonly ILogger<VilleDyrController> _logger;

    public VilleDyrController(ILogger<VilleDyrController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "VilleDyr")]
    public ActionResult<VilleDyrIKontinent> Get([FromServices] VilleDyrService villeDyrService, Domene.Enum.Kontinent kontinent= Domene.Enum.Kontinent.SørAmerika)
    {
        IKattFactory? kattFactory = null;
        IKrokodilleFactory? krokodilleFactory = null;
        ISlangeFactory? slangeFactory = null;
        switch (kontinent)
        {
            case Kontinent.SørAmerika:
                kattFactory = new SørAmerikaKattFactory();
                krokodilleFactory = new SørAmerikaKrokodilleFactory();
                slangeFactory = new SørAmerikaSlangeFactory();
                break;

            case Kontinent.NordAmerika:
                kattFactory = new NordAmerikaKattFactory();
                krokodilleFactory = new NordAmerikaKrokodilleFactory();
                slangeFactory = new NordAmerikaSlangeFactory();
                break;
               

            case Kontinent.Asia:
                kattFactory = new AsiaKattFactory();
                krokodilleFactory = new AsiaKrokodilleFactory();
                slangeFactory = new AsiaSlangeFactory();
                break;
            case Kontinent.Afrika:
                kattFactory = new AfrikaKattFactory();
                krokodilleFactory = new AfrikaKrokodilleFactory();
                slangeFactory = new AfrikaSlangeFactory();
                break;
            case Kontinent.Australia:
                krokodilleFactory = new AustrliaKrokodilleFactory();
                slangeFactory = new AustraliaSlangeFactory();
                break;
        }


        VilleDyrIKontinent villeDyrIKontinent = villeDyrService.FinnVilleDyrIKontinent(kontinent, kattFactory, krokodilleFactory, slangeFactory);
        return Ok(villeDyrIKontinent);

    }
}