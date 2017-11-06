using Application.Service.Abstract;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class AccessLevelsController : ApiController
    {
        private readonly IAccessLevelService accessService;

        public AccessLevelsController(IAccessLevelService accService)
        {
            this.accessService = accService;
        }

        // GET: /api/accessLevels
        public IHttpActionResult GetAccess()
        {
            var accessLevels = accessService.GetAll();
            return Ok(accessLevels);
        }
    }
}
