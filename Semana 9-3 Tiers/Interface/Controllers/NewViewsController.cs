using AppFinalCaminhao.Models;
using AppFinalCaminhao.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppFinalCaminhao.Controllers
{
    public class NewViewsController : Controller
    {
        private readonly ICaminhaoRepository _caminhaoRepository;
        public NewViewsController(ICaminhaoRepository caminhaoRepository)
        {
            _caminhaoRepository = caminhaoRepository;
        }

        public IActionResult Index()
        {
            List<Caminhao> ListaCaminhoes = _caminhaoRepository.ListarCaminhoes();
            return View(ListaCaminhoes);
            }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            Caminhao caminhao = _caminhaoRepository.BuscarPorId(id);

            return View(caminhao);
        }

        public IActionResult Details(int id)
        {
            Caminhao caminhao = _caminhaoRepository.BuscarPorId(id);
            return View(caminhao);
        }

        //Perguntar por que a entrada da Edit é um caminhao não um Id;
        public IActionResult Edit(int id)
        {
            var caminhao = _caminhaoRepository.BuscarPorId(id);
            return View(caminhao);
        }

        [HttpPost]
        public IActionResult Create(Caminhao caminhao)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    _caminhaoRepository.Adicionar(caminhao);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index", _caminhaoRepository.ListarCaminhoes());
                }
                return View(caminhao);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops,deu problema para o cadastro,detalhe do erro:{erro.Message}";
                return RedirectToAction("Index", _caminhaoRepository.ListarCaminhoes());
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

                    _caminhaoRepository.Editar(caminhao);
                    TempData["MensagemSucesso"] = "Contato editado com sucesso";
                    var list= _caminhaoRepository.ListarCaminhoes();
                    return RedirectToAction("Index",list);
                }

                    return View(caminhao);
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Ops,não foi possível alterar o contato,detalhe do erro :{erro.Message}";
                return RedirectToAction("Index", _caminhaoRepository.ListarCaminhoes());
            }
            
        }
        public IActionResult Apagar(Caminhao caminhao)
        {
            try
            {
                _caminhaoRepository.Deletar(caminhao);
                TempData["MensagemSucesso"] = "Contato apagado com sucesso" ;
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Contato não foi apagado com sucesso{erro.Message}";           
                throw;
            }
            
        }

    }
}
