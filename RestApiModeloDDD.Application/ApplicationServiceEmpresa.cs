using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mapper;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceEmpresa : IApplicationServiceEmpresa
    {
        private readonly IServiceEmpresa service;
        private readonly IMapperEmpresa mapper;

        public ApplicationServiceEmpresa(IServiceEmpresa _service, IMapperEmpresa _mapper)
        {
            service = _service;
            mapper = _mapper;
        }

        public void Add(EmpresaDTO empresaDTO)
        {
            var empresa = mapper.MapperDTOToEntity(empresaDTO);
            service.Add(empresa);
        }

        public IEnumerable<EmpresaDTO> GetAll()
        {
            var empresas = service.GetAll();
            return mapper.MapperListDTOToEntity(empresas);
        }

        public EmpresaDTO GetById(int id)
        {
            var cliente = service.GetById(id);
            return mapper.MapperEntityToDTO(cliente);
        }

        public void Remove(EmpresaDTO empresaDTO)
        {
            var cliente = mapper.MapperDTOToEntity(empresaDTO);
            service.Remove(cliente);
        }

        public void Update(EmpresaDTO empresaDTO)
        {
            var cliente = mapper.MapperDTOToEntity(empresaDTO);
            service.Update(cliente);
        }
    }
}
