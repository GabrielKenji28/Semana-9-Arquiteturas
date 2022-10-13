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

        public void AnunciarCaminhao(Caminhao caminhao)
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

        public List<Caminhao> ListarOsCaminhoes()
        {
            try
            {
                return _caminhaoRepository.ListarCaminhoes();
            }
            catch (Exception e)
            {

                throw new Exception($"Erro : {e.Message} ");
            }
        }

        //public bool VerificaValor(Caminhao caminhao, float valor)
        //{
        //    if(valor >= caminhao )
        //}

        public void ComprarCaminhao(Caminhao caminhao)
        {
            try
            {
                _caminhaoRepository.Deletar(caminhao);
            }
            catch (Exception e)
            {

                throw new Exception($"Erro : {e.Message} ");
            }
        }
        public Caminhao BuscarPorId(int id)
        {
            try
            {
                var caminhao = _caminhaoRepository.BuscarPorId(id);
                return caminhao;
            }
            catch (Exception e)
            {

                throw new Exception($"Erro : {e.Message} ");
            }
        }
        public void Editando(Caminhao caminhao)
        {
            try
            {
                _caminhaoRepository.Editar(caminhao);
            }
            catch (Exception e)
            {

                throw new Exception($"Erro : {e.Message} ");
            }
        }

    }
}
