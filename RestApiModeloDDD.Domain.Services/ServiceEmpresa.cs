using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceEmpresa : ServiceBase<Empresa>, IServiceEmpresa
    {
        private readonly IRepositoryEmpresa repositoryEmpresa;

        public ServiceEmpresa(IRepositoryEmpresa _repositoryEmpresa): base(_repositoryEmpresa)
        {
            repositoryEmpresa = _repositoryEmpresa;
        }
    }
}
