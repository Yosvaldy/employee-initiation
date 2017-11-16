using System.Collections.Generic;

namespace Application.Dtos
{
    public class CompanyDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<string> Accesses { get; set; }

        public CompanyDetailsDto()
        {
            Accesses = new List<string>();
        }

    }
}
