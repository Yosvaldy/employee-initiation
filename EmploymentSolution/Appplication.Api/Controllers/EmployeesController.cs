using Application.Service.Abstract;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService empService)
        {
            this.employeeService = empService;
        }

        // GET: /api/employees
        public IHttpActionResult GetEmployees()
        {
            var employees = employeeService.GetAll();
            return Ok(employees);
        }
    }
}
