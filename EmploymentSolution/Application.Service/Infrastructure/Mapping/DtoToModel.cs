using Application.Dtos;
using Application.Model.Entities;
using AutoMapper;
using System.Linq;

namespace Application.Service.Infrastructure.Mapping
{
    public class DtoToModel : Profile
    {
        public DtoToModel()
        {
            CreateMaps();
        }

        public void CreateMaps()
        {
            CreateMap<EmploymentDto, Employment>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.FullName, opt => opt.MapFrom(cr => cr.Employee.FullName))
                .ForMember(c => c.Email, opt => opt.MapFrom(cr => cr.Employee.Email))
                .ForMember(c => c.Phone, opt => opt.MapFrom(cr => cr.Employee.Phone))
                .ForMember(c => c.Accesses, opt => opt.Ignore())
                .AfterMap((cr, c) => {
                    //Remove unselected Access
                    //var removedAccesses = new List<EmploymentAccess>();
                    //foreach (var a in c.Accesses)
                    //    if (!cr.Accesses.Contains(a.AccessId))
                    //        removedAccesses.Add(a);
                    var removedAccesses = c.Accesses
                            .Where(a => !cr.Accesses
                            .Contains(a.AccessId));
                    foreach (var a in removedAccesses)
                        c.Accesses.Remove(a);

                    //Add new access
                    //foreach (var id in cr.Accesses)
                    //    if (!c.Accesses.Any(a => a.AccessId == id))
                    //      c.Accesses.Add(new EmploymentAccess { AccessId = id });
                    var addedAccesses = cr.Accesses
                            .Where(id => !c.Accesses
                            .Any(a => a.AccessId == id))
                            .Select(id => new EmploymentAccess { AccessId = id });

                    foreach (var a in addedAccesses)
                        c.Accesses.Add(a);

                })
                .ForMember(c => c.Equipments, opt => opt.Ignore())
                .AfterMap((cr, c) => {
                    var removedEquipment = c.Equipments.Where(e => !cr.Equipments.Contains(e.EquipmentId));
                    foreach (var e in removedEquipment)
                        c.Equipments.Remove(e);

                    var addedEquipments = cr.Equipments
                        .Where(id => !c.Equipments.Any(e => e.EquipmentId == id))
                        .Select(id => new EmploymentEquipment { EquipmentId = id });

                    foreach (var e in addedEquipments)
                        c.Equipments.Add(e);
                });

            //.ForMember(c => c.Accesses, opt => opt.MapFrom(cr => cr.Accesses.Select(id => new EmploymentAccess { AccessId = id })))
            //.ForMember(c => c.Equipments, opt => opt.MapFrom(cr => cr.Equipments.Select(id => new EmploymentEquipment { EquipmentId = id})));

            CreateMap<CompanyDto, Company>();
            CreateMap<PositionDto, Position>();
            CreateMap<EquipmentDto, Equipment>();
            CreateMap<AccessDto, Access>();
        }
    }
}
