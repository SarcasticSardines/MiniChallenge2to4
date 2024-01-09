using MC2to4.Services.Alligators;
using Microsoft.AspNetCore.Mvc;

namespace MC2to4.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class AlligatorController : ControllerBase
    {
    private readonly IAlligatorService _alligatorService;

    public AlligatorController(IAlligatorService alligatorService)
        {
        _alligatorService = alligatorService;
    }

    [HttpGet]
    [Route("GorL/{numA}/{numB}")]

    public string GorL(string numA, string numB)
    {
        return _alligatorService.GorL(numA, numB);
    }
        
    }
