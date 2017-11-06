using Application.Service.Abstract;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class PositionsController : ApiController
    {
        private readonly IPositionService positionService;

        public PositionsController(IPositionService posService)
        {
            positionService = posService;
        }

        // GET: /api/positions
        public IHttpActionResult GetPositions()
        {
            var positions = positionService.GetAll();
            return Ok(positions);
        }
    }
}
