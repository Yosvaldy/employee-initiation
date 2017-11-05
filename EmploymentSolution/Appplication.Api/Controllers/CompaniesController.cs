using Application.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Appplication.Api.Controllers
{
    public class CompaniesController : ApiController
    {
        private readonly ICompanyService companyService;

        public CompaniesController(ICompanyService comService)
        {
            companyService = comService;
        }

        // GET: /api/companies
        public IHttpActionResult GetCompanies()
        {
            var companies = companyService.GetAll();
            return Ok(companies);
        }
    }
}
