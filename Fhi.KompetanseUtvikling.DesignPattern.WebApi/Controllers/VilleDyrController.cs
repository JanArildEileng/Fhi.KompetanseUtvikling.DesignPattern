using Fhi.KompetanseUtvikling.DesignPattern.Application.VilleDyr;
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
        VilleDyrIKontinent villeDyrIKontinent = villeDyrService.FinnVilleDyrIKontinent(kontinent);
        return Ok(villeDyrIKontinent);

    }
}