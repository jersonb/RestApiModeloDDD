using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;

namespace RestApiModelDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IApplicationServiceEmpresa _applicationService;
        public EmpresaController(IApplicationServiceEmpresa applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public ActionResult <IEnumerable<string>>Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody]EmpresaDTO empresaDTO)
        {
            try
            {
                if (empresaDTO == null)
                    return NotFound();

                _applicationService.Add(empresaDTO);
                return Ok("Cadastrado com sucesso");
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] EmpresaDTO empresaDTO)
        {
            try
            {
                if (empresaDTO == null)
                    return NotFound();

                _applicationService.Update(empresaDTO);
                return Ok("Atualizado com sucesso");
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] EmpresaDTO empresaDTO)
        {
            try
            {
                if (empresaDTO == null)
                    return NotFound();

                _applicationService.Remove(empresaDTO);
                return Ok("Deletado com sucesso");
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
