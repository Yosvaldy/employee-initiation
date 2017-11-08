using Application.Service.Abstract;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class AccessesController : ApiController
    {
        private readonly IAccessService service;

        public AccessesController(IAccessService service)
        {
            this.service = service;
        }

        // GET: /api/accesses
        public IHttpActionResult GetAccess()
        {
            var accesses = service.GetAll();
            return Ok(accesses);
        }
    }
}
