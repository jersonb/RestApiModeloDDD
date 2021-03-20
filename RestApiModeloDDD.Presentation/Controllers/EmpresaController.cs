using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;

namespace RestApiModeloDDD.Presentation.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IApplicationServiceEmpresa _service;
        public EmpresaController(IApplicationServiceEmpresa applicationService)
        {
            _service = applicationService;
        }
  
        public ActionResult Index()
        {
            var empresas = _service.GetAll();
            return View(empresas);
        }

        [HttpGet]
        public ActionResult Create()
        {
            EmpresaDTO empresa = new EmpresaDTO();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Create(EmpresaDTO empresa)
        {
            _service.Add(empresa);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var empresa = _service.GetById(id);
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Edit(EmpresaDTO empresa)
        {
            _service.Update(empresa);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var empresa = _service.GetById(id);
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Delete(EmpresaDTO empresa)
        {
            _service.Remove(empresa);
            return RedirectToAction("Index");
        }        
    }
}
