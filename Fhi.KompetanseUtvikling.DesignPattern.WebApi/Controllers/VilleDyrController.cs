using Fhi.KompetanseUtvikling.DesignPattern.Application.VilleDyr;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Enum;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KattFactory;
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

        IKattFactory kattFactory = null;
        switch (kontinent)
        {
            case Kontinent.SørAmerika:
                kattFactory = new SørAmerikaKattFactory();
                break;

            case Kontinent.NordAmerika:
                kattFactory = new NordAmerikaKattFactory();
                break;

            case Kontinent.Asia:
                kattFactory = new AsiaKattFactory();
                break;
            case Kontinent.Afrika:
                kattFactory = new AfrikaKattFactory();
                break;
                break;
            case Kontinent.Australia:
                break;

        }



        VilleDyrIKontinent villeDyrIKontinent = villeDyrService.FinnVilleDyrIKontinent(kontinent, kattFactory);
        return Ok(villeDyrIKontinent);

    }
}