using Application.Service.Abstract;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class ServiceEquipmentsController : ApiController
    {
        private readonly IServiceEquipmentService serviceEquipmentService;

        public ServiceEquipmentsController(IServiceEquipmentService servEquipmentService)
        {
            serviceEquipmentService = servEquipmentService;
        }

        // GET: /api/serviceEquipments
        public IHttpActionResult GetServiceEquipments()
        {
            var services = serviceEquipmentService.GetAll();
            return Ok(services);
        }
    }
}
