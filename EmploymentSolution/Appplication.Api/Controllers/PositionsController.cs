using Application.Service.Abstract;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class PositionsController : ApiController
    {
        private readonly IPositionService service;

        public PositionsController(IPositionService service)
        {
            this.service = service;
        }

        // GET: /api/positions
        public IHttpActionResult GetPositions()
        {
            var positions = service.GetAll();
            return Ok(positions);
        }
    }
}
