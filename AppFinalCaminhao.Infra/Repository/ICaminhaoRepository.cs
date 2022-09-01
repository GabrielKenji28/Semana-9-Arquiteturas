using AppFinalCaminhao.Infra.Models;
using System.Collections.Generic;

namespace AppFinalCaminhao.Infra.Repository
{
    public interface ICaminhaoRepository
    {
        List<Caminhao> ListarCaminhoes();
        Caminhao Adicionar(Caminhao caminhao);
        Caminhao Editar(Caminhao caminhao);
        Caminhao BuscarPorId(int id);
        Caminhao Deletar(Caminhao caminhao);
    }
}
