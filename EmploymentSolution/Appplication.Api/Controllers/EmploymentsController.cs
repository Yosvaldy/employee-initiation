using Application.Service.Abstract;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class EmploymentsController : ApiController
    {
        private readonly IEmploymentService employmentService;

        public EmploymentsController(IEmploymentService emplService)
        {
            this.employmentService = emplService;
        }

        // GET: /api/employments
        public IHttpActionResult GetEmployments()
        {
            var employments = employmentService.GetAll();
            return Ok(employments);
        }
    }
}
