using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Infra.Data.Repositories
{
    public class RepositoryEmpresa : RepositoryBase<Empresa>, IRepositoryEmpresa
    {
        private readonly SqlContext _sqlContext;

        public RepositoryEmpresa(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
