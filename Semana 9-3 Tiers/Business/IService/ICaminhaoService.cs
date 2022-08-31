using AppFinalCaminhao.Models;

namespace AppFinalCaminhao.Semana_9_3_Tiers.Business.IService
{
    public interface ICaminhaoService
    {
        public void CadastrarCaminhao(Caminhao caminhao);
        public void EditarCaminhao(Caminhao caminhao);
        public void MarcarComprado(Caminhao caminhao);
    }
}
