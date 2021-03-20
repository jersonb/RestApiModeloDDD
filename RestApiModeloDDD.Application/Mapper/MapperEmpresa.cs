using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces.Mapper;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mapper
{
    public class MapperEmpresa : IMapperEmpresa
    {
        public Empresa MapperDTOToEntity(EmpresaDTO empresaDTO)
        {
            return new Empresa
            {
                Id = empresaDTO.Id,
                Nome = empresaDTO.Nome,
                Site = empresaDTO.Site,
                QuantidadeFuncionarios = empresaDTO.QuantidadeFuncionarios
            };
        }

        public EmpresaDTO MapperEntityToDTO(Empresa empresa)
        {
            return new EmpresaDTO
            {
                Id = empresa.Id,
                Nome = empresa.Nome,
                Site = empresa.Site,
                QuantidadeFuncionarios = empresa.QuantidadeFuncionarios
            };
        }

        public IEnumerable<EmpresaDTO> MapperListDTOToEntity(IEnumerable<Empresa> empresas)
        {
            var empresasDTO = empresas.Select(c => new EmpresaDTO
            {
                Id = c.Id,
                Nome = c.Nome,
                Site = c.Site,
                QuantidadeFuncionarios = c.QuantidadeFuncionarios
            });

            return empresasDTO;
        }
    }
}
