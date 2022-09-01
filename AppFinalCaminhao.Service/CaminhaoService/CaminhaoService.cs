using AppFinalCaminhao.Infra.Models;
using AppFinalCaminhao.Infra.Repository;
using AppFinalCaminhao.Service.Inteface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinalCaminhao.Service.CaminhaoService
{
    public class CaminhaoService : ICaminhaoService
    {
        ICaminhaoRepository _caminhaoRepository;

        public CaminhaoService(ICaminhaoRepository caminhaoRepository)
        {
            _caminhaoRepository = caminhaoRepository;
        }

        public void CadastrarCaminhao(Caminhao caminhao)
        {
            try
            {
                _caminhaoRepository.Adicionar(caminhao);
            }
            catch (Exception e)
            {

                throw new Exception($"Erro : {e.Message} ") ;
            }
        }

    }
}
