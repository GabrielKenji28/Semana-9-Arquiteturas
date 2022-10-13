using AppFinalCaminhao.Infra.Models;
using AppFinalCaminhao.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinalCaminhao.Service.Inteface
{
    public interface ICaminhaoService
    {
        public void AnunciarCaminhao(Caminhao caminhao);
        public List<Caminhao> ListarOsCaminhoes();
        public void ComprarCaminhao(Caminhao caminhao);
        public Caminhao BuscarPorId(int id);
        public void Editando(Caminhao caminhao);

    }
}
