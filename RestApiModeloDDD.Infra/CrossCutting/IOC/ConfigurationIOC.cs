using Autofac;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mapper;
using RestApiModeloDDD.Application.Mapper;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Services;
using RestApiModeloDDD.Infra.Data.Repositories;

namespace RestApiModeloDDD.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceEmpresa>().As<IApplicationServiceEmpresa>();
            builder.RegisterType<ServiceEmpresa>().As<IServiceEmpresa>();
            builder.RegisterType<RepositoryEmpresa>().As<IRepositoryEmpresa>();
            builder.RegisterType<RepositoryEmpresa>().As<IRepositoryEmpresa>();
            builder.RegisterType<MapperEmpresa>().As<IMapperEmpresa>();
        }
    }
}
