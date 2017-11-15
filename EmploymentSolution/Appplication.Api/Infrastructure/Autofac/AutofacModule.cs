using Application.DAL.Abstract.Interfaces;
using Application.DAL.Concrete.Repositories;
using Application.Model;
using Application.Service.Abstract;
using Application.Service.Infrastructure.Mapping;
using Autofac;
using AutoMapper;
using System.Data.Entity;
using System.Web.Mvc;

namespace Appplication.Api.Infrastructure.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            RegisterServices(builder);
            RegisterAutoMapper(builder);
            RegisterRepositories(builder);
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IEmploymentService).Assembly)
                       .AsImplementedInterfaces().InstancePerLifetimeScope();
        }

        private static void RegisterRepositories(ContainerBuilder builder)
        {
            var assemblies = new[] { typeof(IEmploymentRepository).Assembly, typeof(EmploymentRepository).Assembly };
            builder.RegisterAssemblyTypes(assemblies)
                       .AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<AppDbContext>().As<DbContext>().InstancePerLifetimeScope();
        }



        void RegisterAutoMapper(ContainerBuilder builder)
        {
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.ConstructServicesUsing(DependencyResolver.Current.GetService);
                cfg.AddProfiles(typeof(DtoToModel).Assembly);
            })).SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>()
                   .SingleInstance()
                   .PropertiesAutowired()
                   .PreserveExistingDefaults();

            builder.RegisterAssemblyTypes(typeof(IEmploymentService).Assembly)
                .AsClosedTypesOf(typeof(IValueResolver<,,>))
                .AsSelf().InstancePerLifetimeScope();
        }
    }
}