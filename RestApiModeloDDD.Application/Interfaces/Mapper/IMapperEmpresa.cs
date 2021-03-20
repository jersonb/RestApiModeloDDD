using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces.Mapper
{
    public interface IMapperEmpresa
    {
        Empresa MapperDTOToEntity(EmpresaDTO empresaDTO);
        EmpresaDTO MapperEntityToDTO(Empresa empresa);
        IEnumerable<EmpresaDTO> MapperListDTOToEntity(IEnumerable<Empresa> empresaDTO);
    }
}
