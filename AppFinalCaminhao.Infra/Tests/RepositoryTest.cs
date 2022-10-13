using AppFinalCaminhao.Infra.Models;
using AppFinalCaminhao.Infra.Repository;
using System;
namespace AppFinalCaminhao.Infra.Tests
{
    public class RepositoryTest
    {
        public Caminhao caminhao = new Caminhao
        {
            Nome = "caminhao para teste",
            Descricao = "de carga teste",
            Modelo = Models.Enums.EnumModelo.Modelos.Jetta ,
            DataCriacao = "1000"
        };

        
    }
}
