using Application.Service.Abstract;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class EquipmentsController : ApiController
    {
        private readonly IEquipmentService service;

        public EquipmentsController(IEquipmentService service)
        {
            this.service = service;
        }

        // GET: /api/services
        public IHttpActionResult GetEquipments()
        {
            var services = service.GetAll();
            return Ok(services);
        }
    }
}
