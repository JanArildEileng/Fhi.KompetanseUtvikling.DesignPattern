using Fhi.KompetanseUtvikling.DesignPattern.Application.VilleDyr;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Enum;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.Abstract;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KattFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.KrokodilleFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Factory.SlangeFactory;
using Fhi.KompetanseUtvikling.DesignPattern.Domene.Interface.abstractfactory;
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
    public ActionResult<VilleDyrIKontinent> Get([FromServices] VilleDyrService villeDyrService, Kontinent kontinent= Kontinent.SørAmerika)
    {
    
        VilleDyrIKontinent villeDyrIKontinent = villeDyrService.FinnVilleDyrIKontinent(kontinent, AbstractDyrFactory.Create(kontinent));
        return Ok(villeDyrIKontinent);

    }
}