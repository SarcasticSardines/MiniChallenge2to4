using MC2to4.Services.Time;
using Microsoft.AspNetCore.Mvc;

namespace MC2to4.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class TimeController : ControllerBase
    {
    private readonly ITimeService _timeService;

    public TimeController(ITimeService timeService)
    {
        _timeService = timeService;
    }

    [HttpGet]
    [Route("GetBoth/{myName}/{myTime}")]

    public string GetBoth(string myName, string myTime)
    {
        return _timeService.GetBoth(myName, myTime);
    }
}
