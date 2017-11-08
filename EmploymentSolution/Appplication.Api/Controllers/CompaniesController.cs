using Application.Service.Abstract;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class CompaniesController : ApiController
    {
        private readonly ICompanyService service;

        public CompaniesController(ICompanyService service)
        {
            this.service = service;
        }

        // GET: /api/companies
        public IHttpActionResult GetCompanies()
        {
            var companies = service.GetAll();
            return Ok(companies);
        }
    }
}
