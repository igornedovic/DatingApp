using DatingAppNew.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DatingAppNew.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        
    }
}