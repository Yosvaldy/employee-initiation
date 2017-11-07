using Application.Dtos;
using Application.Service.Abstract;
using AutoMapper;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class EmploymentsController : ApiController
    {
        private readonly IEmploymentService employmentService;
        private readonly IMapper mapper;

        public EmploymentsController(IEmploymentService emplService, IMapper mapp)
        {
            this.employmentService = emplService;
            this.mapper = mapp;
        }

        // GET: /api/employments
        [HttpGet]
        public IHttpActionResult GetEmployments()
        {
            var employments = employmentService.GetAll();
            return Ok(employments);
        }

        // GET: /api/employments/1
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var employment = employmentService.GetById(id);
            return Ok(employment);
        }

        [HttpPost]
        public IHttpActionResult Create(EmploymentDto emp)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            employmentService.Create(emp);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(EmploymentDto emp)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            employmentService.Update(emp);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var employment = employmentService.GetById(id);
            employmentService.Delete(employment.EmploymentId);
            return Ok();
        }

    }
}
