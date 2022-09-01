using AppFinalCaminhao.Infra.Data;
using AppFinalCaminhao.Infra.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AppFinalCaminhao.Infra.Repository
{
    public class CaminhaoRepository : ICaminhaoRepository
    {
        private readonly BancoContext _bancoContext;
        public CaminhaoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<Caminhao> ListarCaminhoes()
        {
            return _bancoContext.Caminhoes.ToList();
        }

        public Caminhao Adicionar(Caminhao caminhao)
        {

            _bancoContext.Caminhoes.Add(caminhao);
            _bancoContext.SaveChanges();
            return caminhao;
        }

        public Caminhao Editar(Caminhao caminhao)
        {
            _bancoContext.Caminhoes.Update(caminhao);
            _bancoContext.SaveChanges();
            return caminhao;

        }

        public Caminhao BuscarPorId(int id)
        {
            var caminhao = _bancoContext.Caminhoes.Find(id);
            return caminhao;
        }

        public Caminhao Deletar(Caminhao caminhao)
        {

            _bancoContext.Caminhoes.Remove(caminhao);
            _bancoContext.SaveChanges();
            return caminhao;

        }

    }
}
