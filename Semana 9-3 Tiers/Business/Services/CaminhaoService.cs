using AppFinalCaminhao.Models;
using AppFinalCaminhao.Repository;
using AppFinalCaminhao.Semana_9_3_Tiers.Business.IService;
using System;

namespace AppFinalCaminhao.Semana_9_3_Tiers.Services
{
    public class CaminhaoService : ICaminhaoService
    {
        ICaminhaoRepository _caminhaoRepository;
        public CaminhaoService(ICaminhaoRepository caminhaoRepo)
        {
            _caminhaoRepository = caminhaoRepo;
        }

        public void CadastrarCaminhao ( Caminhao caminhao)
        {
            try
            {
                _caminhaoRepository.Adicionar(caminhao);

            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao cadastrar o carro : {erro.Message}");
            }

        }

        public void EditarCaminhao ( Caminhao caminhao)
        {
            try
            {
                _caminhaoRepository.Editar(caminhao);
            }
            catch ( Exception erro)
            {

                throw new Exception($"Erro ao editar o carro {erro.Message}");
            }
        }
        public void MarcarComprado (Caminhao caminhao)
        {
            try
            {
                _caminhaoRepository.Deletar(caminhao);
            }
            catch (Exception erro)
            {

                throw new Exception($"Erro ao marcar como comprado {erro.Message}");
            }
        }

    }
}
