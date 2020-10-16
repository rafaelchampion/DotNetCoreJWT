using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JwtTest.WebAPI.Controllers
{
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("teste")]
        [Authorize(Roles = "Manager")]
        public async Task<ActionResult<dynamic>> GetSomething()
        {
            return "Sucesso";
        }
    }
}