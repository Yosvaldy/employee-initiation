using Application.Dtos;
using Application.Service.Abstract;
using AutoMapper;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class EmploymentsController : ApiController
    {
        private readonly IEmploymentService service;
        private readonly IMapper mapper;

        public EmploymentsController(IEmploymentService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        // GET: /api/employments
        [HttpGet]
        public IHttpActionResult GetEmployments()
        {
            var employments = service.GetAll();
            return Ok(employments);
        }

        // GET: /api/employments/1
        [HttpGet]
        public IHttpActionResult GetEmployment(int id)
        {
            var employment = service.GetById(id);
            return Ok(employment);
        }

        //POST: /api/employments
        [HttpPost]
        public IHttpActionResult Create(EmploymentDto employment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            service.Create(employment);

            var result = mapper.Map<EmploymentDto>(employment);
            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult Update(EmploymentDto employment)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            service.Update(employment);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var employment = service.GetById(id);
            service.Delete(employment.Id);
            return Ok();
        }

    }
}
