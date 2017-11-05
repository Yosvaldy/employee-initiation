using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class CompanyViewModel
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<AccessLevel> AccessLevels { get; set; }
    }
}
