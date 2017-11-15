using Application.Dtos;
using Application.Model.Entities;
using AutoMapper;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Application.Service.Infrastructure.Resolvers
{
    public class AccessesResolver : IValueResolver<EmploymentSaveDto, Employment, ICollection<EmploymentAccess>>
    {
        public ICollection<EmploymentAccess> Resolve(EmploymentSaveDto source, Employment destination, ICollection<EmploymentAccess> destMember, ResolutionContext context)
        {
            var result = new Collection<EmploymentAccess>();
            source.Accesses.ToList().ForEach(accessId =>
            {
                result.Add(new EmploymentAccess
                {
                    AccessId = accessId,
                    EmploymentId = source.Id
                });
            });

            return result;
        }
    }
}
