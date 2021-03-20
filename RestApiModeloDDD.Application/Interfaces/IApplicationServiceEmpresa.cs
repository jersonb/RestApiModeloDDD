using RestApiModeloDDD.Application.DTOs;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceEmpresa
    {
        void Add(EmpresaDTO empresaDTO);
        void Update(EmpresaDTO empresaDTO);
        void Remove(EmpresaDTO empresaDTO);
        IEnumerable<EmpresaDTO> GetAll();
        EmpresaDTO GetById(int id);
    }
}
