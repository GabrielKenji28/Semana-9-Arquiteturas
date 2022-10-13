
using AppFinalCaminhao.Infra.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AppFinalCaminhao.Infra.Models;
using AppFinalCaminhao.Service.Inteface;
using AppFinalCaminhao.Service.CaminhaoService;

namespace AppFinalCaminhao.Controllers
{
    public class NewViewsController : Controller
    {
        private readonly ICaminhaoService _caminhaoService;
        public NewViewsController(ICaminhaoService caminhaoService)
        {
            _caminhaoService = caminhaoService;
        }

        public IActionResult Index()
        {
            List<Caminhao> ListaCaminhoes = _caminhaoService.ListarOsCaminhoes()  ;
            return View(ListaCaminhoes);
            }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            Caminhao caminhao = _caminhaoService.BuscarPorId(id);

            return View(caminhao);
        }

        public IActionResult Details(int id)
        {
            Caminhao caminhao = _caminhaoService.BuscarPorId(id);
            return View(caminhao);
        }

        //Perguntar por que a entrada da Edit é um caminhao não um Id;
        public IActionResult Edit(int id)
        {
            var caminhao = _caminhaoService.BuscarPorId(id);
            return View(caminhao);
        }

        [HttpPost]
        public IActionResult Create(Caminhao caminhao)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    _caminhaoService.AnunciarCaminhao(caminhao);
                    TempData["MensagemSucesso"] = "Carro cadastrado com sucesso";
                    return RedirectToAction("Index", _caminhaoService.ListarOsCaminhoes());
                }
                return View(caminhao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops,deu problema para o cadastro,detalhe do erro:{erro.Message}";
                return RedirectToAction("Index", _caminhaoService.ListarOsCaminhoes());
            }
        }

        //Perguntar por que a entrada da Edit é um caminhao não um Id;
        [HttpPost]
        public IActionResult Edit(Caminhao caminhao )
        {
            
            
            try
            {
               if (ModelState.IsValid)
                {

                    _caminhaoService.Editando(caminhao);
                    TempData["MensagemSucesso"] = "Carro editado com sucesso";
                    var list= _caminhaoService.ListarOsCaminhoes();
                    return RedirectToAction("Index",list);
                }

                    return View(caminhao);
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Ops,não foi possível alterar o carro,detalhe do erro :{erro.Message}";
                return RedirectToAction("Index", _caminhaoService.ListarOsCaminhoes());
            }
            
        }
        public IActionResult Apagar(Caminhao caminhao)
        {
            try
            {
                _caminhaoService.ComprarCaminhao(caminhao);
                TempData["MensagemSucesso"] = "Carro apagado com sucesso" ;
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Carro não foi apagado com sucesso{erro.Message}";           
                throw;
            }
            
        }

    }
}
